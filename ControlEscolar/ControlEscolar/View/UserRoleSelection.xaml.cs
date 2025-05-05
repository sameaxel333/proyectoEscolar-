using ControlEscolar;
using ControlEscolar.View;
using System;
using System.Data;
using System.Linq;
using System.Windows;

namespace ProyectoEscolarizado.View
{
    public partial class UserRoleSelection : Window
    {
        public UserRoleSelection()
        {
            InitializeComponent();
        }

        private void Estudiante_Click(object sender, RoutedEventArgs e)
        {
            AbrirLogin("Estudiantes");
        }

        private void Maestro_Click(object sender, RoutedEventArgs e)
        {
            AbrirLogin("Maestros");
        }

        private void Admin_Click(object sender, RoutedEventArgs e)
        {
            AbrirLogin("Administradores");
        }

        private void AbrirLogin(string role)
        {
            App.UserRole = role;

            if (Application.Current.Windows.OfType<LoginView>().Count() == 0)
            {
                var loginView = new LoginView(role);
                loginView.Show();
            }

            Window.GetWindow(this)?.Close();
        }
        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}