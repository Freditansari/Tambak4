﻿#pragma checksum "C:\Users\fredy\Documents\GitHub\tambak2\Tambak4\tambak\Views\Masters\TaxPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CDAF99FC78E7ACF7CB87E22A8BAF6FB6"
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


namespace tambak.Views.Masters {
    
    
    public partial class TaxPage : System.Windows.Controls.Page {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.DomainDataSource masterTaxDomainDataSource;
        
        internal System.Windows.Controls.Grid grid1;
        
        internal System.Windows.Controls.TextBox taxDescriptionTextBox;
        
        internal System.Windows.Controls.TextBox taxIDTextBox;
        
        internal System.Windows.Controls.TextBox taxRateTextBox;
        
        internal System.Windows.Controls.DataGrid masterTaxDataGrid;
        
        internal System.Windows.Controls.DataGridTextColumn taxDescriptionColumn;
        
        internal System.Windows.Controls.DataGridTextColumn taxIDColumn;
        
        internal System.Windows.Controls.DataGridTextColumn taxRateColumn;
        
        internal System.Windows.Controls.Button NewTaxButton;
        
        internal System.Windows.Controls.Button UpdateTaxButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/tambak;component/Views/Masters/TaxPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.masterTaxDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("masterTaxDomainDataSource")));
            this.grid1 = ((System.Windows.Controls.Grid)(this.FindName("grid1")));
            this.taxDescriptionTextBox = ((System.Windows.Controls.TextBox)(this.FindName("taxDescriptionTextBox")));
            this.taxIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("taxIDTextBox")));
            this.taxRateTextBox = ((System.Windows.Controls.TextBox)(this.FindName("taxRateTextBox")));
            this.masterTaxDataGrid = ((System.Windows.Controls.DataGrid)(this.FindName("masterTaxDataGrid")));
            this.taxDescriptionColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("taxDescriptionColumn")));
            this.taxIDColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("taxIDColumn")));
            this.taxRateColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("taxRateColumn")));
            this.NewTaxButton = ((System.Windows.Controls.Button)(this.FindName("NewTaxButton")));
            this.UpdateTaxButton = ((System.Windows.Controls.Button)(this.FindName("UpdateTaxButton")));
        }
    }
}

