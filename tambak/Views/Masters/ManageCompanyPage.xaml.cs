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
    public partial class ManageCompanyPage : Page
    {
        Company newCompany = new Company();
        CompanyDS companyDomainContext = new CompanyDS();
        Company selectedCompany = new Company();
        public ManageCompanyPage()
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

        private void companyDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void NewCompanyButton_Click(object sender, RoutedEventArgs e)
        {
            NewCompanyChildWindows companyCW = new NewCompanyChildWindows();
            companyCW.Show();
            companyCW.Closed += companyCW_Closed;
        }

        void companyCW_Closed(object sender, EventArgs e)
        {
            companyDomainDataSource.Load();
        }

        private void UpdateCompaniesButton_Click_1(object sender, RoutedEventArgs e)
        {

			EntityQuery<Company> bb = from b in companyDomainContext.GetCompaniesQuery() where b.CompanyID == selectedCompany.CompanyID  select b;
            LoadOperation<Company> res = companyDomainContext.Load(bb, new Action<LoadOperation<Company>>(loadSelectedCompany_completed), true);
			
        }

        private void loadSelectedCompany_completed(LoadOperation<Company> obj)
        {
            try
            {
                newCompany = obj.Entities.FirstOrDefault();
                enterNewCompany();
                companyDomainContext.SubmitChanges().Completed+=UpdateSubmitChanges_Completed;
            }
            catch (Exception g)
            {
            }

        }

        private void UpdateSubmitChanges_Completed(object sender, EventArgs e)
        {
            loadCompanyDatagrid();
            selectedCompany = this.companyDataGrid.SelectedItem as Company;
        }

        private void loadCompanyDatagrid()
        {

			EntityQuery<Company> bb = from b in companyDomainContext.GetCompaniesQuery() select b;
            LoadOperation<Company> res = companyDomainContext.Load(bb, new Action<LoadOperation<Company>>(loadCompanyDatagrid_completed), true);
			
        }

        private void loadCompanyDatagrid_completed(LoadOperation<Company> obj)
        {
            companyDataGrid.ItemsSource = companyDomainContext.Companies;
        }
        private void enterNewCompany()
        {
            //grid1.DataContext = newCompany;
            //newCompany = new Company();
            newCompany.Address = addressTextBox.Text;
            newCompany.Address2 = address2TextBox.Text;
            newCompany.City = cityTextBox.Text;
            newCompany.CompanyName = companyNameTextBox.Text;
            newCompany.ContactPerson = contactPersonTextBox.Text;
            newCompany.Country = countryTextBox.Text;
            newCompany.Email = emailTextBox.Text;
            newCompany.EntryDate = DateTime.Now.ToString();
            newCompany.PhoneNumber = phoneNumberTextBox.Text;
            newCompany.UserID = WebContext.Current.User.ToString();
            newCompany.ZipCode = zipCodeTextBox.Text;
            //companyDomainContext.Companies.Add(newCompany);


        }

        private void companyDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedCompany = this.companyDataGrid.SelectedItem as Company;

        }

    }
}
