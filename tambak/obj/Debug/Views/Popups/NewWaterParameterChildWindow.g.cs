﻿#pragma checksum "C:\Users\fredy\Documents\GitHub\Tambak4\tambak\Views\Popups\NewWaterParameterChildWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A23891537C74EEC574D6FD286DA73AB1"
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
    
    
    public partial class NewWaterParameterChildWindow : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.DomainDataSource waterParameterLogDomainDataSource;
        
        internal System.Windows.Controls.Grid grid1;
        
        internal System.Windows.Controls.TextBox amonniaTextBox;
        
        internal System.Windows.Controls.TextBox bacteriaTextBox;
        
        internal System.Windows.Controls.TextBox dissolvedOxygenTextBox;
        
        internal System.Windows.Controls.CheckBox iMNVCheckBox;
        
        internal Telerik.Windows.Controls.RadDateTimePicker logDateDatePicker;
        
        internal System.Windows.Controls.TextBox paddlewheelTextBox;
        
        internal System.Windows.Controls.TextBox phospateTextBox;
        
        internal System.Windows.Controls.TextBox planktonsTextBox;
        
        internal System.Windows.Controls.TextBox potentialRedoxTextBox;
        
        internal System.Windows.Controls.TextBox salinityTextBox;
        
        internal System.Windows.Controls.TextBox temperatureTextBox;
        
        internal System.Windows.Controls.TextBox vibrioTextBox;
        
        internal System.Windows.Controls.CheckBox whiteSpotCheckBox;
        
        internal System.Windows.Controls.TextBox ammoniumTextBox;
        
        internal System.Windows.Controls.CheckBox isVibrioExistCheckBox;
        
        internal System.Windows.Controls.TextBox nitrateTextBox;
        
        internal System.Windows.Controls.TextBox nitriteTextBox;
        
        internal System.Windows.Controls.TextBox pHTextBox;
        
        internal System.Windows.Controls.ComboBox pondDescriptionComboBox;
        
        internal System.Windows.Controls.ComboBox productionCycleIDComboBox;
        
        internal System.Windows.Controls.TextBox totalOrganicMaterialTextBox;
        
        internal System.Windows.Controls.TextBox waterColorTextBox;
        
        internal System.Windows.Controls.TextBox alkalinityTextBox;
        
        internal System.Windows.Controls.TextBox noteTextBox;
        
        internal System.Windows.Controls.TextBox clarityTextBox;
        
        internal System.Windows.Controls.DomainDataSource pondsProductionCycleDomainDataSource;
        
        internal System.Windows.Controls.Grid grid2;
        
        internal System.Windows.Controls.DomainDataSource pondDomainDataSource;
        
        internal System.Windows.Controls.Grid grid3;
        
        internal System.Windows.Controls.Button AddWaterParameterButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/tambak;component/Views/Popups/NewWaterParameterChildWindow.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.waterParameterLogDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("waterParameterLogDomainDataSource")));
            this.grid1 = ((System.Windows.Controls.Grid)(this.FindName("grid1")));
            this.amonniaTextBox = ((System.Windows.Controls.TextBox)(this.FindName("amonniaTextBox")));
            this.bacteriaTextBox = ((System.Windows.Controls.TextBox)(this.FindName("bacteriaTextBox")));
            this.dissolvedOxygenTextBox = ((System.Windows.Controls.TextBox)(this.FindName("dissolvedOxygenTextBox")));
            this.iMNVCheckBox = ((System.Windows.Controls.CheckBox)(this.FindName("iMNVCheckBox")));
            this.logDateDatePicker = ((Telerik.Windows.Controls.RadDateTimePicker)(this.FindName("logDateDatePicker")));
            this.paddlewheelTextBox = ((System.Windows.Controls.TextBox)(this.FindName("paddlewheelTextBox")));
            this.phospateTextBox = ((System.Windows.Controls.TextBox)(this.FindName("phospateTextBox")));
            this.planktonsTextBox = ((System.Windows.Controls.TextBox)(this.FindName("planktonsTextBox")));
            this.potentialRedoxTextBox = ((System.Windows.Controls.TextBox)(this.FindName("potentialRedoxTextBox")));
            this.salinityTextBox = ((System.Windows.Controls.TextBox)(this.FindName("salinityTextBox")));
            this.temperatureTextBox = ((System.Windows.Controls.TextBox)(this.FindName("temperatureTextBox")));
            this.vibrioTextBox = ((System.Windows.Controls.TextBox)(this.FindName("vibrioTextBox")));
            this.whiteSpotCheckBox = ((System.Windows.Controls.CheckBox)(this.FindName("whiteSpotCheckBox")));
            this.ammoniumTextBox = ((System.Windows.Controls.TextBox)(this.FindName("ammoniumTextBox")));
            this.isVibrioExistCheckBox = ((System.Windows.Controls.CheckBox)(this.FindName("isVibrioExistCheckBox")));
            this.nitrateTextBox = ((System.Windows.Controls.TextBox)(this.FindName("nitrateTextBox")));
            this.nitriteTextBox = ((System.Windows.Controls.TextBox)(this.FindName("nitriteTextBox")));
            this.pHTextBox = ((System.Windows.Controls.TextBox)(this.FindName("pHTextBox")));
            this.pondDescriptionComboBox = ((System.Windows.Controls.ComboBox)(this.FindName("pondDescriptionComboBox")));
            this.productionCycleIDComboBox = ((System.Windows.Controls.ComboBox)(this.FindName("productionCycleIDComboBox")));
            this.totalOrganicMaterialTextBox = ((System.Windows.Controls.TextBox)(this.FindName("totalOrganicMaterialTextBox")));
            this.waterColorTextBox = ((System.Windows.Controls.TextBox)(this.FindName("waterColorTextBox")));
            this.alkalinityTextBox = ((System.Windows.Controls.TextBox)(this.FindName("alkalinityTextBox")));
            this.noteTextBox = ((System.Windows.Controls.TextBox)(this.FindName("noteTextBox")));
            this.clarityTextBox = ((System.Windows.Controls.TextBox)(this.FindName("clarityTextBox")));
            this.pondsProductionCycleDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("pondsProductionCycleDomainDataSource")));
            this.grid2 = ((System.Windows.Controls.Grid)(this.FindName("grid2")));
            this.pondDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("pondDomainDataSource")));
            this.grid3 = ((System.Windows.Controls.Grid)(this.FindName("grid3")));
            this.AddWaterParameterButton = ((System.Windows.Controls.Button)(this.FindName("AddWaterParameterButton")));
        }
    }
}

