using ControlEscolar.Helpers;
using ControlEscolar.Model;
using ControlEscolar.MoreWindows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using ControlEscolar.Repositories;
using System.Runtime.CompilerServices;
using ProyectoEscolarizado.View;

namespace ControlEscolar.ViewModel
{
    class AdminRegisterViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private readonly IUserRepository _userRepository;

        public ICommand RegisterCommand     { get; }

        public AdminRegisterViewModel()
        {
            _userRepository = new UserRepository();
            RegisterCommand = new RelayCommand(ExecuteRegister, CanExecuteRegister);
            FechaNacimiento = DateTime.Now;
        }

        // Implementación de INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _AdminId;
        public int AdminId
        {
            get => _AdminId;
            set { _AdminId = value; OnPropertyChanged(); }
        }


        private string _nombre;
        public string Nombre
        {
            get => _nombre;
            set { _nombre = value; OnPropertyChanged(); }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(); }
        }
        private string _curp;
        public string CURP
        {
            get => _curp;
            set { _curp = value; OnPropertyChanged(); }
        }

        private DateTime _fechaNacimiento;
        public DateTime FechaNacimiento
        {
            get => _fechaNacimiento;
            set { _fechaNacimiento = value; OnPropertyChanged(); }
        }


        

        private bool CanExecuteRegister(object parameter)
        {
            return 
                   !string.IsNullOrWhiteSpace(Nombre) &&
                   !string.IsNullOrWhiteSpace(Password);
        }

        private void ExecuteRegister(object parameter)
        {
            // Verifica que la contraseña no esté vacía
            if (string.IsNullOrWhiteSpace(Password))
            {
                System.Windows.MessageBox.Show("La contraseña no puede estar vacía.");
                return;
            }
            DateTime hoy = DateTime.Now;
            int edadCalculada = hoy.Year - FechaNacimiento.Year;

            if (hoy.Month < FechaNacimiento.Month || (hoy.Month == FechaNacimiento.Month && hoy.Day < FechaNacimiento.Day))
            {
                edadCalculada--;
            }


            // Validar edad mínima (por ejemplo, 18 años).
            if (edadCalculada < 18)
            {
                System.Windows.MessageBox.Show("Debes ser mayor de 18 años.");
                return;
            }


            // Convertir la contraseña a hash SHA256
            byte[] hashedPassword = System.Security.Cryptography.SHA256.Create()
                .ComputeHash(System.Text.Encoding.UTF8.GetBytes(Password));

            var newAdmin = new UserModel
            {
                AdminId = this.AdminId,
                CURP = this.CURP,
                Nombre = this.Nombre,
                Edad = edadCalculada,
                FechaNacimiento = this.FechaNacimiento,
            };

            bool inserto = _userRepository.InsertAdmin(newAdmin, Password);

            if (inserto)
            {
                System.Windows.MessageBox.Show("Registro exitoso.", "Registro Exitoso", MessageBoxButton.OK, MessageBoxImage.Information);
                UserRoleSelection userRoleSelectionWindow = new UserRoleSelection();
                userRoleSelectionWindow.Show();
                System.Windows.Application.Current.Windows.OfType<AdminRegister>()?.FirstOrDefault()?.Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Error al registrar el administrador.");
            }
        }
       
        public void NotifyCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }

    }
}
