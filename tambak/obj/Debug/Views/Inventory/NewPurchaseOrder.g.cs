﻿#pragma checksum "C:\Users\fredy\Documents\GitHub\tambak2\Tambak4\tambak\Views\Inventory\NewPurchaseOrder.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5BF962CA3FA2BEF36A523D7AD29B53B8"
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
using Telerik.ReportViewer.Silverlight;


namespace tambak.Views.Inventory {
    
    
    public partial class NewPurchaseOrder : System.Windows.Controls.Page {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.DomainDataSource purchaseOrderDomainDataSource;
        
        internal System.Windows.Controls.Grid grid1;
        
        internal System.Windows.Controls.DatePicker dueDateDatePicker;
        
        internal System.Windows.Controls.TextBox noteTextBox;
        
        internal System.Windows.Controls.TextBox otherFeeTextBox;
        
        internal System.Windows.Controls.TextBox discountTextBox;
        
        internal System.Windows.Controls.TextBox pOIDTextBox;
        
        internal System.Windows.Controls.DatePicker poDateDatePicker;
        
        internal System.Windows.Controls.TextBox shipToTextBox;
        
        internal System.Windows.Controls.Button selectFacilityButton;
        
        internal System.Windows.Controls.TextBox pOReferenceTextBox;
        
        internal System.Windows.Controls.TextBox shippingTextBox;
        
        internal System.Windows.Controls.TextBox statusTextBox;
        
        internal System.Windows.Controls.ComboBox currencyShortNameComboBox;
        
        internal System.Windows.Controls.TextBox subTotalTextBox;
        
        internal System.Windows.Controls.TextBox totalPriceTextBox;
        
        internal System.Windows.Controls.TextBox userNameTextBox;
        
        internal System.Windows.Controls.TextBox vendorIDTextBox;
        
        internal System.Windows.Controls.Button selectVendorButton;
        
        internal System.Windows.Controls.TextBox taxRateTextBox;
        
        internal System.Windows.Controls.Button selectTaxButton;
        
        internal System.Windows.Controls.DomainDataSource pODetailDomainDataSource;
        
        internal System.Windows.Controls.DomainDataSource productDomainDataSource;
        
        internal System.Windows.Controls.Grid grid2;
        
        internal System.Windows.Controls.Grid grid3;
        
        internal System.Windows.Controls.Grid grid4;
        
        internal System.Windows.Controls.DomainDataSource supplierDomainDataSource;
        
        internal Telerik.Windows.Controls.RadGridView productRadGridView;
        
        internal System.Windows.Controls.Grid grid5;
        
        internal System.Windows.Controls.TextBox descriptionTextBox;
        
        internal System.Windows.Controls.TextBox pODetailsIDTextBox;
        
        internal System.Windows.Controls.TextBox pOIDTextBox1;
        
        internal System.Windows.Controls.TextBox productIDTextBox;
        
        internal System.Windows.Controls.TextBox totalTextBox;
        
        internal System.Windows.Controls.TextBox unitPriceTextBox;
        
        internal System.Windows.Controls.TextBox qtyTextBox;
        
        internal System.Windows.Controls.DataGrid pODetailDataGrid;
        
        internal System.Windows.Controls.DataGridTextColumn productIDColumn;
        
        internal System.Windows.Controls.DataGridTextColumn descriptionColumn;
        
        internal System.Windows.Controls.DataGridTextColumn qtyColumn;
        
        internal System.Windows.Controls.DataGridTextColumn unitPriceColumn;
        
        internal System.Windows.Controls.DataGridTextColumn totalColumn;
        
        internal System.Windows.Controls.Button SavePurchaseOrderButton;
        
        internal System.Windows.Controls.Button addProductButton;
        
        internal System.Windows.Controls.Button RemoveProductButton;
        
        internal System.Windows.Controls.DomainDataSource masterCurrencyDomainDataSource;
        
        internal System.Windows.Controls.TabItem PrintPOTabItem;
        
