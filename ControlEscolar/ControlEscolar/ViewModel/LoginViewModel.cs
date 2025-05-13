using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using ControlEscolar.Model;
using ControlEscolar.Repositories;

namespace ControlEscolar.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        //Campos 
        private string _username;
        private SecureString _password;
        private string _errorMessage;
        private bool _isViewVisible = true;
        private IUserRepository userRepository;

        //Propiedades
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        public SecureString Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }

        }
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }
        public bool IsViewVisible
        {
            get { return _isViewVisible; }
            set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }
        //Comandos
        public ICommand LoginCommand { get; }
        public ICommand ShowPasswordCommand { get; }

        //Constructor
        public LoginViewModel()
        {
            userRepository = new UserRepository();
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);

        }
        private bool CanExecuteLoginCommand(object parameter)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(Username)
                || Username.Length < 3
                || Password == null
                || Password.Length < 3)
                validData = false;
            else
                validData = true;
            return validData;
        }
        private void ExecuteLoginCommand(object obj)
        {
            string plainPassword = ConvertToUnsecureString(Password);
            byte[] passwordHash = SHA256.Create().ComputeHash(Encoding.GetEncoding(28591).GetBytes(plainPassword));

            var isValidUser = userRepository.AuthenticateUser(Username, passwordHash, App.UserRole);
            if (isValidUser)
            {
                Thread.CurrentPrincipal = new GenericPrincipal(
                    new GenericIdentity(Username), null);
                IsViewVisible = false;

                // Nueva lógica para abrir según rol
                if (App.UserRole == "Maestro")
                {
                    OpenMainWindowMaestro();
                }
                else if (App.UserRole == "Administrador")
                {
                    OpenMainWindowAdmin(); // Admin u otros
                }
                else
                {
                    OpenMainWindow();
                }
            }
            else
            {
                ErrorMessage = "* Usuario o contraseña inválidos";
            }
        }

        private void OpenMainWindowAdmin()
        {
            var userInfo = userRepository.GetUserAdminInfo(Username);

            var userModel = new UserModel
            {
                Name = userInfo.Nombre,
                Edad = userInfo.Edad,
                CURP = userInfo.CURP
            };

            var mainWindowAdmin = System.Windows.Application.Current.Windows.OfType<MainWindowAdmin>().FirstOrDefault();

            if (mainWindowAdmin != null)
            {
                mainWindowAdmin.Show(); 
            }
            else
            {
                mainWindowAdmin = new MainWindowAdmin() 
                {
                    DataContext = userModel
                };

                mainWindowAdmin.Show(); 
            }
        }


        private void OpenMainWindowMaestro()
        {
            var userInfo = userRepository.GetUserMaestroInfo(Username);

            var userModel = new UserModel
            {
                Name = userInfo.Nombre,
                Edad = userInfo.Edad,
                CURP = userInfo.CURP
            };

            var mainWindowMaestro = System.Windows.Application.Current.Windows.OfType<MainWindowMaestro>().FirstOrDefault();

            if (mainWindowMaestro != null)
            {
                mainWindowMaestro.Show(); // ✅ Recupera la ventana existente sin crear una nueva
            }
            else
            {
                mainWindowMaestro = new MainWindowMaestro // 🔥 Se asigna correctamente la nueva instancia
                {
                    DataContext = userModel
                };

                mainWindowMaestro.Show(); // ✅ Ahora sí existe una instancia válida antes de llamar a Show()
            }
        }
        private void OpenMainWindow()
        {
            var userInfo = userRepository.GetUserInfo(Username);

            var userModel = new UserModel
            {
                Name = userInfo.Nombre,
                Edad = userInfo.Edad,
                CURP = userInfo.CURP
            };
            var mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

            if (mainWindow != null)
            {
                mainWindow.Show(); // ✅ Muestra la instancia existente
            }
            else
            {

                mainWindow = new MainWindow()
                {
                    DataContext = userModel
                }; ; // ❌ Solo crea una nueva si no existe
                mainWindow.Show();
            }


            
        }

        private string ConvertToUnsecureString(SecureString secureString)
        {
            if (secureString == null)
                return string.Empty;

            IntPtr unmanagedString = System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocUnicode(secureString);
            try
            {
                return System.Runtime.InteropServices.Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }

    }
}