﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "98A99B74EC5C1E933C483C00143CA7E3A41DF99B76B74DBB26F946ACE7DB40D5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using OSRSComSim;
using OSRSComSim.ViewModels;
using OSRSComSim.Views;
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


namespace OSRSComSim {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Main;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Fighter1;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Fighter2;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Load_1;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Load_2;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Fight;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label FightLog;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl show_content;
        
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
            System.Uri resourceLocater = new System.Uri("/OSRSComSim;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.Main = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.Fighter1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.Fighter2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Button_Load_1 = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\MainWindow.xaml"
            this.Button_Load_1.Click += new System.Windows.RoutedEventHandler(this.Button_Load_1_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Button_Load_2 = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\MainWindow.xaml"
            this.Button_Load_2.Click += new System.Windows.RoutedEventHandler(this.Button_Load_2_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Button_Fight = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\MainWindow.xaml"
            this.Button_Fight.Click += new System.Windows.RoutedEventHandler(this.Button_Fight_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FightLog = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.show_content = ((System.Windows.Controls.ContentControl)(target));
            
            #line 40 "..\..\MainWindow.xaml"
            this.show_content.Loaded += new System.Windows.RoutedEventHandler(this.Load_Screen_loaded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
