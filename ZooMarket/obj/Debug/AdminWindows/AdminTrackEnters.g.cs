﻿#pragma checksum "..\..\..\AdminWindows\AdminTrackEnters.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9C0B9102FE4B7D8CB9371E6AF4F46CFF9A684512FC0BB445E6B13C71B791CF33"
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
    /// AdminTrackEnters
    /// </summary>
    public partial class AdminTrackEnters : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\AdminWindows\AdminTrackEnters.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogoutButton;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\AdminWindows\AdminTrackEnters.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FilterFullNameComboBox;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\AdminWindows\AdminTrackEnters.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FilterIPAddressTextBox;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\AdminWindows\AdminTrackEnters.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FilterStatusComboBox;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\AdminWindows\AdminTrackEnters.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ApplyFilterButton;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\AdminWindows\AdminTrackEnters.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid LoginHistoryDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/ZooMarket;component/adminwindows/admintrackenters.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AdminWindows\AdminTrackEnters.xaml"
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
            
            #line 33 "..\..\..\AdminWindows\AdminTrackEnters.xaml"
            this.LogoutButton.Click += new System.Windows.RoutedEventHandler(this.LogoutButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FilterFullNameComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 58 "..\..\..\AdminWindows\AdminTrackEnters.xaml"
            this.FilterFullNameComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FilterFullNameComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FilterIPAddressTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.FilterStatusComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.ApplyFilterButton = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\..\AdminWindows\AdminTrackEnters.xaml"
            this.ApplyFilterButton.Click += new System.Windows.RoutedEventHandler(this.ApplyFilterButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LoginHistoryDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
