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
using System.Windows.Shapes;

namespace ControlEscolar.View
{
    /// <summary>
    /// Lógica de interacción para Institucion.xaml
    /// </summary>
    public partial class InstitucionMainAdmin : Window
    {
        public InstitucionMainAdmin()
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
            var mainWindowAdmin = System.Windows.Application.Current.Windows.OfType<MainWindowAdmin>().FirstOrDefault();
            if (mainWindowAdmin != null)
            {
                mainWindowAdmin.Show(); // Recupera la ventana abierta sin crear una nueva instancia
            }
            else
            {
                new MainWindowAdmin().Show(); // Solo crea una nueva si no existe
            }
            this.Close();
        }
    }
}
