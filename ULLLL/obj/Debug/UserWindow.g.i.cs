﻿#pragma checksum "..\..\UserWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5C0AB03422F82398C19DD86C183280BADB158E61295C1A4AE8F1A66A6B52BEB5"
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
using ULLLL;


namespace ULLLL {
    
    
    /// <summary>
    /// UserWindow
    /// </summary>
    public partial class UserWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\UserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ProductsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\UserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SelectedProductInfoTextBlock;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\UserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid OrderItemsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\UserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ClientOrdersDataGrid;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\UserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid OrderDetailsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\UserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas OrdersCanvas;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\UserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ClientIdTextBlock;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\UserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ClientUsernameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\UserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ClientEmailTextBlock;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\UserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ClientFirstNameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\UserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ClientLastNameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\UserWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ClientPhoneTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/ULLLL;component/userwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserWindow.xaml"
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
            this.ProductsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 31 "..\..\UserWindow.xaml"
            this.ProductsDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProductsDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SelectedProductInfoTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            
            #line 42 "..\..\UserWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddToOrderButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.OrderItemsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            
            #line 69 "..\..\UserWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClearCartButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 70 "..\..\UserWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveSelectedItemButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 71 "..\..\UserWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PlaceOrderButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ClientOrdersDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 90 "..\..\UserWindow.xaml"
            this.ClientOrdersDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ClientOrdersDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.OrderDetailsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.OrdersCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 11:
            this.ClientIdTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.ClientUsernameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.ClientEmailTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 14:
            this.ClientFirstNameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 15:
            this.ClientLastNameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 16:
            this.ClientPhoneTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 17:
            
            #line 133 "..\..\UserWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

