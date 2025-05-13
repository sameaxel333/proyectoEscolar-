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
    /// Lógica de interacción para RegistrationView.xaml
    /// </summary>
    public partial class RegistrationView : Window
    {
        public RegistrationView()
        {
            InitializeComponent();
        }
        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BindablePasswordBox_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Inicio_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (mainWindow != null)
            {
                mainWindow.Show(); // ✅ Muestra la instancia existente
            }
            else
            {
                mainWindow = new MainWindow(); // ❌ Solo crea una nueva si no existe
                mainWindow.Show();
            }

            this.Close();
        }
        private void Pagos_Click(object sender, RoutedEventArgs e)
        {
            PaymentView ventana = new PaymentView();
            ventana.Show();
            this.Close();
        }
        private void Materias_Click(object sender, RoutedEventArgs e)
        {
            CreacMaterias ventana = new CreacMaterias();
            ventana.Show();
            this.Close();
        }

        private void txtUser2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtUser1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
