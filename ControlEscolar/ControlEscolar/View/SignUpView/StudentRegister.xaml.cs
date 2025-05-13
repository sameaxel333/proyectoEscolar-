using ControlEscolar.View;
using ProyectoEscolarizado.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

namespace ControlEscolar.MoreWindows
{
    /// <summary>
    /// Lógica de interacción para StudentRegister.xaml
    /// </summary>
    public partial class StudentRegister : Window
    {
        public StudentRegister()
        {
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

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            UserRoleSelection ventana = new UserRoleSelection();
            ventana.Show();
            this.Close();
        }




        private void AbrirLoginView(object sender, RoutedEventArgs e)
        {
            // Verificamos que App.UserRole ya esté definido (por ejemplo, "Estudiante", "Maestro", etc.)
            if (string.IsNullOrWhiteSpace(App.UserRole))
            {
                UserRoleSelection userRoleSelectionWindow = new UserRoleSelection();
                userRoleSelectionWindow.Show();
                this.Close();
                return;

            }

            // Pasamos el rol actual a la ventana LoginView
            LoginView login = new LoginView(App.UserRole);
            login.Show();
            // Opcionalmente, cerrar la ventana actual si ya no se necesita.
            this.Close();
        }
        private void AbrirContactView(object sender, RoutedEventArgs e)
        {
            ContactView ventana = new ContactView();
            ventana.Show();
            this.Close();
        }

        private void txtUser1_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

    }
}
