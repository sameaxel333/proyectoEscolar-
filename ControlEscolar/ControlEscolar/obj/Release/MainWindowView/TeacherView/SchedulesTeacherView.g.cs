﻿#pragma checksum "..\..\..\..\MainWindowView\TeacherView\SchedulesTeacherView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2D8626A0F03A561F3FC01DAD6B2FD2DB1A8F35CDA351B04B7FEDCC473689B5F6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ControlEscolar.MainWindowView.TeacherView;
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


namespace ControlEscolar.MainWindowView.TeacherView {
    
    
    /// <summary>
    /// SchedulesTeacherView
    /// </summary>
    public partial class SchedulesTeacherView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 65 "..\..\..\..\MainWindowView\TeacherView\SchedulesTeacherView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimizar;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\MainWindowView\TeacherView\SchedulesTeacherView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCerrar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ControlEscolar;component/mainwindowview/teacherview/schedulesteacherview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MainWindowView\TeacherView\SchedulesTeacherView.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnMinimizar = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.btnCerrar = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            
            #line 131 "..\..\..\..\MainWindowView\TeacherView\SchedulesTeacherView.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Inicio_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 139 "..\..\..\..\MainWindowView\TeacherView\SchedulesTeacherView.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Cursos_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 143 "..\..\..\..\MainWindowView\TeacherView\SchedulesTeacherView.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Asistencia_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 147 "..\..\..\..\MainWindowView\TeacherView\SchedulesTeacherView.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.CerrarSesion_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 166 "..\..\..\..\MainWindowView\TeacherView\SchedulesTeacherView.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.ContactClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 170 "..\..\..\..\MainWindowView\TeacherView\SchedulesTeacherView.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.UbicacionClick);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 174 "..\..\..\..\MainWindowView\TeacherView\SchedulesTeacherView.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.PlanEstudiosClick);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 178 "..\..\..\..\MainWindowView\TeacherView\SchedulesTeacherView.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.InstitucionClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

