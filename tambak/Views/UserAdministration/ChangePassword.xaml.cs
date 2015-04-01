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
    public partial class ChangePassword : Page
    {
        public ChangePassword()
        {
      
            try
            {
                if (WebContext.Current.User.IsAuthenticated == true)
                {
                    InitializeComponent();
                    userNameTextBox.Text = WebContext.Current.User.ToString();
                  
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

        private void ChangepasswordButton_Click_1(object sender, RoutedEventArgs e)
        {
            ChangePasswordServiceReference.ChangePasswordServiceClient newPass = new ChangePasswordServiceReference.ChangePasswordServiceClient();
            newPass.UserChangePasswordAsync(userNameTextBox.Text, oldPasswordBox.Password, newPasswordBox.Password);
            newPass.UserChangePasswordCompleted += newPass_UserChangePasswordCompleted;
            
        }

        void newPass_UserChangePasswordCompleted(object sender, ChangePasswordServiceReference.UserChangePasswordCompletedEventArgs e)
        {
            if (e.Result == true)
            {
                MessageBox.Show("password has successfully changed");
            }
            else
            {
                MessageBox.Show("Unable to change password. Please retry " + e.Result);
            }
        }

    }
}
