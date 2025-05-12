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
            
        }

        private void AbrirContactView(object sender, RoutedEventArgs e)
        {
            ContactView ventana = new ContactView();
            ventana.Show();
            this.Close();
        }

    }
}
