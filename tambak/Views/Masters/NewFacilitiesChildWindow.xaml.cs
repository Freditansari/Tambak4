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
using tambak.Web;
using tambak.Web.DomainServices;

namespace tambak.Views.Masters
{
    public partial class NewFacilitiesChildWindow : ChildWindow
    {
        Company selectedCompany = new Company();
        Facility newFacility = new Facility();
        FacilityDS FacilityDomainContext = new FacilityDS();
        
        public NewFacilitiesChildWindow()
        {
            InitializeComponent();

            Loaded += NewFacilitiesChildWindow_Loaded;
        }

        void NewFacilitiesChildWindow_Loaded(object sender, RoutedEventArgs e)
        {
            grid1.DataContext = newFacility;
            enterNewFacility();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            //newFacility = new Facility();
            enterNewFacility();
            FacilityDomainContext.Facilities.Add(newFacility);
            FacilityDomainContext.SubmitChanges().Completed += NewFacilitiesChildWindow_Completed;
            
            
        }

        void NewFacilitiesChildWindow_Completed(object sender, EventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void facilityDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
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
                //newFacility.EntryDate = DateTime.Now.ToString();
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
    }
}

