﻿#pragma checksum "..\..\..\View\Appointment_Doc_White.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "789921CFD7D923A2ADAA2EFDDB6B1131C864CA617B3578F3B3DA950723E7BE6C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using EMIAS.ViewModel;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace EMIAS.View {
    
    
    /// <summary>
    /// Appointment_Doc_White
    /// </summary>
    public partial class Appointment_Doc_White : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 48 "..\..\..\View\Appointment_Doc_White.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel MainMenuStackPanel;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\View\Appointment_Doc_White.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel MedCardStackPanel;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\View\Appointment_Doc_White.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel OnGearStackPanel;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\View\Appointment_Doc_White.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel IrinaMenuStackPanel;
        
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
            System.Uri resourceLocater = new System.Uri("/EMIAS;component/view/appointment_doc_white.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Appointment_Doc_White.xaml"
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
            this.MainMenuStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.MedCardStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            
            #line 85 "..\..\..\View\Appointment_Doc_White.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnIrinaButtonClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 86 "..\..\..\View\Appointment_Doc_White.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnGearButtonClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.OnGearStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            
            #line 91 "..\..\..\View\Appointment_Doc_White.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnDarkThemeClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.IrinaMenuStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            
            #line 94 "..\..\..\View\Appointment_Doc_White.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnExitClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

