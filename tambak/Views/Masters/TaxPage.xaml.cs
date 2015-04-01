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
    public partial class TaxPage : Page
    {
        MasterTax newTax = new MasterTax();
        MasterTaxDS taxDomainConext = new MasterTaxDS();
        MasterTax selectedTax = new MasterTax();

        public TaxPage()
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

        private void masterTaxDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void NewTaxButton_Click(object sender, RoutedEventArgs e)
        {
            NewTaxChildWindows taxCW = new NewTaxChildWindows();
            taxCW.Show();
            taxCW.Closed += taxCW_Closed;

        }

        void taxCW_Closed(object sender, EventArgs e)
        {
            masterTaxDomainDataSource.Load();
        }

        private void UpdateTaxButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EntityQuery<MasterTax> bb = from b in taxDomainConext.GetMasterTaxesQuery() where b.TaxID == selectedTax.TaxID select b;
                LoadOperation<MasterTax> res = taxDomainConext.Load(bb, new Action<LoadOperation<MasterTax>>(loadSelectedMasterTax_Completed), true);
            }
            catch (Exception g)
            {
            }
        }

        private void loadSelectedMasterTax_Completed(LoadOperation<MasterTax> obj)
        {
            try
            {
                newTax = obj.Entities.First();
                enterNewTax();
                taxDomainConext.SubmitChanges().Completed += TaxPage_Completed;
            }
            catch (Exception)
            {
                
                
            }
           
        }

        void TaxPage_Completed(object sender, EventArgs e)
        {
            loadMasterTax();
            selectedTax = this.masterTaxDataGrid.SelectedItem as MasterTax;
			
        }
        private void loadMasterTax()
        {
            EntityQuery<MasterTax> bb = from b in taxDomainConext.GetMasterTaxesQuery() select b;
            LoadOperation<MasterTax> res = taxDomainConext.Load(bb, new Action<LoadOperation<MasterTax>>(loadMasterTax_Completed), true);
			
        }

        private void loadMasterTax_Completed(LoadOperation<MasterTax> obj)
        {
            masterTaxDataGrid.ItemsSource = taxDomainConext.MasterTaxes;
        }
        private void enterNewTax()
        {

            try
            {
                newTax.TaxDescription = taxDescriptionTextBox.Text;
                newTax.TaxRate = Convert.ToDecimal(taxRateTextBox.Text) / 100;
            }
            catch (Exception g)
            {


            }
        }

        private void masterTaxDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedTax = this.masterTaxDataGrid.SelectedItem as MasterTax;
        }

    }
}
