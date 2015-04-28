using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace tambak.Views.Inventory
{
    public partial class InventoryLevel : Page
    {
        public InventoryLevel()
        {
            try
            {
                if (WebContext.Current.User.IsInRole("Manager") || WebContext.Current.User.IsInRole("Accounting") || WebContext.Current.User.IsInRole("Super Admin"))
                {


                    InitializeComponent();
                    

                }
                else
                {
                    throw new ArgumentException("Insufficient Access. Please login with higher access.");
                }
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void currentInventoryViewDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

    }
}
