﻿#pragma checksum "C:\Users\fredy\Documents\GitHub\tambak2\Tambak4\tambak\Views\Masters\FacilitiesPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FFCB106F09BDCA64C0DAB291C0C011B8"
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
    
    
    public partial class FacilitiesPage : System.Windows.Controls.Page {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.DomainDataSource facilityDomainDataSource;
        
        internal System.Windows.Controls.Button UpdateFacilitiesButton;
        
        internal System.Windows.Controls.Button NewFacilitiesButton;
        
        internal System.Windows.Controls.DataGrid facilityDataGrid;
        
        internal System.Windows.Controls.DataGridTextColumn addressColumn;
        
        internal System.Windows.Controls.DataGridTextColumn address2Column;
        
        internal System.Windows.Controls.DataGridTextColumn cityColumn;
        
        internal System.Windows.Controls.DataGridTextColumn companyIDColumn;
        
        internal System.Windows.Controls.DataGridTextColumn contactPersonColumn;
        
        internal System.Windows.Controls.DataGridTextColumn countryColumn;
        
        internal System.Windows.Controls.DataGridTextColumn emailColumn;
        
        internal System.Windows.Controls.DataGridTemplateColumn entryDateColumn;
        
        internal System.Windows.Controls.DataGridTextColumn facilityIdColumn;
        
        internal System.Windows.Controls.DataGridTextColumn facilityNameColumn;
        
        internal System.Windows.Controls.DataGridTextColumn phoneNumberColumn;
        
        internal System.Windows.Controls.DataGridTextColumn stateColumn;
        
        internal System.Windows.Controls.DataGridTextColumn userIDColumn;
        
        internal System.Windows.Controls.Grid grid1;
        
        internal System.Windows.Controls.TextBox addressTextBox;
        
        internal System.Windows.Controls.TextBox address2TextBox;
        
        internal System.Windows.Controls.TextBox cityTextBox;
        
        internal System.Windows.Controls.ComboBox companyNameComboBox;
        
        internal System.Windows.Controls.TextBox contactPersonTextBox;
        
        internal System.Windows.Controls.TextBox countryTextBox;
        
        internal System.Windows.Controls.TextBox emailTextBox;
        
        internal System.Windows.Controls.DatePicker entryDateDatePicker;
        
        internal System.Windows.Controls.TextBox facilityIdTextBox;
        
        internal System.Windows.Controls.TextBox facilityNameTextBox;
        
        internal System.Windows.Controls.TextBox phoneNumberTextBox;
        
        internal System.Windows.Controls.TextBox stateTextBox;
        
        internal System.Windows.Controls.TextBox userIDTextBox;
        
        internal System.Windows.Controls.TextBox zipCodeTextBox;
        
        internal System.Windows.Controls.DomainDataSource companyDomainDataSource;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/tambak;component/Views/Masters/FacilitiesPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.facilityDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("facilityDomainDataSource")));
            this.UpdateFacilitiesButton = ((System.Windows.Controls.Button)(this.FindName("UpdateFacilitiesButton")));
            this.NewFacilitiesButton = ((System.Windows.Controls.Button)(this.FindName("NewFacilitiesButton")));
            this.facilityDataGrid = ((System.Windows.Controls.DataGrid)(this.FindName("facilityDataGrid")));
            this.addressColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("addressColumn")));
            this.address2Column = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("address2Column")));
            this.cityColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("cityColumn")));
            this.companyIDColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("companyIDColumn")));
            this.contactPersonColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("contactPersonColumn")));
            this.countryColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("countryColumn")));
            this.emailColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("emailColumn")));
            this.entryDateColumn = ((System.Windows.Controls.DataGridTemplateColumn)(this.FindName("entryDateColumn")));
            this.facilityIdColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("facilityIdColumn")));
            this.facilityNameColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("facilityNameColumn")));
            this.phoneNumberColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("phoneNumberColumn")));
            this.stateColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("stateColumn")));
            this.userIDColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("userIDColumn")));
            this.grid1 = ((System.Windows.Controls.Grid)(this.FindName("grid1")));
            this.addressTextBox = ((System.Windows.Controls.TextBox)(this.FindName("addressTextBox")));
            this.address2TextBox = ((System.Windows.Controls.TextBox)(this.FindName("address2TextBox")));
            this.cityTextBox = ((System.Windows.Controls.TextBox)(this.FindName("cityTextBox")));
            this.companyNameComboBox = ((System.Windows.Controls.ComboBox)(this.FindName("companyNameComboBox")));
            this.contactPersonTextBox = ((System.Windows.Controls.TextBox)(this.FindName("contactPersonTextBox")));
            this.countryTextBox = ((System.Windows.Controls.TextBox)(this.FindName("countryTextBox")));
            this.emailTextBox = ((System.Windows.Controls.TextBox)(this.FindName("emailTextBox")));
            this.entryDateDatePicker = ((System.Windows.Controls.DatePicker)(this.FindName("entryDateDatePicker")));
            this.facilityIdTextBox = ((System.Windows.Controls.TextBox)(this.FindName("facilityIdTextBox")));
            this.facilityNameTextBox = ((System.Windows.Controls.TextBox)(this.FindName("facilityNameTextBox")));
            this.phoneNumberTextBox = ((System.Windows.Controls.TextBox)(this.FindName("phoneNumberTextBox")));
            this.stateTextBox = ((System.Windows.Controls.TextBox)(this.FindName("stateTextBox")));
            this.userIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("userIDTextBox")));
            this.zipCodeTextBox = ((System.Windows.Controls.TextBox)(this.FindName("zipCodeTextBox")));
            this.companyDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("companyDomainDataSource")));
        }
    }
}

