using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net;
using System.ServiceModel.DomainServices.Client;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using tambak.Web;
using tambak.Web.DomainServices;

namespace tambak.Views.Popups
{
    public partial class SelectFacilityChildWindow : ChildWindow
    {
        Company selectedCompany = new Company();
        CompanyDS companyDomainContext = new CompanyDS();
        Facility SelectedFacility = new Facility();
        FacilityDS FacilityDomainContext = new FacilityDS();
        public SelectFacilityChildWindow()
        {
            try
            {
                if (WebContext.Current.User.IsInRole("Manager") || WebContext.Current.User.IsInRole("Super Admin"))
                {
                    InitializeComponent();
                   

                }
                else if (!WebContext.Current.User.IsInRole("Manager")) 
                {
                    addNewFacilityButton.IsEnabled = false;
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

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void companyDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void facilityDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void companyNameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedCompany = this.companyNameComboBox.SelectedItem as Company;
            loadFacilityDataGrid();
        }

        private void loadFacilityDataGrid()
        {
            try
            {
                FacilityDomainContext = new FacilityDS();
                EntityQuery<Facility> bb = from b in FacilityDomainContext.GetFacilitiesQuery() where b.CompanyID == selectedCompany.CompanyID select b;
                LoadOperation<Facility> res = FacilityDomainContext.Load(bb, new Action<LoadOperation<Facility>>(loadFacilityDataGrid_completed), true);
            }
            catch (Exception g)
            {
            }
        }

        private void loadFacilityDataGrid_completed(LoadOperation<Facility> obj)
        {
            facilityDataGrid.ItemsSource = FacilityDomainContext.Facilities;
            
			
			
        }

        private void facilityDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                SelectedFacility = this.facilityDataGrid.SelectedItem as Facility;
                //IsolatedStorageSettings appSettings = IsolatedStorageSettings.ApplicationSettings;
                //appSettings.Add("SelectedFacilityID", SelectedFacility.FacilityId);
                App.SelectedFacilityID = SelectedFacility.FacilityId;
            }
            catch (Exception g)
            {
            }
        }

        private void addNewFacilityButton_Click(object sender, RoutedEventArgs e)
        {
            Masters.NewFacilitiesChildWindow newFacilityCW = new Masters.NewFacilitiesChildWindow();
            newFacilityCW.Show();
            newFacilityCW.Closed += newFacilityCW_Closed;
        }

        void newFacilityCW_Closed(object sender, EventArgs e)
        {
            loadFacilityDataGrid();
        }

    }
}

