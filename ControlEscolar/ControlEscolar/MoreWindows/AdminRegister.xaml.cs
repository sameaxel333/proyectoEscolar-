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
using System.Windows.Shapes;

namespace ControlEscolar.MoreWindows
{
    /// <summary>
    /// Lógica de interacción para AdminRegister.xaml
    /// </summary>
    public partial class AdminRegister : Window
    {
        public AdminRegister()
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
        private void Inicio_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ventanaPrincipal = new MainWindow();
            ventanaPrincipal.Show();
            this.Close();
        }
        private void Pagos_Click(object sender, RoutedEventArgs e)
        {
            PaymentView ventana = new PaymentView();
            ventana.Show();
            this.Close();
        }
    }
}

