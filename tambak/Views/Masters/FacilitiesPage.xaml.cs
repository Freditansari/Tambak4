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
using tambak.Web;
using tambak.Web.DomainServices;
using System.ServiceModel.DomainServices.Client;

namespace tambak.Views.Masters
{
    public partial class FacilitiesPage : Page
    {
        Company selectedCompany = new Company();
        Facility newFacility = new Facility();
        FacilityDS FacilityDomainContext = new FacilityDS();
        Facility selectedFacility = new Facility();
        public FacilitiesPage()
        {
            try
            {
                if (WebContext.Current.User.IsInRole("Manager") || WebContext.Current.User.IsInRole("Super Admin"))
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

        private void facilityDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void NewFacilitiesButton_Click_1(object sender, RoutedEventArgs e)
        {
            NewFacilitiesChildWindow NewFacilitiesCW = new NewFacilitiesChildWindow();
            NewFacilitiesCW.Show();
            NewFacilitiesCW.Closed += NewFacilitiesCW_Closed;
        }

        void NewFacilitiesCW_Closed(object sender, EventArgs e)
        {
            facilityDomainDataSource.Load();
        }

        private void enterNewFacility()
        {
            try
            {
                newFacility.Address = addressTextBox.Text;
                newFacility.Address2 = address2TextBox.Text;
                newFacility.City = cityTextBox.Text;
                newFacility.CompanyID = selectedCompany.CompanyID;
                newFacility.ContactPerson = contactPersonTextBox.Text;
                newFacility.Country = countryTextBox.Text;
                newFacility.Email = emailTextBox.Text;
                
                newFacility.PhoneNumber = phoneNumberTextBox.Text;
                newFacility.UserID = WebContext.Current.User.ToString();
                newFacility.State = stateTextBox.Text;
                newFacility.ZipCode = zipCodeTextBox.Text;
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }

        private void UpdateFacilitiesButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EntityQuery<Facility> bb = from b in FacilityDomainContext.GetFacilitiesQuery() where b.FacilityId == selectedFacility.FacilityId select b;
                LoadOperation<Facility> res = FacilityDomainContext.Load(bb, new Action<LoadOperation<Facility>>(UpdateFacility_completed), true);
            }
            catch (Exception g)
            {
            }
            
        }

        private void UpdateFacility_completed(LoadOperation<Facility> obj)
        {
            try
            {
                newFacility = obj.Entities.FirstOrDefault();
                enterNewFacility();
                FacilityDomainContext.SubmitChanges().Completed+=FacilityUpdateCompleted;
            }
            catch (Exception g)
            {
            }
        }

        private void FacilityUpdateCompleted(object sender, EventArgs e)
        {
            loadFacilityDatagrid();
            selectedFacility = this.facilityDataGrid.SelectedItem as Facility;
        }

        private void loadFacilityDatagrid()
        {

			EntityQuery<Facility> bb = from b in FacilityDomainContext.GetFacilitiesQuery() select b;
            LoadOperation<Facility> res = FacilityDomainContext.Load(bb, new Action<LoadOperation<Facility>>(loadFacilityDatagrid_completed), true);
			
        }

        private void loadFacilityDatagrid_completed(LoadOperation<Facility> obj)
        {
            facilityDataGrid.ItemsSource = FacilityDomainContext.Facilities;
        }

        private void companyDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
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
        }

        private void facilityDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedFacility = this.facilityDataGrid.SelectedItem as Facility;

        }
    }
}
