using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
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


namespace tambak.Views.Popups
{
    public partial class SelectTaxChildWindow : ChildWindow
    {
        MasterTax selectedTax = new MasterTax();
        MasterTax DataGridSelectedTax = new MasterTax();
        IsolatedStorageSettings appSettings = IsolatedStorageSettings.ApplicationSettings;

        
        List<MasterTax> ListSelectedTax = new List<MasterTax>();
      
        
        public SelectTaxChildWindow()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            appSettings.Remove("ListSelectedTax");
            App.globalSelectedTax = null;
           
            this.DialogResult = false;
        }

        private void masterTaxDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void taxDescriptionListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedTax = this.taxDescriptionListBox.SelectedItem as MasterTax;

        }

        private void purchaseTaxTransactionDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {

            ListSelectedTax.Add(selectedTax);
            
            
            try
            {
                
			  
			    appSettings.Add("ListSelectedTax", ListSelectedTax);
			
            }
            catch (Exception g)
            {

                appSettings.Remove("ListSelectedTax");
                appSettings.Add("ListSelectedTax", ListSelectedTax);
            }

            App.globalSelectedTax = ListSelectedTax;
        
            warningTextBlock.Text += selectedTax.TaxDescription+" Tax added\n" ;
            
        }

      

       
    }
}