        internal Telerik.ReportViewer.Silverlight.ReportViewer POReportViewer;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/tambak;component/Views/Inventory/NewPurchaseOrder.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.purchaseOrderDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("purchaseOrderDomainDataSource")));
            this.grid1 = ((System.Windows.Controls.Grid)(this.FindName("grid1")));
            this.dueDateDatePicker = ((System.Windows.Controls.DatePicker)(this.FindName("dueDateDatePicker")));
            this.noteTextBox = ((System.Windows.Controls.TextBox)(this.FindName("noteTextBox")));
            this.otherFeeTextBox = ((System.Windows.Controls.TextBox)(this.FindName("otherFeeTextBox")));
            this.discountTextBox = ((System.Windows.Controls.TextBox)(this.FindName("discountTextBox")));
            this.pOIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("pOIDTextBox")));
            this.poDateDatePicker = ((System.Windows.Controls.DatePicker)(this.FindName("poDateDatePicker")));
            this.shipToTextBox = ((System.Windows.Controls.TextBox)(this.FindName("shipToTextBox")));
            this.selectFacilityButton = ((System.Windows.Controls.Button)(this.FindName("selectFacilityButton")));
            this.pOReferenceTextBox = ((System.Windows.Controls.TextBox)(this.FindName("pOReferenceTextBox")));
            this.shippingTextBox = ((System.Windows.Controls.TextBox)(this.FindName("shippingTextBox")));
            this.statusTextBox = ((System.Windows.Controls.TextBox)(this.FindName("statusTextBox")));
            this.currencyShortNameComboBox = ((System.Windows.Controls.ComboBox)(this.FindName("currencyShortNameComboBox")));
            this.subTotalTextBox = ((System.Windows.Controls.TextBox)(this.FindName("subTotalTextBox")));
            this.totalPriceTextBox = ((System.Windows.Controls.TextBox)(this.FindName("totalPriceTextBox")));
            this.userNameTextBox = ((System.Windows.Controls.TextBox)(this.FindName("userNameTextBox")));
            this.vendorIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("vendorIDTextBox")));
            this.selectVendorButton = ((System.Windows.Controls.Button)(this.FindName("selectVendorButton")));
            this.taxRateTextBox = ((System.Windows.Controls.TextBox)(this.FindName("taxRateTextBox")));
            this.selectTaxButton = ((System.Windows.Controls.Button)(this.FindName("selectTaxButton")));
            this.pODetailDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("pODetailDomainDataSource")));
            this.productDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("productDomainDataSource")));
            this.grid2 = ((System.Windows.Controls.Grid)(this.FindName("grid2")));
            this.grid3 = ((System.Windows.Controls.Grid)(this.FindName("grid3")));
            this.grid4 = ((System.Windows.Controls.Grid)(this.FindName("grid4")));
            this.supplierDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("supplierDomainDataSource")));
            this.productRadGridView = ((Telerik.Windows.Controls.RadGridView)(this.FindName("productRadGridView")));
            this.grid5 = ((System.Windows.Controls.Grid)(this.FindName("grid5")));
            this.descriptionTextBox = ((System.Windows.Controls.TextBox)(this.FindName("descriptionTextBox")));
            this.pODetailsIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("pODetailsIDTextBox")));
            this.pOIDTextBox1 = ((System.Windows.Controls.TextBox)(this.FindName("pOIDTextBox1")));
            this.productIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("productIDTextBox")));
            this.totalTextBox = ((System.Windows.Controls.TextBox)(this.FindName("totalTextBox")));
            this.unitPriceTextBox = ((System.Windows.Controls.TextBox)(this.FindName("unitPriceTextBox")));
            this.qtyTextBox = ((System.Windows.Controls.TextBox)(this.FindName("qtyTextBox")));
            this.pODetailDataGrid = ((System.Windows.Controls.DataGrid)(this.FindName("pODetailDataGrid")));
            this.productIDColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("productIDColumn")));
            this.descriptionColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("descriptionColumn")));
            this.qtyColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("qtyColumn")));
            this.unitPriceColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("unitPriceColumn")));
            this.totalColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("totalColumn")));
            this.SavePurchaseOrderButton = ((System.Windows.Controls.Button)(this.FindName("SavePurchaseOrderButton")));
            this.addProductButton = ((System.Windows.Controls.Button)(this.FindName("addProductButton")));
            this.RemoveProductButton = ((System.Windows.Controls.Button)(this.FindName("RemoveProductButton")));
            this.masterCurrencyDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("masterCurrencyDomainDataSource")));
            this.PrintPOTabItem = ((System.Windows.Controls.TabItem)(this.FindName("PrintPOTabItem")));
            this.POReportViewer = ((Telerik.ReportViewer.Silverlight.ReportViewer)(this.FindName("POReportViewer")));
        }
    }
}

