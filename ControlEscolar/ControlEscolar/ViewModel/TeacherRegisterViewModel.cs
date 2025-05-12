using ControlEscolar.Model;
using ControlEscolar.MoreWindows;
using ControlEscolar.Repositories;
using ControlEscolar.Helpers; 
using ProyectoEscolarizado.View;
using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace ControlEscolar.ViewModel
{
    public class TeacherRegisterViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private readonly IUserRepository _userRepository;

        public ICommand RegisterCommand { get; }

        public TeacherRegisterViewModel()
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

        // Propiedades del formulario
        private int _Numero_Empleado;
        public int Numero_Empleado
        {
            get => _Numero_Empleado;
            set { _Numero_Empleado = value; OnPropertyChanged(); }
        }

        private string _curp;
        public string CURP
        {
            get => _curp;
            set { _curp = value; OnPropertyChanged(); }
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

        private DateTime _fechaNacimiento;
        public DateTime FechaNacimiento
        {
            get => _fechaNacimiento;
            set { _fechaNacimiento = value; OnPropertyChanged(); }
        }

        private bool CanExecuteRegister(object parameter)
        {
            return !string.IsNullOrEmpty(CURP) &&
                   !string.IsNullOrEmpty(Nombre) &&
                   !string.IsNullOrEmpty(Password);
        }


        private void ExecuteRegister(object parameter)
        {
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
            if (string.IsNullOrWhiteSpace(this.Password))
            {
                System.Windows.MessageBox.Show("La contraseña no puede estar vacía.");
                return;
            }


            var newUser = new UserModel
            {
                Numero_Empleado = this.Numero_Empleado,
                CURP = this.CURP,
                Nombre = this.Nombre,
                Edad = edadCalculada,
                FechaNacimiento = this.FechaNacimiento,
            };

            bool inserto = _userRepository.InsertTeacher(newUser, this.Password);

            if (inserto)
            {
                System.Windows.MessageBox.Show("Se envió la solicitud correctamente.", "Registro Exitoso", MessageBoxButton.OK, MessageBoxImage.Information);
                UserRoleSelection userRoleSelectionWindow = new UserRoleSelection();
                userRoleSelectionWindow.Show();
                System.Windows.Application.Current.Windows.OfType<TeacherRegister>().FirstOrDefault()?.Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Hubo un error al registrar el usuario.");
            }
        }
    }
}