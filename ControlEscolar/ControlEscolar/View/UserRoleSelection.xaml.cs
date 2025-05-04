using ControlEscolar.View;
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

        private void AbrirLogin(string tipoUsuario)
        {
            // Aquí puedes pasar el tipo de usuario al ViewModel si lo necesitas
            var login = new LoginView(); // Asumiendo que LoginView recibe esto
            login.Show();
            this.Close();
        }
    }
}