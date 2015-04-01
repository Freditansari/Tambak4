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


namespace tambak.Views.Inventory
{
    public partial class NewSupplierChildWindows : ChildWindow
    {
        SuppliersDS supplierDomainContext = new SuppliersDS();
        bool hasGotFocus = false;
        public NewSupplierChildWindows()
        {
            InitializeComponent();
            
            try
            {
                Loaded += NewSupplierChildWindows_Loaded;
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
                
            }
            cleanTextBoxes();

        }

        void NewSupplierChildWindows_Loaded(object sender, RoutedEventArgs e)
        {
            

            cleanTextBoxes();
        }

        private void cleanTextBoxes()
        {
            addressTextBox.Text="";
            address2TextBox.Text="";
            cityTextBox.Text="";
            companyNameTextBox.Text="";
            countryTextBox.Text="";
             dOBTextBox.Text=" ";
            emailTextBox.Text="";
            firstNameTextBox.Text="";
            lastNameTextBox.Text="";
            phoneNumberTextBox.Text="";
            entryDateDatePicker.SelectedDate = null;
            userIDTextBox.Text=WebContext.Current.User.ToString();
            supplierIDTextBox.Text = "";
            zipCodeTextBox.Text="";
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Supplier newSupplier = new Supplier();
                newSupplier.Address = addressTextBox.Text;
                newSupplier.Address2 = address2TextBox.Text;
                newSupplier.City = cityTextBox.Text;
                newSupplier.CompanyName = companyNameTextBox.Text;
                newSupplier.Country = countryTextBox.Text;
                newSupplier.DOB = dOBTextBox.Text;
                newSupplier.Email = emailTextBox.Text;
                newSupplier.FirstName = firstNameTextBox.Text;
                newSupplier.LastName = lastNameTextBox.Text;
                newSupplier.PhoneNumber = phoneNumberTextBox.Text;
                newSupplier.UserID = userIDTextBox.Text;
                newSupplier.ZipCode = zipCodeTextBox.Text;


                supplierDomainContext.Suppliers.Add(newSupplier);
                supplierDomainContext.SubmitChanges().Completed += NewSupplierChildWindows_Completed;
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
            //this.DialogResult = true;
        }

        void NewSupplierChildWindows_Completed(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = true;
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void supplierDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {
           
            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }

            //cleanTextBoxes();
        }

   

    

        private void LayoutRoot_GotFocus(object sender, RoutedEventArgs e)
        {
            if (hasGotFocus == false)
            {
                cleanTextBoxes();
                hasGotFocus = true;
            }
            else
            {
            }

        }

        
    }
}

