// Updated by XamlIntelliSenseFileGenerator 18/05/2025 02:54:33 p. m.
#pragma checksum "..\..\..\..\MainWindowView\AdminView\CourseCreationView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "33C0B74893229FFF7A40645E897D9FFD9138501FC90A1CDBC373D0EEAD9623E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ControlEscolar.CustomControls;
using ControlEscolar.MoreWindows;
using ControlEscolar.ViewModel;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ControlEscolar.MainWinndowView.AdminView
{


    /// <summary>
    /// CreacMaterias
    /// </summary>
    public partial class CourseCreationView : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 77 "..\..\..\..\MainWindowView\AdminView\CourseCreationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimizar;

#line default
#line hidden


#line 118 "..\..\..\..\MainWindowView\AdminView\CourseCreationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboHorario;

#line default
#line hidden


#line 135 "..\..\..\..\MainWindowView\AdminView\CourseCreationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCerrar;

#line default
#line hidden


#line 202 "..\..\..\..\MainWindowView\AdminView\CourseCreationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogin;

#line default
#line hidden


#line 275 "..\..\..\..\MainWindowView\AdminView\CourseCreationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUser1;

#line default
#line hidden


#line 311 "..\..\..\..\MainWindowView\AdminView\CourseCreationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUser4;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ControlEscolar;component/mainwindowview/adminview/coursecreationview.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\MainWindowView\AdminView\CourseCreationView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.btnMinimizar = ((System.Windows.Controls.Button)(target));

#line 85 "..\..\..\..\MainWindowView\AdminView\CourseCreationView.xaml"
                    this.btnMinimizar.Click += new System.Windows.RoutedEventHandler(this.btnMinimizar_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.comboHorario = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 3:
                    this.btnCerrar = ((System.Windows.Controls.Button)(target));

#line 143 "..\..\..\..\MainWindowView\AdminView\CourseCreationView.xaml"
                    this.btnCerrar.Click += new System.Windows.RoutedEventHandler(this.btnCerrar_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.btnLogin = ((System.Windows.Controls.Button)(target));

#line 210 "..\..\..\..\MainWindowView\AdminView\CourseCreationView.xaml"
                    this.btnLogin.Click += new System.Windows.RoutedEventHandler(this.btnLogin_Click);

#line default
#line hidden
                    return;
                case 5:

#line 252 "..\..\..\..\MainWindowView\AdminView\CourseCreationView.xaml"
                    ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Inicio_Click);

#line default
#line hidden
                    return;
                case 6:

#line 254 "..\..\..\..\MainWindowView\AdminView\CourseCreationView.xaml"
                    ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Pagos_Click);

#line default
#line hidden
                    return;
                case 7:
                    this.txtUser1 = ((System.Windows.Controls.TextBox)(target));

#line 288 "..\..\..\..\MainWindowView\AdminView\CourseCreationView.xaml"
                    this.txtUser1.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtUser1_TextChanged);

#line default
#line hidden
                    return;
                case 8:
                    this.txtUser4 = ((System.Windows.Controls.TextBox)(target));

#line 324 "..\..\..\..\MainWindowView\AdminView\CourseCreationView.xaml"
                    this.txtUser4.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtUser1_TextChanged);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

