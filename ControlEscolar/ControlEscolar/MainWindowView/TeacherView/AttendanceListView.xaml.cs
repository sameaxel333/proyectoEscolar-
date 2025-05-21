using ControlEscolar.MoreWindows;
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

namespace ControlEscolar.MainWindowView.TeacherView
{
    /// <summary>
    /// Lógica de interacción para AttendanceListView.xaml
    /// </summary>
    public partial class AttendanceListView : Window
    {
        public AttendanceListView()
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
            var mainWindowMaestro = System.Windows.Application.Current.Windows.OfType<MainWindowMaestro>().FirstOrDefault();
            if (mainWindowMaestro != null)
            {
                mainWindowMaestro.Show(); // ✅ Muestra la instancia existente
            }
            else
            {
                mainWindowMaestro = new MainWindowMaestro(); // ❌ Solo crea una nueva si no existe
                mainWindowMaestro.Show();
            }

            this.Close();
        }
        private void Cursos_Click(object sender, RoutedEventArgs e)
        {
            CourseTeacherRegistration ventana = new CourseTeacherRegistration();
            ventana.Show();
            this.Close();
        }
        private void Horarios_Click(object sender, RoutedEventArgs e)
        {
            SchedulesTeacherView ventana = new SchedulesTeacherView();
            ventana.Show();
            this.Close();
        }
        private void CerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }
        private void ContactClick(object sender, RoutedEventArgs e)
        {
            ContactViewMain ventana = new ContactViewMain();
            ventana.Show();
            this.Close();
        }
        private void UbicacionClick(object sender, RoutedEventArgs e)
        {
            UbicacionView ventana = new UbicacionView();
            ventana.Show();
            this.Close();
        }

        private void PlanEstudiosClick(object sender, RoutedEventArgs e)
        {
            PlanEstudiosView ventana = new PlanEstudiosView();
            ventana.Show();
            this.Close();
        }
        private void InstitucionClick(object sender, RoutedEventArgs e)
        {
            Institucion ventana = new Institucion();
            ventana.Show();
            this.Close();
        }
    }
}
