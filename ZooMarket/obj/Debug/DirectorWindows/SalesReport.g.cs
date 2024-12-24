﻿#pragma checksum "..\..\..\DirectorWindows\SalesReport.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9599D8690256813A8DD0AE587D702A554C2090913ACCCAF14FA0CA242CC6AD7B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using ZooMarket.DirectorWindows;


namespace ZooMarket.DirectorWindows {
    
    
    /// <summary>
    /// SalesReport
    /// </summary>
    public partial class SalesReport : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\DirectorWindows\SalesReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogoutButton;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\DirectorWindows\SalesReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FilterEmployeeComboBox;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\DirectorWindows\SalesReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FilterDateComboBox;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\DirectorWindows\SalesReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ApplyFilterButton;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\DirectorWindows\SalesReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid SalesDataGrid;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\DirectorWindows\SalesReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TotalSalesTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/ZooMarket;component/directorwindows/salesreport.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DirectorWindows\SalesReport.xaml"
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
            this.LogoutButton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\DirectorWindows\SalesReport.xaml"
            this.LogoutButton.Click += new System.Windows.RoutedEventHandler(this.LogoutButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FilterEmployeeComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 57 "..\..\..\DirectorWindows\SalesReport.xaml"
            this.FilterEmployeeComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FilterEmployeeComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FilterDateComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 70 "..\..\..\DirectorWindows\SalesReport.xaml"
            this.FilterDateComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FilterDateComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ApplyFilterButton = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\DirectorWindows\SalesReport.xaml"
            this.ApplyFilterButton.Click += new System.Windows.RoutedEventHandler(this.ApplyFilterButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SalesDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.TotalSalesTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
