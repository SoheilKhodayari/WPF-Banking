﻿#pragma checksum "..\..\InternalMoneyTransferWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5DAE116EAD762162E0B95D3B3D12BFA1"
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
using System.Windows.Forms.Integration;
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


namespace WpfApplication1 {
    
    
    /// <summary>
    /// InternalMoneyTransferWindow
    /// </summary>
    public partial class InternalMoneyTransferWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\InternalMoneyTransferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PrimaryBalanceTxt_Copy1;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\InternalMoneyTransferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DestinationAccount;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\InternalMoneyTransferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PrimaryBalanceTxt_Copy8;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\InternalMoneyTransferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SourceAccount;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\InternalMoneyTransferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PrimaryBalanceTxt_Copy;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\InternalMoneyTransferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PrimaryBalanceTxt_Copy2;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\InternalMoneyTransferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AmountMoney;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\InternalMoneyTransferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RequesterName;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\InternalMoneyTransferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TopHeadingAccountForm;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication1;component/internalmoneytransferwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InternalMoneyTransferWindow.xaml"
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
            this.PrimaryBalanceTxt_Copy1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.DestinationAccount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.PrimaryBalanceTxt_Copy8 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.SourceAccount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.PrimaryBalanceTxt_Copy = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.PrimaryBalanceTxt_Copy2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.AmountMoney = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.RequesterName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 52 "..\..\InternalMoneyTransferWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_submit_clicked);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 53 "..\..\InternalMoneyTransferWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_reset_clicked);
            
            #line default
            #line hidden
            return;
            case 11:
            this.TopHeadingAccountForm = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

