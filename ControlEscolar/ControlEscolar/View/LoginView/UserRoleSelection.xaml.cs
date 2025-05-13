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
            AbrirLogin("Estudiante");
        }

        private void Maestro_Click(object sender, RoutedEventArgs e)
        {
            AbrirLogin("Maestro");
        }

        private void Admin_Click(object sender, RoutedEventArgs e)
        {
            AbrirLogin("Administrador");
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