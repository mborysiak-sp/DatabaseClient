﻿#pragma checksum "..\..\..\..\Views\AddDocument\AddDocumentView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "464577E1BAFC485C126F3242F248E80C9F6FE8A0F33B1C0822ADDAC0B8003BDB"
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
    /// AddDocumentView
    /// </summary>
    public partial class AddDocumentView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\Views\AddDocument\AddDocumentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textboxAddDocumentType;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Views\AddDocument\AddDocumentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textboxAddDocumentNumber;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\Views\AddDocument\AddDocumentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textboxAddDocumentDue;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\Views\AddDocument\AddDocumentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAddDocument;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\Views\AddDocument\AddDocumentView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboboxDetail;
        
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
            System.Uri resourceLocater = new System.Uri("/DatabaseClient;component/views/adddocument/adddocumentview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\AddDocument\AddDocumentView.xaml"
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
            this.textboxAddDocumentType = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.textboxAddDocumentNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.textboxAddDocumentDue = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.buttonAddDocument = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\..\Views\AddDocument\AddDocumentView.xaml"
            this.buttonAddDocument.Click += new System.Windows.RoutedEventHandler(this.AddDocument);
            
            #line default
            #line hidden
            return;
            case 5:
            this.comboboxDetail = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

