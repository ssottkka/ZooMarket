﻿#pragma checksum "..\..\..\DirectorWindows\AddEmploye.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "354764488D9A6926351DFC68FE319ED62ADCFEE731D4B610756645F075394A66"
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
    /// AddEmploye
    /// </summary>
    public partial class AddEmploye : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\DirectorWindows\AddEmploye.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogoutButton;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\DirectorWindows\AddEmploye.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FullNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\DirectorWindows\AddEmploye.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PositionComboBox;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\DirectorWindows\AddEmploye.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SalaryTextBox;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\DirectorWindows\AddEmploye.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker HireDatePicker;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\DirectorWindows\AddEmploye.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginTextBox;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\DirectorWindows\AddEmploye.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\DirectorWindows\AddEmploye.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddEmployeeButton;
        
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
            System.Uri resourceLocater = new System.Uri("/ZooMarket;component/directorwindows/addemploye.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DirectorWindows\AddEmploye.xaml"
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
            
            #line 39 "..\..\..\DirectorWindows\AddEmploye.xaml"
            this.LogoutButton.Click += new System.Windows.RoutedEventHandler(this.LogoutButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FullNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.PositionComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.SalaryTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.HireDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.LoginTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.PasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 8:
            this.AddEmployeeButton = ((System.Windows.Controls.Button)(target));
            
            #line 134 "..\..\..\DirectorWindows\AddEmploye.xaml"
            this.AddEmployeeButton.Click += new System.Windows.RoutedEventHandler(this.AddEmployeeButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

