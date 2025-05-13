using ControlEscolar.MoreWindows;
using ProyectoEscolarizado.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ControlEscolar.View
{
    /// <summary>
    /// Lógica de interacción para LoginView.xaml
    /// </summary>
    /// 
    
    public partial class LoginView : Window 
    {
        private string userRole;
        public LoginView(string role)
        {
            userRole = App.UserRole;
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BindablePasswordBox_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            UserRoleSelection ventana = new UserRoleSelection();
            ventana.Show();
            this.Close();
        }
        private void AbrirSignUpView(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(App.UserRole))
            {
                UserRoleSelection userRoleSelectionWindow = new UserRoleSelection();
                userRoleSelectionWindow.Show();
                this.Close();
                return;

            }

            Window signUpWindow = null;

            // Selecciona la ventana de registro correspondiente según el rol
            switch (App.UserRole)
            {
                case "Estudiante":
                    signUpWindow = new StudentRegister();
                    break;
                case "Maestro":
                    signUpWindow = new TeacherRegister();
                    break;
                case "Administrador":
                    signUpWindow = new AdminRegister();
                    break;
                default:
                    MessageBox.Show("El rol asignado no es reconocido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
            }

            // Abre la ventana de registro y cierra la ventana actual si es necesario
            signUpWindow.Show();
            this.Close();

        }

        private void AbrirContactView(object sender, RoutedEventArgs e)
        {
            ContactView ventana = new ContactView();
            ventana.Show();
            this.Close();
        }

    }
}
