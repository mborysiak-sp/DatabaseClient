﻿#pragma checksum "..\..\..\..\..\Views\Add\BoringBar\AddBoringBarView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3B3FBD1EC98EE9AC92F708E6027851D6C8BA35F789D16BA309A0E173846528D8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using DatabaseClient.Views;
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


namespace DatabaseClient.Views {
    
    
    /// <summary>
    /// AddBoringBarView
    /// </summary>
    public partial class AddBoringBarView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\..\Views\Add\BoringBar\AddBoringBarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dodajWytaczadloTyp;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\Views\Add\BoringBar\AddBoringBarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dodajWytaczadloNumerRysunku;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\..\Views\Add\BoringBar\AddBoringBarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dodajWytaczadloLozysko;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\..\Views\Add\BoringBar\AddBoringBarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dodajWytaczadloButton;
        
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
            System.Uri resourceLocater = new System.Uri("/DatabaseClient;component/views/add/boringbar/addboringbarview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Add\BoringBar\AddBoringBarView.xaml"
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
            this.dodajWytaczadloTyp = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.dodajWytaczadloNumerRysunku = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.dodajWytaczadloLozysko = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.dodajWytaczadloButton = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\..\..\Views\Add\BoringBar\AddBoringBarView.xaml"
            this.dodajWytaczadloButton.Click += new System.Windows.RoutedEventHandler(this.DodajWytaczadlo);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

