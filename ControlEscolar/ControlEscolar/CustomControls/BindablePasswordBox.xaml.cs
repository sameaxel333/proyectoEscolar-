using System;
using System.Security;
using System.Windows;
using System.Windows.Controls;

namespace ControlEscolar.CustomControls
{
    /// <summary>
    /// Lógica de interacción para BindablePasswordBox.xaml
    /// </summary>
    public partial class BindablePasswordBox : UserControl
    {
        public BindablePasswordBox()
        {
            InitializeComponent();
            txtPassword.PasswordChanged += OnPasswordChanged;
        }
        public static readonly DependencyProperty
            PasswordProperty = DependencyProperty.Register("Password",
                typeof(SecureString),
                typeof(BindablePasswordBox));

        public SecureString Password
        {
            get { return (SecureString)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        private void OnPasswordChanged(object sender, EventArgs e)
        {
            Password = txtPassword.SecurePassword;
        }
    }
}
