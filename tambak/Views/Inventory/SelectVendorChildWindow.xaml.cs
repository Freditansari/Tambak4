using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net;
using System.ServiceModel.DomainServices.Client;
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
    public partial class SelectVendorChildWindow : ChildWindow
    {
        private IsolatedStorageSettings appSettings = IsolatedStorageSettings.ApplicationSettings;
        SuppliersDS supplierDomainContext = new SuppliersDS();
        
        public SelectVendorChildWindow()
        {
            InitializeComponent();
            Loaded += SelectVendorChildWindow_Loaded;
        }

        void SelectVendorChildWindow_Loaded(object sender, RoutedEventArgs e)
        {
            appSettings.Remove("SelectedVendorID");
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
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
        }

        private void supplierRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            appSettings.Remove("SelectedVendorID");
            Supplier selectedSupplier = this.supplierRadGridView.SelectedItem as Supplier;
            appSettings.Add("SelectedVendorID", selectedSupplier.SupplierID);

        }

        private void newSupplierButton_Click(object sender, RoutedEventArgs e)
        {
            NewSupplierChildWindows newSupplierCW = new NewSupplierChildWindows();
            newSupplierCW.Show();
            newSupplierCW.Closed += newSupplierCW_Closed;
        }

        void newSupplierCW_Closed(object sender, EventArgs e)
        {
            loadSupplierRadGridView();

        }

        private void loadSupplierRadGridView()
        {
            supplierDomainContext = new SuppliersDS();
			EntityQuery<Supplier> bb = from b in supplierDomainContext.GetSuppliersQuery() select b;
            LoadOperation<Supplier> res = supplierDomainContext.Load(bb, new Action<LoadOperation<Supplier>>(loadSupplierRadGridView_completed), true);
			
        }

        private void loadSupplierRadGridView_completed(LoadOperation<Supplier> obj)
        {
            supplierRadGridView.ItemsSource = supplierDomainContext.Suppliers;
        }
    }
}

