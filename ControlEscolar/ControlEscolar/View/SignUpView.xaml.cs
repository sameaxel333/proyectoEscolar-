using ProyectoEscolarizado.View;
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
    /// Lógica de interacción para SignUpView.xaml
    /// </summary>
    public partial class SignUpView : Window
    {
        public SignUpView()
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

        private void BindablePasswordBox_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

        }
        
        private void txtUser3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void txtUser2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtUser1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
