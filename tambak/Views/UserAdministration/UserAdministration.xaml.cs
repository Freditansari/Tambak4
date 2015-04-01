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



namespace tambak.Views.UserAdministration
{
    public partial class UserAdministration : Page
    {
        //.addRoleService newRole = new addRoleServiceReference.addRoleService();
        getAllRolesServiceReferrence.getAllRolesClient allRoles = new getAllRolesServiceReferrence.getAllRolesClient();
        GetAllUserServiceReference.getAllUsersServiceClient allUser = new GetAllUserServiceReference.getAllUsersServiceClient();
        

  
        public UserAdministration()
        {
        
            try
            {
                if (WebContext.Current.User.IsInRole("Super Admin"))
                {
                    InitializeComponent();
                    loadRoles();
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
            UserRadGridView.ItemsSource = e.Result;
        }

        private void loadRoles()
        {
            allRoles.getRolesAsync();
            allRoles.getRolesCompleted += allrole_getRolesCompleted;
        }

        private void allrole_getRolesCompleted(object sender, getAllRolesServiceReferrence.getRolesCompletedEventArgs e)
        {
            RolesRadGridView.ItemsSource = e.Result;
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void RadGridView_SelectionChanged_1(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            SelectedUserTextBox.Text = this.UserRadGridView.SelectedItem as string;

        }

        private void RolesRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            selectedRolesTextbox.Text = this.RolesRadGridView.SelectedItem as string;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            addRoleServiceReference.addRoleServiceClient newRole = new addRoleServiceReference.addRoleServiceClient();

            if (RoleNameTextBox.Text != null)
            {
                newRole.addRolesAsync(RoleNameTextBox.Text);
                newRole.addRolesCompleted += newRole_addRolesCompleted;
            }
            else
            {
                throw new ArgumentException("Please re-enter role name");
            }
        }

        private void newRole_addRolesCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            loadRoles();
        }

        private void AssignRoleButton_Click(object sender, RoutedEventArgs e)
        {
            addUsertoRoleServiceReference.addUsertoRoleSVCClient addnewUsertoRole = new addUsertoRoleServiceReference.addUsertoRoleSVCClient();
            addnewUsertoRole.addUserToRoleAsync(SelectedUserTextBox.Text, selectedRolesTextbox.Text);
            addnewUsertoRole.addUserToRoleCompleted += addtoRoleCompleted;
       }

        private void addtoRoleCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            MessageBox.Show("User has been assigned to new role");
        }

    }
}
