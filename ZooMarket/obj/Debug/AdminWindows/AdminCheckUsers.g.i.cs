﻿#pragma checksum "..\..\..\AdminWindows\AdminCheckUsers.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CE6C94CBC247A67244CA0D7AAAD28196460CE20C2C6BC278D1BA012F1BDC74D9"
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
using ZooMarket;


namespace ZooMarket {
    
    
    /// <summary>
    /// AdminCheckUsers
    /// </summary>
    public partial class AdminCheckUsers : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\AdminWindows\AdminCheckUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogoutButton;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\AdminWindows\AdminCheckUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FilterFullNameComboBox;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\AdminWindows\AdminCheckUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FilterPositionComboBox;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\AdminWindows\AdminCheckUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FilterSalaryTextBox;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\AdminWindows\AdminCheckUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ApplyFilterButton;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\AdminWindows\AdminCheckUsers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid EmployeesDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/ZooMarket;component/adminwindows/admincheckusers.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AdminWindows\AdminCheckUsers.xaml"
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
            
            #line 33 "..\..\..\AdminWindows\AdminCheckUsers.xaml"
            this.LogoutButton.Click += new System.Windows.RoutedEventHandler(this.LogoutButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FilterFullNameComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 58 "..\..\..\AdminWindows\AdminCheckUsers.xaml"
            this.FilterFullNameComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FilterFullNameComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FilterPositionComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.FilterSalaryTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ApplyFilterButton = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\..\AdminWindows\AdminCheckUsers.xaml"
            this.ApplyFilterButton.Click += new System.Windows.RoutedEventHandler(this.ApplyFilterButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.EmployeesDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

