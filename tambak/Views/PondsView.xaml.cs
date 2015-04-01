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
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.DataVisualization;
using System.Collections.ObjectModel;
using Telerik.Windows.Controls.Map;


namespace tambak.Views
{
    public partial class Ponds : Page
    {
        public Ponds()
        {

            try
            {
                if (WebContext.Current.User.IsInRole("Technician") || WebContext.Current.User.IsInRole("Super Admin"))
                {
                    InitializeComponent();
                    Location newLocation = new Location(-3.680504, 102.237393);
            
                    bringToLocation(newLocation);
                }
                else
                {
                    throw new ArgumentException("Insufficient Access. Please login with higher access.");
                }
            }

            catch (ArgumentException g)
            {
                MessageBox.Show(g.Message);

            }
           
            

          
        }

        private void bringToLocation(Location desiredLocation)
        {
            this.pondMap.Center = desiredLocation;
            this.pondMap.ZoomLevel = 12;

            //this.pondMap.MaxZoomLevel();

        }


        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void pondDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewPondForm NpF = new NewPondForm();
            NpF.Show();
        }

    }
}
