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
using tambak.Web.DomainServices;
using tambak.Web;
using System.ServiceModel.DomainServices.Client;
/**
 * todo: remove time from this module*
 * todo: add random number as sku *
 * todo: add label printing. 
 * 
 **/
namespace tambak.Views.Inventory
{
    public partial class ProductRegistration : Page
    {
        ProductDS productDomainContext = new ProductDS();
        ProductInfoViewDS productInfoDomainContext = new ProductInfoViewDS();

        getServerTimeReference.GetServerTimeClient newServertimeClient = new getServerTimeReference.GetServerTimeClient();

        public void StartTimer()
        {
            System.Windows.Threading.DispatcherTimer myDispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            myDispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 100); // 100 Milliseconds 
            myDispatcherTimer.Tick += new EventHandler(Each_Tick);
            myDispatcherTimer.Start();
        }
        public void Each_Tick(object o, EventArgs sender)
        {
            getserverTime();
        }
        private void getserverTime()
        {
            newServertimeClient.getServerTimeAsync();
            newServertimeClient.getServerTimeCompleted += getTimeCompleted;
        }

        private void getTimeCompleted(object sender, getServerTimeReference.getServerTimeCompletedEventArgs e)
        {
            //ServerTimeTextBlock.Text = e.Result.ToString();
        }

        public ProductRegistration()
        {
            try
            {
                if (WebContext.Current.User.IsInRole("Manager") || WebContext.Current.User.IsInRole("Super Admin"))
                {
                    InitializeComponent();
                    //StartTimer();
                    string RandomNumber = Guid.NewGuid().ToString("N");
                    //sKUTextBox.Text = RandomNumber.Substring(0, 13);
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

        private void SaveNewProductButton_Click(object sender, RoutedEventArgs e)
        {
            //todo put filters here. 
            saveNewProduct();
        }

        private void saveNewProduct()
        {

            //Product newProduct = new Product();
            //newProduct.ProductName = productNameTextBox.Text;
            //newProduct.Product_Description = product_DescriptionTextBox.Text;
            //newProduct.ReorderLevel = Convert.ToInt32(reorderLevelTextBox.Text);
            //newProduct.SKU = sKUTextBox.Text;
            //newProduct.UnitInOrder = Convert.ToInt32(unitInOrderTextBox.Text);
            //newProduct.UnitInStock = Convert.ToInt32(unitInStockTextBox.Text);
            //newProduct.Uom = uomTextBox.Text;
            //newProduct.qtyperunit = Convert.ToInt32(qtyperunitTextBox.Text);

            //productDomainContext.Products.Add(newProduct);
            //productDomainContext.SubmitChanges();
        }

        private void productsInfoViewDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void newProductButton_Click(object sender, RoutedEventArgs e)
        {
            ProductRegistrationChildWindow productRegCW = new ProductRegistrationChildWindow();
            productRegCW.Show();
            productRegCW.Closed += productRegCW_Closed;
        }

        void productRegCW_Closed(object sender, EventArgs e)
        {
            loadproductInfoViewRadGrid();
        }

        private void loadproductInfoViewRadGrid()
        {
                
            EntityQuery<ProductsInfoView> bb = from b in productInfoDomainContext.GetProductsInfoViewsQuery() select b;
            LoadOperation<ProductsInfoView> res = productInfoDomainContext.Load(bb, new Action<LoadOperation<ProductsInfoView>>(loadproductInfoViewRadGrid_completed), true);
		    	
        }

        private void loadproductInfoViewRadGrid_completed(LoadOperation<ProductsInfoView> obj)
        {
            productsInfoViewRadGridView.ItemsSource = productInfoDomainContext.ProductsInfoViews;
        }

    }
}
