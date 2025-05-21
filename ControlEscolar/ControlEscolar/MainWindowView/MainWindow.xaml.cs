using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using ControlEscolar.MainWindowView.StudentView;
using ControlEscolar.MoreWindows;
using ControlEscolar.Repositories;
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
            Application.Current.Shutdown();
        }

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void Inscripciones_Click(object sender, RoutedEventArgs e)
        {
            CourseRegistrationView ventana = new CourseRegistrationView();
            ventana.Show();
            this.Hide();
        }
        private void Pagos_Click(object sender, RoutedEventArgs e)
        {
            PaymentView ventana = new PaymentView();
            ventana.Show();
            this.Hide();
        }
        private void Materias_Click(object sender, RoutedEventArgs e) {
            SchedulesView ventana = new SchedulesView();
            ventana.Show();
            this.Hide();
        }

        private void ContactClick(object sender, RoutedEventArgs e)
        {
            ContactViewMain ventana = new ContactViewMain();
            ventana.Show();
            this.Hide();
        }
        private void UbicacionClick(object sender, RoutedEventArgs e)
        {
            UbicacionView ventana = new UbicacionView();
            ventana.Show();
            this.Hide();
        }

        private void PlanEstudiosClick(object sender, RoutedEventArgs e)
        {
            PlanEstudiosView ventana = new PlanEstudiosView();
            ventana.Show();
            this.Hide();
        }
        private void InstitucionClick(object sender, RoutedEventArgs e)
        {
            Institucion ventana = new Institucion();
            ventana.Show();
            this.Hide();
        }
        private void CerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }
        private void GenerarMateriasTXT_Click(object sender, RoutedEventArgs e)
        {
            var repo = new MateriaRepository(); // Usamos el repositorio de materias
            var materias = repo.ObtenerMaterias(); // Obtener la lista

            string rutaArchivo = "ListaMaterias.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(rutaArchivo))
                {
                    writer.WriteLine("LISTA DE MATERIAS");
                    writer.WriteLine("=============================================");
                    writer.WriteLine("Nombre de la Materia");
                    writer.WriteLine("---------------------------------------------");

                    foreach (var mat in materias)
                    {
                        writer.WriteLine(mat.NombreMateria);
                    }
                }

                MessageBox.Show("Archivo TXT generado exitosamente.");

                // Abre el archivo automáticamente
                Process.Start(new ProcessStartInfo
                {
                    FileName = rutaArchivo,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar archivo: " + ex.Message);
            }
        }
    }
}
