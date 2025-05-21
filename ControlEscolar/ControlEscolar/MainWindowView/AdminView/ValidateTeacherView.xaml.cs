using ControlEscolar.View;
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

namespace ControlEscolar.MainWindowView.AdminView
{
    /// <summary>
    /// Lógica de interacción para ValidateTeacherView.xaml
    /// </summary>
    public partial class ValidateTeacherView : Window
    {
        public ValidateTeacherView()
        {
            InitializeComponent();
        }
        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void Inicio_Click(object sender, RoutedEventArgs e)
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
        private void ValidarAlumno_Click(object sender, RoutedEventArgs e)
        {
            ValidateStudentView ventana = new ValidateStudentView(); // <--- Nombre de la ventana Validar Maestro
            ventana.Show();
            this.Close();
        }

        private void Cursos_Click(object sender, RoutedEventArgs e)
        {
            CourseManagementView ventana = new CourseManagementView(); // <--- Nombre de la ventana Validar Alumno
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
        private void CerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }
    }
}
