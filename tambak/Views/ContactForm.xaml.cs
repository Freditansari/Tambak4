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
using tambak.Web.DomainServices;
using tambak.Web;

namespace tambak.Views
{
    public partial class ContactForm : Page
    {
        ContactDS ContactDomainContext = new ContactDS();

        public ContactForm()
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

            catch (ArgumentException g)
            {
                MessageBox.Show(g.Message);

            }
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void contactDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            ContactDomainContext = new ContactDS();
            tambak.Web.Contact newContact = new Contact();
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
            ContactDomainContext.SubmitChanges();
        }

    }
}
