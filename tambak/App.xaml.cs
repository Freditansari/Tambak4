namespace tambak
{
    using System;
    using System.Runtime.Serialization;
    using System.ServiceModel.DomainServices.Client.ApplicationServices;
    using System.Windows;
    using System.Windows.Controls;
    using System.Collections.Generic;
    using tambak.Web;
    using tambak.Web.DomainServices;
    using System.Globalization;
    using System.ServiceModel.DomainServices.Client;

    /// <summary>
    /// Main <see cref="Application"/> class.
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Creates a new <see cref="App"/> instance.
        /// </summary>

        public static List<MasterTax> globalSelectedTax = new List<MasterTax>();
        public static CultureInfo cultInfo = new CultureInfo("id-ID");

        //todo : change this to get the automated python background processes  working  
        public static string DatabaseName = "CPL";
        // public static string DatabaseName = "Hasfarm"
        // public static string DatabaseName = "KotaAgung"
        
        public static List<Product> SelectedProduct = new List<Product>();
        public App()
        {

            this.Startup += this.Application_Startup;

            this.CheckAndDownloadUpdateCompleted += new CheckAndDownloadUpdateCompletedEventHandler(App_CheckAndDownloadUpdateCompleted);

            InitializeComponent();

            // Create a WebContext and add it to the ApplicationLifetimeObjects collection.
            // This will then be available as WebContext.Current.
            WebContext webContext = new WebContext();
            webContext.Authentication = new FormsAuthentication();
            //webContext.Authentication = new WindowsAuthentication();
            this.ApplicationLifetimeObjects.Add(webContext);
        }

        private void App_CheckAndDownloadUpdateCompleted(object sender, CheckAndDownloadUpdateCompletedEventArgs e)
        {
            if (e.UpdateAvailable)
            {
                MessageBox.Show("Application updated, please restart");
            }
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
           
            try
            {
              
                // This will enable you to bind controls in XAML to WebContext.Current properties.
                this.Resources.Add("WebContext", WebContext.Current);

                // This will automatically authenticate a user when using Windows authentication or when the user chose "Keep me signed in" on a previous login attempt.
                WebContext.Current.Authentication.LoadUser(this.Application_UserLoaded, null);

                // Show some UI to the user while LoadUser is in progress
                this.InitializeRootVisual();
                if (this.IsRunningOutOfBrowser)
                {
                    this.CheckAndDownloadUpdateAsync();
                }
            }
            catch (Exception)
            {
                
              
            }
          
        }

      

        /// <summary>
        /// Invoked when the <see cref="LoadUserOperation"/> completes.
        /// Use this event handler to switch from the "loading UI" you created in <see cref="InitializeRootVisual"/> to the "application UI".
        /// </summary>
        private void Application_UserLoaded(LoadUserOperation operation)
        {
            if (operation.HasError)
            {
                ErrorWindow.CreateNew(operation.Error);
                operation.MarkErrorAsHandled();
            }
        }

        /// <summary>
        /// Initializes the <see cref="Application.RootVisual"/> property.
        /// The initial UI will be displayed before the LoadUser operation has completed.
        /// The LoadUser operation will cause user to be logged in automatically if using Windows authentication or if the user had selected the "Keep me signed in" option on a previous login.
        /// </summary>
        protected virtual void InitializeRootVisual()
        {
            tambak.Controls.BusyIndicator busyIndicator = new tambak.Controls.BusyIndicator();
            busyIndicator.Content = new MainPage();
            busyIndicator.HorizontalContentAlignment = HorizontalAlignment.Stretch;
            busyIndicator.VerticalContentAlignment = VerticalAlignment.Stretch;

            this.RootVisual = busyIndicator;
        }

        private void Application_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            // If the app is running outside of the debugger then report the exception using a ChildWindow control.
            if (!System.Diagnostics.Debugger.IsAttached)
            {
                // NOTE: This will allow the application to continue running after an exception has been thrown but not handled. 
                // For production applications this error handling should be replaced with something that will report the error to the website and stop the application.
                e.Handled = true;
                ErrorWindow.CreateNew(e.ExceptionObject);
            }
        }
    }
}