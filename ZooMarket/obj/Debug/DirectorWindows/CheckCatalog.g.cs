﻿#pragma checksum "..\..\..\DirectorWindows\CheckCatalog.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A89AD2570CB157622D8C3F3715E1D0A4D9346A2AD2D820129D20EC1A325161F6"
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
    /// CheckCatalog
    /// </summary>
    public partial class CheckCatalog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\DirectorWindows\CheckCatalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogoutButton;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\DirectorWindows\CheckCatalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FilterNameComboBox;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\DirectorWindows\CheckCatalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FilterCategoryComboBox;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\DirectorWindows\CheckCatalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FilterProductTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\DirectorWindows\CheckCatalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ApplyFilterButton;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\DirectorWindows\CheckCatalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ProductsDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/ZooMarket;component/directorwindows/checkcatalog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DirectorWindows\CheckCatalog.xaml"
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
            
            #line 33 "..\..\..\DirectorWindows\CheckCatalog.xaml"
            this.LogoutButton.Click += new System.Windows.RoutedEventHandler(this.LogoutButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FilterNameComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 58 "..\..\..\DirectorWindows\CheckCatalog.xaml"
            this.FilterNameComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FilterNameComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FilterCategoryComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.FilterProductTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.ApplyFilterButton = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\..\DirectorWindows\CheckCatalog.xaml"
            this.ApplyFilterButton.Click += new System.Windows.RoutedEventHandler(this.ApplyFilterButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ProductsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 111 "..\..\..\DirectorWindows\CheckCatalog.xaml"
            this.ProductsDataGrid.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.ProductsDataGrid_LoadingRow);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
