﻿#pragma checksum "C:\Users\fredy\Documents\GitHub\Tambak4\tambak\Views\NewPondForm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "522D106C0E7E80E6E800486C74E33231"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace tambak.Views {
    
    
    public partial class NewPondForm : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.DomainDataSource pondDomainDataSource;
        
        internal System.Windows.Controls.Grid grid1;
        
        internal System.Windows.Controls.TextBox pondDescriptionTextBox;
        
        internal System.Windows.Controls.TextBox pondIDTextBox;
        
        internal System.Windows.Controls.TextBox pondLocationTextBox;
        
        internal System.Windows.Controls.TextBox pondSizeTextBox;
        
        internal System.Windows.Controls.TextBox pondUOMTextBox;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/tambak;component/Views/NewPondForm.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.pondDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("pondDomainDataSource")));
            this.grid1 = ((System.Windows.Controls.Grid)(this.FindName("grid1")));
            this.pondDescriptionTextBox = ((System.Windows.Controls.TextBox)(this.FindName("pondDescriptionTextBox")));
            this.pondIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("pondIDTextBox")));
            this.pondLocationTextBox = ((System.Windows.Controls.TextBox)(this.FindName("pondLocationTextBox")));
            this.pondSizeTextBox = ((System.Windows.Controls.TextBox)(this.FindName("pondSizeTextBox")));
            this.pondUOMTextBox = ((System.Windows.Controls.TextBox)(this.FindName("pondUOMTextBox")));
        }
    }
}

