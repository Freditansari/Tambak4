namespace tambak
{
    using System.ServiceModel.DomainServices.Client;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Navigation;
    using tambak.LoginUI;
    using Telerik.Windows.Controls;
    using tambak.Web;
    using tambak.Web.DomainServices;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// <see cref="UserControl"/> class providing the main UI for the application.
    /// </summary>
    public partial class MainPage : UserControl
    {
        /// <summary>
        /// Creates a new <see cref="MainPage"/> instance.
        /// </summary>
      

        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            ApplicationNameTextBlock.Text = App.DatabaseName.ToString();


     
			
        }


       

        
       

        /// <summary>
        /// After the Frame navigates, ensure the <see cref="HyperlinkButton"/> representing the current page is selected
        /// </summary>
        private void ContentFrame_Navigated(object sender, NavigationEventArgs e)
        {
            foreach (UIElement child in LinksStackPanel.Children)
            {
                HyperlinkButton hb = child as HyperlinkButton;
                if (hb != null && hb.NavigateUri != null)
                {
                    if (hb.NavigateUri.ToString().Equals(e.Uri.ToString()))
                    {
                        VisualStateManager.GoToState(hb, "ActiveLink", true);
                    }
                    else
                    {
                        VisualStateManager.GoToState(hb, "InactiveLink", true);
                    }
                }
            }
        }

        /// <summary>
        /// If an error occurs during navigation, show an error window
        /// </summary>
        private void ContentFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            e.Handled = true;
            ErrorWindow.CreateNew(e.Exception);
        }

        private void NavMenu_ItemClick(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
             RadMenuItem item = e.OriginalSource as RadMenuItem;
             if (item != null)
             {
                 switch (item.Header.ToString())
                 {
                     case "Manage Ponds":
                         this.ContentFrame.Navigate(new System.Uri("/PondsView", System.UriKind.Relative));
                         break;
                     case "Ponds Consumptions":
                         this.ContentFrame.Navigate(new System.Uri("/PondsConsumptionsLogs", System.UriKind.Relative));
                         break;
                     case "Ponds Logs":
                         this.ContentFrame.Navigate(new System.Uri("/PondLogs", System.UriKind.Relative));
                         break;
                     case "Ponds Production Cycle":
                         this.ContentFrame.Navigate(new System.Uri("/PondsProductionCycleView", System.UriKind.Relative));
                         break;
                     case "Manage Tasks":
                         this.ContentFrame.Navigate(new System.Uri("/TasksModule/ManageTasks", System.UriKind.Relative));
                         break;
                     //case "New Tasks":
                     //    this.ContentFrame.Navigate(new System.Uri("/TasksModule/ManageTasks", System.UriKind.Relative));
                     //    break;
                     case "Product Registration":
                         this.ContentFrame.Navigate(new System.Uri("/Inventory/ProductRegistration", System.UriKind.Relative));
                         break;
                     case "Product Management":
                         this.ContentFrame.Navigate(new System.Uri("/Inventory/ProductManagement", System.UriKind.Relative));
                         break;
                     case "Sales Orders":
                         this.ContentFrame.Navigate(new System.Uri("/Inventory/SalesOrders", System.UriKind.Relative));
                         break;
                     case "Ponds Status":
                         this.ContentFrame.Navigate(new System.Uri("/PondStatus", System.UriKind.Relative));
                         break;
                     case "Purchase Orders":
                         this.ContentFrame.Navigate(new System.Uri("/Inventory/NewPurchaseOrder", System.UriKind.Relative));
                         break;
                     case "Delivery Log":
                         this.ContentFrame.Navigate(new System.Uri("/Inventory/DeliveryLogPage", System.UriKind.Relative));
                         break;
                     case "Manage Users":
                         this.ContentFrame.Navigate(new System.Uri("/UserAdministration/UserAdministration", System.UriKind.Relative));
                         break;
                     case "Register New Contact":
                         this.ContentFrame.Navigate(new System.Uri("/ContactForm", System.UriKind.Relative));
                         break;
                     case "Change Password":
                         this.ContentFrame.Navigate(new System.Uri("/UserAdministration/ChangePassword", System.UriKind.Relative));
                         break;
                     case "Link User Name to Contact":
                         this.ContentFrame.Navigate(new System.Uri("/UserAdministration/LinkContactToUser", System.UriKind.Relative));
                         break;
                     case "Feed Estimation":
                         this.ContentFrame.Navigate(new System.Uri("/Inventory/feedEstimation", System.UriKind.Relative));
                         break;
                     case "PO Control":
                         this.ContentFrame.Navigate(new System.Uri("/Inventory/POControl", System.UriKind.Relative));
                         break;
                     case "Company":
                         this.ContentFrame.Navigate(new System.Uri("/Masters/ManageCompanyPage", System.UriKind.Relative));
                         break;
                     case "Facilities":
                         this.ContentFrame.Navigate(new System.Uri("/Masters/FacilitiesPage", System.UriKind.Relative));
                         break;
                     case "Tax":
                         this.ContentFrame.Navigate(new System.Uri("/Masters/TaxPage", System.UriKind.Relative));
                         break;
                     case "Consume Material":
                         this.ContentFrame.Navigate(new System.Uri("/Production/ConsumeMaterialPage", System.UriKind.Relative));
                         break;
                     case "Harvest Log":
                         this.ContentFrame.Navigate(new System.Uri("/Production/HarvestPage", System.UriKind.Relative));
                         break;
                     case "Ponds Charts":
                         this.ContentFrame.Navigate(new System.Uri("/Charts/SamplingCharts", System.UriKind.Relative));
                         break;
                     case "Production Costs":
                         this.ContentFrame.Navigate(new System.Uri("/Production/ProductionCostsPage", System.UriKind.Relative));
                         break;
                 }
             }
        }

        public object loadCompany_Completed { get; set; }
    }
}