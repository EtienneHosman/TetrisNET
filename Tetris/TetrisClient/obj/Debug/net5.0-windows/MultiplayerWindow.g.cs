﻿#pragma checksum "..\..\..\MultiplayerWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5570524C743267B5C84828B60A19D6C783D9274E"
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
using System.Windows.Controls.Ribbon;
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
using TetrisClient;


namespace TetrisClient {
    
    
    /// <summary>
    /// MultiplayerWindow
    /// </summary>
    public partial class MultiplayerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\MultiplayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Status;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\MultiplayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputField;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\MultiplayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TetrisGridP1;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\MultiplayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TetrisGridP2;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\MultiplayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid NextBlockGrid;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\MultiplayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Level;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\MultiplayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Lines;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\MultiplayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Score;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\MultiplayerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Time;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TetrisClient;component/multiplayerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MultiplayerWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\MultiplayerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StartGame_OnClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Status = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            
            #line 12 "..\..\..\MultiplayerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoBackButton);
            
            #line default
            #line hidden
            return;
            case 4:
            this.InputField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 14 "..\..\..\MultiplayerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ConnectButton);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TetrisGridP1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.TetrisGridP2 = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.NextBlockGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.Level = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.Lines = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.Score = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.Time = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

