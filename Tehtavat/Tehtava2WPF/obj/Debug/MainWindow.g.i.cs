﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "390B3616AE349434804704B59F5EF3BF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Tehtava2WPF;


namespace Tehtava2WPF {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCountCountries;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCountPopulations;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTopPop;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTopArea;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblFilterName;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFilterName;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFilterName;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSelectContinent;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSelectContinent;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSelectContinent;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgCountries;
        
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
            System.Uri resourceLocater = new System.Uri("/Tehtava2WPF;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            this.btnCountCountries = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\MainWindow.xaml"
            this.btnCountCountries.Click += new System.Windows.RoutedEventHandler(this.CountCountries);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnCountPopulations = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\MainWindow.xaml"
            this.btnCountPopulations.Click += new System.Windows.RoutedEventHandler(this.CountPopulations);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnTopPop = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\MainWindow.xaml"
            this.btnTopPop.Click += new System.Windows.RoutedEventHandler(this.TopPopulation);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnTopArea = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\MainWindow.xaml"
            this.btnTopArea.Click += new System.Windows.RoutedEventHandler(this.TopArea);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lblFilterName = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.txtFilterName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnFilterName = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\MainWindow.xaml"
            this.btnFilterName.Click += new System.Windows.RoutedEventHandler(this.FilterName);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lblSelectContinent = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.cbSelectContinent = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.btnSelectContinent = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\MainWindow.xaml"
            this.btnSelectContinent.Click += new System.Windows.RoutedEventHandler(this.SelectContinent);
            
            #line default
            #line hidden
            return;
            case 11:
            this.dgCountries = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

