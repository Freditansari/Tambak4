﻿#pragma checksum "C:\Users\fredy\Documents\GitHub\tambak2\Tambak4\tambak\Views\Inventory\ProductRegistrationChildWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "813E43E8C07D743D3C40ED582F7C8D02"
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


namespace tambak.Views.Inventory {
    
    
    public partial class ProductRegistrationChildWindow : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.DomainDataSource productDomainDataSource;
        
        internal System.Windows.Controls.Grid grid1;
        
        internal System.Windows.Controls.TextBox categoryTextBox;
        
        internal System.Windows.Controls.ComboBox categoryComboBox;
        
        internal System.Windows.Controls.TextBox productIDTextBox;
        
        internal System.Windows.Controls.TextBox productNameTextBox;
        
        internal System.Windows.Controls.TextBox product_DescriptionTextBox;
        
        internal System.Windows.Controls.TextBox purchasePriceTextBox;
        
        internal System.Windows.Controls.TextBox reorderLevelTextBox;
        
        internal System.Windows.Controls.TextBox sKUTextBox;
        
        internal System.Windows.Controls.TextBox salePriceTextBox;
        
        internal System.Windows.Controls.TextBox unitInOrderTextBox;
        
        internal System.Windows.Controls.TextBox unitInStockTextBox;
        
        internal System.Windows.Controls.ComboBox uOMNameComboBox;
        
        internal System.Windows.Controls.TextBox qtyperunitTextBox;
        
        internal System.Windows.Controls.DomainDataSource categoryDomainDataSource;
        
        internal System.Windows.Controls.Button newCategoryButton;
        
        internal System.Windows.Controls.DomainDataSource unitofMeasurementDomainDataSource;
        
        internal System.Windows.Controls.Button newUOMButton;
        
        internal System.Windows.Controls.CheckBox IsFinishedProductCheckBox;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/tambak;component/Views/Inventory/ProductRegistrationChildWindow.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.productDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("productDomainDataSource")));
            this.grid1 = ((System.Windows.Controls.Grid)(this.FindName("grid1")));
            this.categoryTextBox = ((System.Windows.Controls.TextBox)(this.FindName("categoryTextBox")));
            this.categoryComboBox = ((System.Windows.Controls.ComboBox)(this.FindName("categoryComboBox")));
            this.productIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("productIDTextBox")));
            this.productNameTextBox = ((System.Windows.Controls.TextBox)(this.FindName("productNameTextBox")));
            this.product_DescriptionTextBox = ((System.Windows.Controls.TextBox)(this.FindName("product_DescriptionTextBox")));
            this.purchasePriceTextBox = ((System.Windows.Controls.TextBox)(this.FindName("purchasePriceTextBox")));
            this.reorderLevelTextBox = ((System.Windows.Controls.TextBox)(this.FindName("reorderLevelTextBox")));
            this.sKUTextBox = ((System.Windows.Controls.TextBox)(this.FindName("sKUTextBox")));
            this.salePriceTextBox = ((System.Windows.Controls.TextBox)(this.FindName("salePriceTextBox")));
            this.unitInOrderTextBox = ((System.Windows.Controls.TextBox)(this.FindName("unitInOrderTextBox")));
            this.unitInStockTextBox = ((System.Windows.Controls.TextBox)(this.FindName("unitInStockTextBox")));
            this.uOMNameComboBox = ((System.Windows.Controls.ComboBox)(this.FindName("uOMNameComboBox")));
            this.qtyperunitTextBox = ((System.Windows.Controls.TextBox)(this.FindName("qtyperunitTextBox")));
            this.categoryDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("categoryDomainDataSource")));
            this.newCategoryButton = ((System.Windows.Controls.Button)(this.FindName("newCategoryButton")));
            this.unitofMeasurementDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("unitofMeasurementDomainDataSource")));
            this.newUOMButton = ((System.Windows.Controls.Button)(this.FindName("newUOMButton")));
            this.IsFinishedProductCheckBox = ((System.Windows.Controls.CheckBox)(this.FindName("IsFinishedProductCheckBox")));
        }
    }
}

