﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Shapes;
using ControlEscolar.MainWindowView.TeacherView;
using ControlEscolar.Model;
using ControlEscolar.MoreWindows;
using ControlEscolar.Repositories;
using ControlEscolar.View;

namespace ControlEscolar
{
    /// <summary>
    /// Interaction logic for MainWindowMaestro.xaml
    /// </summary>
    public partial class MainWindowMaestro : Window
    {
        public MainWindowMaestro()
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

        private void Horarios_Click(object sender, RoutedEventArgs e)
        {
            SchedulesTeacherView ventana = new SchedulesTeacherView();
            ventana.Show();
            this.Hide();
        }

        private void Cursos_Click(object sender, RoutedEventArgs e)
        {
            CourseTeacherRegistration ventana = new CourseTeacherRegistration();
            ventana.Show();
            this.Hide();
        }
        private void Asistencia_Click(object sender, RoutedEventArgs e)
        {
            AttendanceListView ventana = new AttendanceListView();
            ventana.Show();
            this.Hide();
        }

        private void CerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void ContactClick(object sender, RoutedEventArgs e)
        {
            ContactViewMainMaestro ventana = new ContactViewMainMaestro();
            ventana.Show();
            this.Hide();
        }
        private void UbicacionClick(object sender, RoutedEventArgs e)
        {
            UbicacionViewMainMaestro ventana = new UbicacionViewMainMaestro();
            ventana.Show();
            this.Hide();
        }

        private void PlanEstudiosClick(object sender, RoutedEventArgs e)
        {
            PlanEstudiosViewMainMaestro ventana = new PlanEstudiosViewMainMaestro();
            ventana.Show();
            this.Hide();
        }
        private void InstitucionClick(object sender, RoutedEventArgs e)
        {
            InstitucionMainMaestro ventana = new InstitucionMainMaestro();
            ventana.Show();
            this.Hide();
        }
        private void GenerarTXT_Click(object sender, RoutedEventArgs e)
        {
            var repo = new UserRepository(); // Asegúrate de tener usando ControlEscolar.Repositories
            var estudiantes = repo.ObtenerEstudiantes(); // Llamas desde el repositorio

            string rutaArchivo = "ListaEstudiantes.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(rutaArchivo))
                {
                    writer.WriteLine("LISTA DE ESTUDIANTES");
                    writer.WriteLine("=============================================");
                    writer.WriteLine("Matrícula\tCURP\t\tNombre\t\tEdad\tFecha Nacimiento");
                    writer.WriteLine("-------------------------------------------------------------");

                    foreach (var est in estudiantes)
                    {
                        writer.WriteLine($"{est.Matricula}\t{est.CURP}\t{est.Nombre}\t{est.Edad}\t{est.FechaNacimiento.ToShortDateString()}");
                    }

                }

                MessageBox.Show("Archivo TXT generado exitosamente.");

                // Abrir el archivo automáticamente
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

