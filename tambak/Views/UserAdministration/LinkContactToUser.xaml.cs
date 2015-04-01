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

namespace tambak.Views.UserAdministration
{
    public partial class LinkContactToUser : Page
    {
        GetAllUserServiceReference.getAllUsersServiceClient allUser = new GetAllUserServiceReference.getAllUsersServiceClient();
        ContactToUserLinkDS ContactToUserDomainContext = new ContactToUserLinkDS();
        
        public LinkContactToUser()
        {
      
            
            try
            {
                if ( WebContext.Current.User.IsInRole("Super Admin"))
                {
                    InitializeComponent();
                    loadUsers();
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
        private void loadUsers()
        {
            allUser.getUsersAsync();
            allUser.getUsersCompleted += alluser_getuserCompleted;
        }

        private void alluser_getuserCompleted(object sender, GetAllUserServiceReference.getUsersCompletedEventArgs e)
        {
            userRadGridView.ItemsSource = e.Result;
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

        private void userRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            usernameTextbox.Text = this.userRadGridView.SelectedItem as String;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ContactToUserDomainContext = new ContactToUserLinkDS();
            ContactToUserLink newContact = new ContactToUserLink();
            newContact.ContactID = Convert.ToInt32(contactIDTextBox.Text);
            newContact.Username = usernameTextbox.Text;
            ContactToUserDomainContext.ContactToUserLinks.Add(newContact);
            ContactToUserDomainContext.SubmitChanges();
        }

    }
}
