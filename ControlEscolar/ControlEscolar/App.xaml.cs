    using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using ControlEscolar.View;
using ProyectoEscolarizado.View;

namespace ControlEscolar
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string UserRole { get; set; } = string.Empty;
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var userRoleSelection = new UserRoleSelection();
            userRoleSelection.Show();

            userRoleSelection.Closed += (s, ev) =>
            {
                if (!string.IsNullOrEmpty(App.UserRole) && Application.Current.Windows.OfType<LoginView>().Count() == 0)
                {
                    var loginView = new LoginView(App.UserRole);
                    loginView.Show();
                }
            };
        }
    }
}
