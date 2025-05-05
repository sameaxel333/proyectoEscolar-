using ProyectoEscolarizado.View;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControlEscolar.View
{
    /// <summary>
    /// Interaction logic for ContactoView.xaml
    /// </summary>
    public partial class ContactView : Window
    {
        public ContactView()
        {
            InitializeComponent();
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            UserRoleSelection ventana = new UserRoleSelection();
            ventana.Show();
            this.Close();
        }

    }
}
