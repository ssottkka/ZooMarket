﻿#pragma checksum "..\..\..\DirectorWindows\EditEmployes.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CB64FD23060F74D61C1671C5E5EAA1F3F2C91BC63BB38A664B69473812EC9C87"
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
    /// EditEmployes
    /// </summary>
    public partial class EditEmployes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\DirectorWindows\EditEmployes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox EmployeeComboBox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\DirectorWindows\EditEmployes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FullNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\DirectorWindows\EditEmployes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PositionComboBox;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\DirectorWindows\EditEmployes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SalaryTextBox;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\DirectorWindows\EditEmployes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker HireDatePicker;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\DirectorWindows\EditEmployes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginTextBox;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\DirectorWindows\EditEmployes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\DirectorWindows\EditEmployes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditEmployeeButton;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\DirectorWindows\EditEmployes.xaml"
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
            System.Uri resourceLocater = new System.Uri("/ZooMarket;component/directorwindows/editemployes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DirectorWindows\EditEmployes.xaml"
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
            this.EmployeeComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 40 "..\..\..\DirectorWindows\EditEmployes.xaml"
            this.EmployeeComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.EmployeeComboBox_SelectionChanged);
            
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
            this.EditEmployeeButton = ((System.Windows.Controls.Button)(target));
            
            #line 131 "..\..\..\DirectorWindows\EditEmployes.xaml"
            this.EditEmployeeButton.Click += new System.Windows.RoutedEventHandler(this.EditEmployeeButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.LogoutButton = ((System.Windows.Controls.Button)(target));
            
            #line 149 "..\..\..\DirectorWindows\EditEmployes.xaml"
            this.LogoutButton.Click += new System.Windows.RoutedEventHandler(this.LogoutButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

