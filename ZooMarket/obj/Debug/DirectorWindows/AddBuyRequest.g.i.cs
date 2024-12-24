﻿#pragma checksum "..\..\..\DirectorWindows\AddBuyRequest.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AFA2BB3D8124E35E7D0E675FABA4E0C5C1F55CA85F8F274E2EE0E0E9D9A6FCBD"
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
    /// AddBuyRequest
    /// </summary>
    public partial class AddBuyRequest : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\DirectorWindows\AddBuyRequest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SupplierComboBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\DirectorWindows\AddBuyRequest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ProductTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\DirectorWindows\AddBuyRequest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ProductComboBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\DirectorWindows\AddBuyRequest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox QuantityTextBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\DirectorWindows\AddBuyRequest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddProductButton;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\DirectorWindows\AddBuyRequest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid SelectedProductsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\DirectorWindows\AddBuyRequest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateRequestButton;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\DirectorWindows\AddBuyRequest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogoutButton;
        
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
            System.Uri resourceLocater = new System.Uri("/ZooMarket;component/directorwindows/addbuyrequest.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DirectorWindows\AddBuyRequest.xaml"
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
            this.SupplierComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.ProductTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 33 "..\..\..\DirectorWindows\AddBuyRequest.xaml"
            this.ProductTypeComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProductTypeComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ProductComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.QuantityTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.AddProductButton = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\DirectorWindows\AddBuyRequest.xaml"
            this.AddProductButton.Click += new System.Windows.RoutedEventHandler(this.AddProductButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SelectedProductsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.CreateRequestButton = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\..\DirectorWindows\AddBuyRequest.xaml"
            this.CreateRequestButton.Click += new System.Windows.RoutedEventHandler(this.CreateRequestButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.LogoutButton = ((System.Windows.Controls.Button)(target));
            
            #line 115 "..\..\..\DirectorWindows\AddBuyRequest.xaml"
            this.LogoutButton.Click += new System.Windows.RoutedEventHandler(this.LogoutButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

