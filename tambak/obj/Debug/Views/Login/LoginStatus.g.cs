﻿#pragma checksum "C:\Users\fredy\Documents\GitHub\tambak2\Tambak4\tambak\Views\Login\LoginStatus.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BAFA2D01A0B14E1E366D4276B79A49A0"
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


namespace tambak.LoginUI {
    
    
    public partial class LoginStatus : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.StackPanel LayoutRoot;
        
        internal System.Windows.VisualStateGroup loginStates;
        
        internal System.Windows.VisualState windowsAuth;
        
        internal System.Windows.VisualState loggedIn;
        
        internal System.Windows.VisualState loggedOut;
        
        internal System.Windows.Controls.StackPanel loginControls;
        
        internal System.Windows.Controls.Button loginButton;
        
        internal System.Windows.Controls.StackPanel welcomeControls;
        
        internal System.Windows.Controls.TextBlock welcomeText;
        
        internal System.Windows.Controls.StackPanel logoutControls;
        
        internal System.Windows.Controls.Button logoutButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/tambak;component/Views/Login/LoginStatus.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.StackPanel)(this.FindName("LayoutRoot")));
            this.loginStates = ((System.Windows.VisualStateGroup)(this.FindName("loginStates")));
            this.windowsAuth = ((System.Windows.VisualState)(this.FindName("windowsAuth")));
            this.loggedIn = ((System.Windows.VisualState)(this.FindName("loggedIn")));
            this.loggedOut = ((System.Windows.VisualState)(this.FindName("loggedOut")));
            this.loginControls = ((System.Windows.Controls.StackPanel)(this.FindName("loginControls")));
            this.loginButton = ((System.Windows.Controls.Button)(this.FindName("loginButton")));
            this.welcomeControls = ((System.Windows.Controls.StackPanel)(this.FindName("welcomeControls")));
            this.welcomeText = ((System.Windows.Controls.TextBlock)(this.FindName("welcomeText")));
            this.logoutControls = ((System.Windows.Controls.StackPanel)(this.FindName("logoutControls")));
            this.logoutButton = ((System.Windows.Controls.Button)(this.FindName("logoutButton")));
        }
    }
}

