using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ProyectoEscolarizado.View;

namespace ProyectoEscolarizado
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var loginView = new LoginView();
            loginView.Show();
            loginView.IsVisibleChanged += (s, ev) =>
            {
                if (loginView.IsVisible == false && loginView.IsLoaded)
                {
                    var mainView = new MainWindow();
                    mainView.Show();
                    loginView.Close();
                }
            };
        
        }

        private void Application_Startup_Inscripcion(object sender, StartupEventArgs e)
        {
            var inscripciones = new Inscripciones();
            inscripciones.Show();
            inscripciones.IsVisibleChanged += (s, ev) =>
            {
                if (inscripciones.IsVisible == false && inscripciones.IsLoaded)
                {
                    var mainView = new MainWindow();
                    mainView.Show();
                    inscripciones.Close();
                }
            };

        }
    }
}
