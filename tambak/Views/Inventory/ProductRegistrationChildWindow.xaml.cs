using System;
using System.Collections.Generic;
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
    public partial class ProductRegistrationChildWindow : ChildWindow
    {
        ProductDS productDomainContext = new ProductDS();
        CategoryDS categoryDomainContext = new CategoryDS();
        UnitofMeasurement selectedUOM = new UnitofMeasurement();
        UnitofMeasurementDS uomDomainContext = new UnitofMeasurementDS();
        bool itHasGotFocus = false;
        int categoryID;
        public ProductRegistrationChildWindow()
        {
           
            try
            {
                if (WebContext.Current.User.IsInRole("Manager") || WebContext.Current.User.IsInRole("Super Admin"))
                {
                    InitializeComponent();
                    //StartTimer();
                    IsFinishedProductCheckBox.IsChecked = false;

                   
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

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {

            Product newProduct = new Product();
            newProduct.Category = categoryID;
            newProduct.ProductName = productNameTextBox.Text;
            newProduct.Product_Description = product_DescriptionTextBox.Text;
            newProduct.ReorderLevel = Convert.ToInt32(reorderLevelTextBox.Text);
            newProduct.SKU = sKUTextBox.Text;
            newProduct.UnitInOrder = Convert.ToInt32(unitInOrderTextBox.Text);
            newProduct.UnitInStock = Convert.ToInt32(unitInStockTextBox.Text);
            newProduct.Uom = selectedUOM.UOMName;
            newProduct.qtyperunit = Convert.ToInt32(qtyperunitTextBox.Text);
            newProduct.PurchasePrice = Convert.ToDecimal(purchasePriceTextBox.Text);
            newProduct.IsFinishedProduct = IsFinishedProductCheckBox.IsChecked;

            productDomainContext.Products.Add(newProduct);
            productDomainContext.SubmitChanges().Completed+=submitChanges_completed;
            
        }

        private void cleantextboxes()
        {
            productNameTextBox.Text="";
            productIDTextBox.Text = "";
            product_DescriptionTextBox.Text="";
            reorderLevelTextBox.Text="0";
            string RandomNumber = Guid.NewGuid().ToString("N");
            sKUTextBox.Text = RandomNumber.Substring(0, 13);

            unitInOrderTextBox.Text="0";
            unitInStockTextBox.Text="0";
            //uomTextBox.Text="";
            qtyperunitTextBox.Text="1";
        }

        private void submitChanges_completed(object sender, EventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void productDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void categoryDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void categoryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Category selectedCat = this.categoryComboBox.SelectedItem as Category;
                //categoryTextBox.Text = selectedCat.CategoryId.ToString();
                categoryID = selectedCat.CategoryId;
            }
            catch (Exception g)
            {
            }
        }

        private void LayoutRoot_GotFocus(object sender, RoutedEventArgs e)
        {
            if (itHasGotFocus == false)
            {
                cleantextboxes();
                itHasGotFocus = true;
            }
        }

        private void newCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            NewCategoryChildWindow categoryCW = new NewCategoryChildWindow();
            categoryCW.Show();
            categoryCW.Closed += categoryCW_Closed;

        }

        void categoryCW_Closed(object sender, EventArgs e)
        {
            try
            {

                EntityQuery<Category> bb = from b in categoryDomainContext.GetCategoriesQuery() select b;
                LoadOperation<Category> res = categoryDomainContext.Load(bb, new Action<LoadOperation<Category>>(loadCategory_completed), true);

            }
            catch (Exception g)
            {
            }
        }

        private void loadCategory_completed(LoadOperation<Category> obj)
        {
            categoryComboBox.ItemsSource = categoryDomainContext.Categories;
        }

        private void unitofMeasurementDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void uOMNameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedUOM = this.uOMNameComboBox.SelectedItem as UnitofMeasurement;

        }

        private void newUOMButton_Click(object sender, RoutedEventArgs e)
        {
            NewUOMChildWindow newUOMCW = new NewUOMChildWindow();
            newUOMCW.Show();
            newUOMCW.Closed += newUOMCW_Closed;
        }

        void newUOMCW_Closed(object sender, EventArgs e)
        {
            loadUOMCombobox();
        }

        private void loadUOMCombobox()
        {

			EntityQuery<UnitofMeasurement> bb = from b in uomDomainContext.GetUnitofMeasurementsQuery() select b;
            LoadOperation<UnitofMeasurement> res = uomDomainContext.Load(bb, new Action<LoadOperation<UnitofMeasurement>>(loadUOMCombobox_Completed), true);
			
        }

        private void loadUOMCombobox_Completed(LoadOperation<UnitofMeasurement> obj)
        {
            uOMNameComboBox.ItemsSource = uomDomainContext.UnitofMeasurements;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}

