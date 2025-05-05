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
using ControlEscolar.MoreWindows;
using ControlEscolar.View;

namespace ControlEscolar
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void Inscripciones_Click(object sender, RoutedEventArgs e)
        {
            RegistrationView ventana = new RegistrationView();
            ventana.Show();
            this.Close();
        }
        private void Pagos_Click(object sender, RoutedEventArgs e)
        {
            PaymentView ventana = new PaymentView();
            ventana.Show();
            this.Close();
        }
        private void Materias_Click(object sender, RoutedEventArgs e) {
            CreacMaterias ventana = new CreacMaterias();
            ventana.Show();
            this.Close();
        }

        private void ContactClick(object sender, RoutedEventArgs e)
        {
            ContactViewMain ventana = new ContactViewMain();
            ventana.Show();
            this.Close();
        }
    }
}
