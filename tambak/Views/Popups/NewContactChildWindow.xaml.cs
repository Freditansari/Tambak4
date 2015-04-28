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
using tambak.Web.DomainServices;
using tambak.Web;

namespace tambak.Views.Popups
{
    public partial class NewContactChildWindow : ChildWindow
    {
        Contact newContact = new Contact();
        ContactDS ContactDomainContext = new ContactDS();
        public NewContactChildWindow()
        {
            InitializeComponent();
            Loaded += NewContactChildWindow_Loaded;
        }

        void NewContactChildWindow_Loaded(object sender, RoutedEventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            newContact.BusinessPhone = "";
            newContact.city = "";
            newContact.Company = "";
            newContact.Country = "";
            newContact.email = "";
            newContact.fax = "";
            newContact.FirstName = "";
            newContact.homePhone = "";
            newContact.jobTitle = "";
            newContact.LastName = "";
            newContact.MobilePhone = "";
            newContact.Notes = "";
            newContact.State = "";
            newContact.WebPage = "";
            newContact.zip = "";
            grid1.DataContext = newContact;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {

            newContact = new Contact();
            newContact.BusinessPhone = businessPhoneTextBox.Text;
            newContact.city = cityTextBox.Text;
            newContact.Company = companyTextBox.Text;
            newContact.Country = countryTextBox.Text;
            newContact.email = emailTextBox.Text;
            newContact.fax = faxTextBox.Text;
            newContact.FirstName = firstNameTextBox.Text;
            newContact.homePhone = homePhoneTextBox.Text;
            newContact.jobTitle = jobTitleTextBox.Text;
            newContact.LastName = lastNameTextBox.Text;
            newContact.MobilePhone = mobilePhoneTextBox.Text;
            newContact.Notes = notesTextBox.Text;
            newContact.State = stateTextBox.Text;
            newContact.WebPage = webPageTextBox.Text;
            newContact.zip = zipTextBox.Text;
            ContactDomainContext.Contacts.Add(newContact);
            OKButton.IsEnabled = false;
            ContactDomainContext.SubmitChanges().Completed +=NewContactChildWindow_Completed;
            
        }

        private void NewContactChildWindow_Completed(object sender, EventArgs e)
        {
            OKButton.IsEnabled = true;
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void contactDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }
    }
}

