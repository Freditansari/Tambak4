﻿#pragma checksum "C:\Users\fredy\Documents\GitHub\Tambak4\tambak\Views\Production\GlobalProductionPageSummary.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "39BAEA22ED2AD1955313D38EBEBDF77F"
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


namespace tambak.Views.Production {
    
    
    public partial class GlobalProductionPageSummary : System.Windows.Controls.Page {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Telerik.Windows.Controls.RadGridView ActiveProductionCycleRadGridView;
        
        internal System.Windows.Controls.TextBlock TotalCummulativeFeedTextBlock;
        
        internal System.Windows.Controls.TextBlock TotalBiomassTextBlock;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/tambak;component/Views/Production/GlobalProductionPageSummary.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ActiveProductionCycleRadGridView = ((Telerik.Windows.Controls.RadGridView)(this.FindName("ActiveProductionCycleRadGridView")));
            this.TotalCummulativeFeedTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("TotalCummulativeFeedTextBlock")));
            this.TotalBiomassTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("TotalBiomassTextBlock")));
        }
    }
}
