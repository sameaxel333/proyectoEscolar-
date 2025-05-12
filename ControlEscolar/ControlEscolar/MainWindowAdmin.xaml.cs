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
using ControlEscolar.MoreWindows;
using ControlEscolar.View;

namespace ControlEscolar
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindowAdmin : Window
    {
        public MainWindowAdmin()
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

        private void ValidarMaestro_Click(object sender, RoutedEventArgs e)
        {
            ContactViewMain ventana = new ContactViewMain(); // <--- Nombre de la ventana Validar Maestro
            ventana.Show();
            this.Close();
        }

        private void GestionCurso_Click(object sender, RoutedEventArgs e)
        {
            ContactViewMain ventana = new ContactViewMain(); // <--- Nombre de la ventana Validar Alumno
            ventana.Show();
            this.Close();
        }

        private void ValidarAlumno_Click(object sender, RoutedEventArgs e)
        {
            ContactViewMain ventana = new ContactViewMain(); // <--- Nombre de la ventana Validar Alumno
            ventana.Show();
            this.Close();
        }

        private void ContactClick(object sender, RoutedEventArgs e)
        {
            ContactViewMainAdmin ventana = new ContactViewMainAdmin();
            ventana.Show();
            this.Close();
        }
        private void UbicacionClick(object sender, RoutedEventArgs e)
        {
            UbicacionViewMainAdmin ventana = new UbicacionViewMainAdmin();
            ventana.Show();
            this.Close();
        }

        private void PlanEstudiosClick(object sender, RoutedEventArgs e)
        {
            PlanEstudiosViewAdmin ventana = new PlanEstudiosViewAdmin();
            ventana.Show();
            this.Close();
        }
        private void InstitucionClick(object sender, RoutedEventArgs e)
        {
            InstitucionMainAdmin ventana = new InstitucionMainAdmin();
            ventana.Show();
            this.Close();
        }
    }
}
