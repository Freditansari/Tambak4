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
    public partial class NewCompanyChildWindows : ChildWindow
    {
        Company newCompany = new Company();
        CompanyDS companyDomainContext = new CompanyDS();
        //bool ItHasCleared = false;
        public NewCompanyChildWindows()
        {
            InitializeComponent();
           
            
            //LayoutRoot.DataContext = newCompany;
            Loaded += NewCompanyChildWindows_Loaded;
        }

        void NewCompanyChildWindows_Loaded(object sender, RoutedEventArgs e)
        {
            grid1.DataContext = newCompany;
            enterNewCompany();
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

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            enterNewCompany();
            companyDomainContext.Companies.Add(newCompany);
            companyDomainContext.SubmitChanges().Completed += NewCompanyChildWindows_Completed;
           
        }

        void NewCompanyChildWindows_Completed(object sender, EventArgs e)
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

        private void addressTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            enterNewCompany();
        }

        private void LayoutRoot_GotFocus(object sender, RoutedEventArgs e)
        {
            //if (ItHasCleared == false)
            //{
            //    newCompany = new Company();
            //    grid1.DataContext = newCompany;
            //    enterNewCompany();
            //    ItHasCleared = true;

            //}
        }
    }
}

