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
using System.ServiceModel.DomainServices.Client;

namespace tambak.Views
{
    public partial class ContactForm : Page
    {
        ContactDS ContactDomainContext = new ContactDS();
        ContactDS newContactDomainContext = new ContactDS();
        public Contact SelectedContact { get; set; }
        //tambak.Web.Contact newContact = new Contact();

        public ContactForm()
        {
            try
            {
                if (WebContext.Current.User.IsInRole("Manager") || WebContext.Current.User.IsInRole("Super Admin"))
                {
                    InitializeComponent();
                    Loaded += ContactForm_Loaded;

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

        void ContactForm_Loaded(object sender, RoutedEventArgs e)
        {
            loadAllContacts();
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

            this.NewContactButton.IsEnabled = false;
            
            ContactDomainContext.SubmitChanges().Completed += ContactDomainContext_submitCompleted;
        }

        private void ContactDomainContext_submitCompleted(object sender, EventArgs e)
        {
            this.NewContactButton.IsEnabled = true;
            //loadAllContacts();
        }

        private void loadAllContacts()
        {

			EntityQuery<Contact> bb = from b in ContactDomainContext.GetContactsQuery() select b;
            LoadOperation<Contact> res = ContactDomainContext.Load(bb, new Action<LoadOperation<Contact>>(loadAllContacts_completed), true);
			
        }

        private void loadAllContacts_completed(LoadOperation<Contact> obj)
        {
            contactRadGridView.ItemsSource = ContactDomainContext.Contacts;
        }

        private void contactRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            SelectedContact = this.contactRadGridView.SelectedItem as Contact;
            grid1.DataContext = SelectedContact;
        }

        

        private void addNewContactButton_Click(object sender, RoutedEventArgs e)
        {
            //newContactDomainContext = new ContactDS();
            //newContact = new Contact();
            //newContact.BusinessPhone = businessPhoneTextBox.Text;
            //newContact.city = cityTextBox.Text;
            //newContact.Company = companyTextBox.Text;
            //newContact.Country = countryTextBox.Text;
            //newContact.email = emailTextBox.Text;
            //newContact.fax = faxTextBox.Text;
            //newContact.FirstName = firstNameTextBox.Text;
            //newContact.homePhone = homePhoneTextBox.Text;
            //newContact.jobTitle = jobTitleTextBox.Text;
            //newContact.LastName = lastNameTextBox.Text;
            //newContact.MobilePhone = mobilePhoneTextBox.Text;
            //newContact.Notes = notesTextBox.Text;
            //newContact.State = stateTextBox.Text;
            //newContact.WebPage = webPageTextBox.Text;
            //newContact.zip = zipTextBox.Text;
            //ContactDomainContext.Contacts.Add(newContact);
            //contactRadGridView.ItemsSource = newContactDomainContext.Contacts;
            Popups.NewContactChildWindow newContactCW = new Popups.NewContactChildWindow();
            newContactCW.Show();
            newContactCW.Closed += newContactCW_Closed;
        }

        void newContactCW_Closed(object sender, EventArgs e)
        {
            loadAllContacts();
        }

        private void clearFields()
        {
            //newContact.BusinessPhone = "";
            //newContact.city = "";
            //newContact.Company = "";
            //newContact.Country = "";
            //newContact.email = "";
            //newContact.fax = "";
            //newContact.FirstName = "";
            //newContact.homePhone = "";
            //newContact.jobTitle = "";
            //newContact.LastName = "";
            //newContact.MobilePhone = "";
            //newContact.Notes = "";
            //newContact.State = "";
            //newContact.WebPage = "";
            //newContact.zip = "";
            //grid1.DataContext = newContact;
        }


        
    }
}
