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
    public partial class PlanEstudiosView : Window
    {
        public PlanEstudiosView()
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

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = System.Windows.Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (mainWindow != null)
            {
                mainWindow.Show(); // ✅ Recupera la ventana abierta sin crear una nueva instancia
            }
            else
            {
                new MainWindow().Show(); // ❌ Solo crea una nueva si no existe
            }
            this.Close();
        }
    }
}
