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

namespace tambak.Views.Popups
{
    public partial class SelectProducts : ChildWindow
    {
        
        ProductDS productDomainContext = new ProductDS();
        ProductDS SelectedProductDomainContext = new ProductDS();
        List<Product> SelectedProductList = new List<Product>();
      
        
        public SelectProducts()
        {
            InitializeComponent();
            Loaded += SelectProducts_Loaded;
            //App.GlobalProductDomainContext = new ProductDS();
            

        }

        void SelectProducts_Loaded(object sender, RoutedEventArgs e)
        {
            SearchComboBox.ItemsSource = loadComboBoxData();
        }

        private string[] loadComboBoxData()
        {
            string[] strArray =
                {
                   "ProductID:",
                   "SKU:",
                   "Name:"
                };
            return strArray;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            App.SelectedProduct = SelectedProductList;

            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            App.SelectedProduct = null;
            this.DialogResult = false;
        }

        private void productDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedSearchParameter = this.SearchComboBox.SelectedItem as string;
            productDomainContext = new ProductDS();
            try
            {
          
                if (selectedSearchParameter == "ProductID:")
                {

			        EntityQuery<Product> bb = from b in productDomainContext.GetProductsQuery() where b.ProductID == Convert.ToInt32( SearchKeyTextBox.Text) select b;
                    LoadOperation<Product> res = productDomainContext.Load(bb, new Action<LoadOperation<Product>>(loadProduct_Completed), true);
			
                }
                else if (selectedSearchParameter == "SKU:")
                {
                    EntityQuery<Product> bb = from b in productDomainContext.GetProductsQuery() where b.SKU == SearchKeyTextBox.Text select b;
                    LoadOperation<Product> res = productDomainContext.Load(bb, new Action<LoadOperation<Product>>(loadProduct_Completed), true);
                }
                else if (selectedSearchParameter == "Name:")
                {
                    EntityQuery<Product> bb = from b in productDomainContext.GetProductsQuery() where b.ProductName.Contains( SearchKeyTextBox.Text) select b;
                    LoadOperation<Product> res = productDomainContext.Load(bb, new Action<LoadOperation<Product>>(loadProduct_Completed), true);
                }

            }
            catch (Exception g)
            {
            }
        }

        private void loadProduct_Completed(LoadOperation<Product> obj)
        {
            productDataGrid.ItemsSource = productDomainContext.Products;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Product ProductCandidate = new Product();
            ProductCandidate = this.productDataGrid.SelectedItem as Product;

            var result = from b in SelectedProductList where b.ProductID == ProductCandidate.ProductID select b;
            int resultCount = result.Count();

            //validation
            if (resultCount == 0)
            {
                SelectedProductList.Add(ProductCandidate);
                SelectedDatagrid.ItemsSource = SelectedProductList.ToList();
    
            }
            
            
            
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            Product RemovalCandidate = this.SelectedDatagrid.SelectedItem as Product;
          

            SelectedProductList.Remove(RemovalCandidate);
            SelectedDatagrid.ItemsSource = SelectedProductList.ToList();

            


        }
    }
}

