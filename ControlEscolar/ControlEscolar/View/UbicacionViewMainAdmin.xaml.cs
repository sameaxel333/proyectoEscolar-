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
using ProyectoEscolarizado.View;

namespace ControlEscolar.View
{
    /// <summary>
    /// Interaction logic for UbicacionView.xaml
    /// </summary>
    public partial class UbicacionViewMainAdmin : Window
    {
        public UbicacionViewMainAdmin()
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
            MainWindowMaestro ventana = new MainWindowMaestro();
            ventana.Show();
            this.Close();
        }
    }
}
