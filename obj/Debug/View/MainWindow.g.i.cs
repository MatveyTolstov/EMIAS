﻿#pragma checksum "..\..\..\View\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6ECEB440AD04D73A311F7E7332C8024EE7AA509FD974459CED964D749B2382A6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using EMIAS;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using SharpVectors.Converters;
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


namespace EMIAS {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainFrame;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button gear;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame GearFrame;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame PagesFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/EMIAS;component/view/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\MainWindow.xaml"
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
            
            #line 10 "..\..\..\View\MainWindow.xaml"
            ((EMIAS.MainWindow)(target)).AddHandler(System.Windows.Input.Mouse.MouseDownEvent, new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown));
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 33 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.NavigateToPage);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 34 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.NavigateToPage);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 35 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.NavigateToPage);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 38 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.NavigateToPage);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 39 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.NavigateToPage);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 40 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.NavigateToPage);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 9:
            
            #line 49 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 50 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 51 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.gear = ((System.Windows.Controls.Button)(target));
            return;
            case 13:
            
            #line 66 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NavigateToPtofile_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.GearFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 15:
            this.PagesFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

