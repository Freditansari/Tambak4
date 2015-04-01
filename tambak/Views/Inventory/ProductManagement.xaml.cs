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
/**
 *
 * todo : add edit product page. 
 * todo : add label printing page.
 * todo : add view each pond and production cycle consumptions page. 
 * 
 */

namespace tambak.Views.Inventory
{
    public partial class ProductManagement : Page
    {
        ProductsDetailsDS prodDetailsDomainContext = new ProductsDetailsDS();
        public ProductManagement()
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

            catch (ArgumentException g)
            {
                MessageBox.Show(g.Message);

            }
           
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void productDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void productIDTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Todo change Product Details along with the product id. 
            prodDetailsDomainContext = new ProductsDetailsDS();
            EntityQuery<ProductsDetail> bb = from b in prodDetailsDomainContext.GetProductsDetailsQuery() where b.ProductID ==Convert.ToInt32( productIDTextBox.Text) select b;
            LoadOperation<ProductsDetail> res = prodDetailsDomainContext.Load(bb, new Action<LoadOperation<ProductsDetail>>(getProdDetailsCompleted), true);
        }

        private void getProdDetailsCompleted(LoadOperation<ProductsDetail> obj)
        {
            productsDetailRadGridView.ItemsSource = prodDetailsDomainContext.ProductsDetails;

            SumOfReceivedTextbox.Text = prodDetailsDomainContext.ProductsDetails.Sum(b => b.received).ToString();
            SumofSoldTextBox.Text = prodDetailsDomainContext.ProductsDetails.Sum(b => b.sold).ToString();
            SumOfShrinkageTextbox.Text = prodDetailsDomainContext.ProductsDetails.Sum(b => b.shrinkage).ToString();
            UnitinHandsTextBox.Text = Convert.ToString(Convert.ToInt32(SumOfReceivedTextbox.Text) - (Convert.ToInt32(SumofSoldTextBox.Text) + Convert.ToInt32(SumOfShrinkageTextbox.Text)));

        }

        private void productsDetailDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
                
            }
        }

    }
}
