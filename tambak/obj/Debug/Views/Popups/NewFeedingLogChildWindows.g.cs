﻿#pragma checksum "C:\Users\fredy\Documents\GitHub\Tambak4\tambak\Views\Popups\NewFeedingLogChildWindows.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "26B485F8B393210BBDB7F793BFF56301"
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


namespace tambak.Views.Popups {
    
    
    public partial class NewFeedingLogChildWindows : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.DomainDataSource feedingLogDomainDataSource;
        
        internal System.Windows.Controls.DomainDataSource pondDomainDataSource;
        
        internal System.Windows.Controls.DataGrid pondDataGrid;
        
        internal System.Windows.Controls.DataGridTextColumn pondIDColumn;
        
        internal System.Windows.Controls.DataGridTextColumn pondDescriptionColumn;
        
        internal System.Windows.Controls.DomainDataSource pondsProductionCycleDomainDataSource;
        
        internal System.Windows.Controls.DataGrid pondsProductionCycleDataGrid;
        
        internal System.Windows.Controls.DataGridTextColumn productionCycleIDColumn;
        
        internal System.Windows.Controls.DataGridTextColumn technicianColumn;
        
        internal System.Windows.Controls.DataGridCheckBoxColumn isInProductionColumn;
        
        internal System.Windows.Controls.DataGrid feedingLogDataGrid;
        
        internal System.Windows.Controls.DataGridTextColumn feedGivenColumn;
        
        internal System.Windows.Controls.DataGridTextColumn feedTypeColumn;
        
        internal System.Windows.Controls.DataGridTextColumn waterLevelColumn;
        
        internal System.Windows.Controls.DomainDataSource productDomainDataSource;
        
        internal System.Windows.Controls.DataGrid productDataGrid;
        
        internal System.Windows.Controls.DataGridTextColumn productNameColumn;
        
        internal System.Windows.Controls.DataGridTextColumn product_DescriptionColumn;
        
        internal System.Windows.Controls.DataGridTextColumn sKUColumn;
        
        internal System.Windows.Controls.DataGridTextColumn uomColumn;
        
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        internal System.Windows.Controls.Button removeButton;
        
        internal System.Windows.Controls.Button addButton;
        
        internal System.Windows.Controls.Grid grid1;
        
        internal System.Windows.Controls.TextBox cummulativeFeedTextBox;
        
        internal System.Windows.Controls.TextBox feedLogIDTextBox;
        
        internal System.Windows.Controls.TextBox productIDTextBox;
        
        internal System.Windows.Controls.TextBox productionCycleIDTextBox;
        
        internal System.Windows.Controls.TextBox userIDTextBox;
        
        internal System.Windows.Controls.TextBox feedGivenTextBox;
        
        internal System.Windows.Controls.TextBox feedPerDayTextBox;
        
        internal System.Windows.Controls.TextBox feedTypeTextBox;
        
        internal System.Windows.Controls.TextBox waterLevelTextBox;
        
        internal System.Windows.Controls.Grid grid2;
        
        internal System.Windows.Controls.DatePicker logDateDatePicker;
        
        internal System.Windows.Controls.DomainDataSource categoryDomainDataSource;
        
        internal System.Windows.Controls.Grid grid3;
        
        internal System.Windows.Controls.ComboBox categoryNameComboBox;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/tambak;component/Views/Popups/NewFeedingLogChildWindows.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.feedingLogDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("feedingLogDomainDataSource")));
            this.pondDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("pondDomainDataSource")));
            this.pondDataGrid = ((System.Windows.Controls.DataGrid)(this.FindName("pondDataGrid")));
            this.pondIDColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("pondIDColumn")));
            this.pondDescriptionColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("pondDescriptionColumn")));
            this.pondsProductionCycleDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("pondsProductionCycleDomainDataSource")));
            this.pondsProductionCycleDataGrid = ((System.Windows.Controls.DataGrid)(this.FindName("pondsProductionCycleDataGrid")));
            this.productionCycleIDColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("productionCycleIDColumn")));
            this.technicianColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("technicianColumn")));
            this.isInProductionColumn = ((System.Windows.Controls.DataGridCheckBoxColumn)(this.FindName("isInProductionColumn")));
            this.feedingLogDataGrid = ((System.Windows.Controls.DataGrid)(this.FindName("feedingLogDataGrid")));
            this.feedGivenColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("feedGivenColumn")));
            this.feedTypeColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("feedTypeColumn")));
            this.waterLevelColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("waterLevelColumn")));
            this.productDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("productDomainDataSource")));
            this.productDataGrid = ((System.Windows.Controls.DataGrid)(this.FindName("productDataGrid")));
            this.productNameColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("productNameColumn")));
            this.product_DescriptionColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("product_DescriptionColumn")));
            this.sKUColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("sKUColumn")));
            this.uomColumn = ((System.Windows.Controls.DataGridTextColumn)(this.FindName("uomColumn")));
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(this.FindName("SearchTextBox")));
            this.removeButton = ((System.Windows.Controls.Button)(this.FindName("removeButton")));
            this.addButton = ((System.Windows.Controls.Button)(this.FindName("addButton")));
            this.grid1 = ((System.Windows.Controls.Grid)(this.FindName("grid1")));
            this.cummulativeFeedTextBox = ((System.Windows.Controls.TextBox)(this.FindName("cummulativeFeedTextBox")));
            this.feedLogIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("feedLogIDTextBox")));
            this.productIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("productIDTextBox")));
            this.productionCycleIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("productionCycleIDTextBox")));
            this.userIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("userIDTextBox")));
            this.feedGivenTextBox = ((System.Windows.Controls.TextBox)(this.FindName("feedGivenTextBox")));
            this.feedPerDayTextBox = ((System.Windows.Controls.TextBox)(this.FindName("feedPerDayTextBox")));
            this.feedTypeTextBox = ((System.Windows.Controls.TextBox)(this.FindName("feedTypeTextBox")));
            this.waterLevelTextBox = ((System.Windows.Controls.TextBox)(this.FindName("waterLevelTextBox")));
            this.grid2 = ((System.Windows.Controls.Grid)(this.FindName("grid2")));
            this.logDateDatePicker = ((System.Windows.Controls.DatePicker)(this.FindName("logDateDatePicker")));
            this.categoryDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("categoryDomainDataSource")));
            this.grid3 = ((System.Windows.Controls.Grid)(this.FindName("grid3")));
            this.categoryNameComboBox = ((System.Windows.Controls.ComboBox)(this.FindName("categoryNameComboBox")));
        }
    }
}

