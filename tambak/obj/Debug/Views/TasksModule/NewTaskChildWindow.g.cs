﻿#pragma checksum "C:\Users\fredy\Documents\GitHub\tambak2\Tambak4\tambak\Views\TasksModule\NewTaskChildWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6B881078CD89BAE774B7F8ABB76832A1"
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


namespace tambak.Views.TasksModule {
    
    
    public partial class NewTaskChildWindow : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.DomainDataSource taskDomainDataSource;
        
        internal System.Windows.Controls.DomainDataSource employeeNameViewDomainDataSource;
        
        internal System.Windows.Controls.DomainDataSource pondDomainDataSource;
        
        internal System.Windows.Controls.Grid grid3;
        
        internal System.Windows.Controls.TextBox attachmentsTextBox;
        
        internal System.Windows.Controls.TextBox completePercentageTextBox;
        
        internal System.Windows.Controls.TextBox descriptionTextBox;
        
        internal Telerik.Windows.Controls.RadDateTimePicker dueDateRadDateTimePicker;
        
        internal Telerik.Windows.Controls.RadDateTimePicker endDateRadDateTimePicker;
        
        internal System.Windows.Controls.ComboBox pondDescriptionComboBox;
        
        internal System.Windows.Controls.ComboBox PriorityComboBox;
        
        internal System.Windows.Controls.TextBox productionCycleIDTextBox;
        
        internal System.Windows.Controls.TextBox reccurencePatternTextBox;
        
        internal Telerik.Windows.Controls.RadDateTimePicker startDateRadDateTimePicker;
        
        internal System.Windows.Controls.ComboBox StatusComboBox;
        
        internal System.Windows.Controls.TextBox taskIDTextBox;
        
        internal System.Windows.Controls.TextBox titleTextBox;
        
        internal System.Windows.Controls.TextBox userIdTextBox;
        
        internal System.Windows.Controls.ComboBox nameComboBox;
        
        internal System.Windows.Controls.CheckBox isDoneCheckBox;
        
        internal System.Windows.Controls.TextBox plannedManHoursTextBox;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/tambak;component/Views/TasksModule/NewTaskChildWindow.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.taskDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("taskDomainDataSource")));
            this.employeeNameViewDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("employeeNameViewDomainDataSource")));
            this.pondDomainDataSource = ((System.Windows.Controls.DomainDataSource)(this.FindName("pondDomainDataSource")));
            this.grid3 = ((System.Windows.Controls.Grid)(this.FindName("grid3")));
            this.attachmentsTextBox = ((System.Windows.Controls.TextBox)(this.FindName("attachmentsTextBox")));
            this.completePercentageTextBox = ((System.Windows.Controls.TextBox)(this.FindName("completePercentageTextBox")));
            this.descriptionTextBox = ((System.Windows.Controls.TextBox)(this.FindName("descriptionTextBox")));
            this.dueDateRadDateTimePicker = ((Telerik.Windows.Controls.RadDateTimePicker)(this.FindName("dueDateRadDateTimePicker")));
            this.endDateRadDateTimePicker = ((Telerik.Windows.Controls.RadDateTimePicker)(this.FindName("endDateRadDateTimePicker")));
            this.pondDescriptionComboBox = ((System.Windows.Controls.ComboBox)(this.FindName("pondDescriptionComboBox")));
            this.PriorityComboBox = ((System.Windows.Controls.ComboBox)(this.FindName("PriorityComboBox")));
            this.productionCycleIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("productionCycleIDTextBox")));
            this.reccurencePatternTextBox = ((System.Windows.Controls.TextBox)(this.FindName("reccurencePatternTextBox")));
            this.startDateRadDateTimePicker = ((Telerik.Windows.Controls.RadDateTimePicker)(this.FindName("startDateRadDateTimePicker")));
            this.StatusComboBox = ((System.Windows.Controls.ComboBox)(this.FindName("StatusComboBox")));
            this.taskIDTextBox = ((System.Windows.Controls.TextBox)(this.FindName("taskIDTextBox")));
            this.titleTextBox = ((System.Windows.Controls.TextBox)(this.FindName("titleTextBox")));
            this.userIdTextBox = ((System.Windows.Controls.TextBox)(this.FindName("userIdTextBox")));
            this.nameComboBox = ((System.Windows.Controls.ComboBox)(this.FindName("nameComboBox")));
            this.isDoneCheckBox = ((System.Windows.Controls.CheckBox)(this.FindName("isDoneCheckBox")));
            this.plannedManHoursTextBox = ((System.Windows.Controls.TextBox)(this.FindName("plannedManHoursTextBox")));
        }
    }
}

