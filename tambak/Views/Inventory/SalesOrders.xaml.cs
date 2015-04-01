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

namespace tambak.Views.Inventory
{
    public partial class SalesOrders : Page
    {
        ProductSalesOrdersDS productSalesOrderDomainContext = new ProductSalesOrdersDS();
        ProductRequiredDS productRequiredDomainContext = new ProductRequiredDS();
        ProductQuantityDS productqtyDomainContext = new ProductQuantityDS();

        ProductDS ProductDomainContext = new ProductDS();
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
           ServerTimeTextBlock.Text = e.Result.ToString();
       }
      
        public SalesOrders()
        {
            try
            {
                if (WebContext.Current.User.IsInRole("Manager") || WebContext.Current.User.IsInRole("Super Admin"))
                {
                    InitializeComponent();
                    StartTimer();

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

        private void taskDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void productRequiredDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void contactDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void productSalesOrderDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void taskRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            //load required products
            try
            {
                productRequiredDomainContext = new ProductRequiredDS();
                Task selectedTask = this.taskRadGridView.SelectedItem as Task;
                EntityQuery<ProductRequired> bb = from b in productRequiredDomainContext.GetProductRequiredsQuery() where b.TaskID == selectedTask.TaskID select b;
                LoadOperation<ProductRequired> res = productRequiredDomainContext.Load(bb, new Action<LoadOperation<ProductRequired>>(getProductRequiredCompleted), true);
            }
            catch (NullReferenceException g)
            {
                
                
            }

        }

        private void getProductRequiredCompleted(LoadOperation<ProductRequired> obj)
        {
            //load required products
            productRequiredRadGridView.ItemsSource = productRequiredDomainContext.ProductRequireds;
            try
            {
                //todo put selected items in the sales order form
                ProductRequired selectedProductRequirement = this.productRequiredRadGridView.SelectedItem as ProductRequired;
                productIDTextBox.Text = selectedProductRequirement.ProductID.ToString();
                qTYTextBox.Text = selectedProductRequirement.Amount.ToString();
                requirementIDTextBox.Text = selectedProductRequirement.RequirementID.ToString();
            }
            catch (NullReferenceException g)
            {


            }
        }

        private void productRequiredRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            try
            {
                //todo put selected items in the sales order form
                ProductRequired selectedProductRequirement = this.productRequiredRadGridView.SelectedItem as ProductRequired;
                productIDTextBox.Text = selectedProductRequirement.ProductID.ToString();
                qTYTextBox.Text = selectedProductRequirement.Amount.ToString();
                requirementIDTextBox.Text = selectedProductRequirement.RequirementID.ToString();
                taskIDTextBox.Text = selectedProductRequirement.TaskID.ToString();

                loadRelatedProducts();

            }
            catch (NullReferenceException g)
            {
                
                
            }
           

        }

        private void contactRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            try
            {
                //put contact in the sales order form
                Contact selectedContact = this.contactRadGridView.SelectedItem as Contact;
                userPickedTextBox.Text = selectedContact.ContactID.ToString();
                userPickedNameTextBox.Text = selectedContact.FirstName.ToString() + ", " + selectedContact.LastName.ToString();

            }
            catch (NullReferenceException g)
            {
                
                throw;
            }
            
        }

        private void productIDTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //todo show product related when text changed.
            if (productIDTextBox.Text.Length !=0)
            {
            
            }
            
            
        }

        private void loadRelatedProducts()
        {
            ProductDomainContext = new ProductDS();
            EntityQuery<Product> bb = from b in ProductDomainContext.GetProductsQuery() where b.ProductID == Convert.ToInt32(productIDTextBox.Text) select b;
            LoadOperation<Product> res = ProductDomainContext.Load(bb, new Action<LoadOperation<Product>>(getProductsCompleted), true);
   
        }

        private void getProductsCompleted(LoadOperation<Product> obj)
        {
            productRadGridView.ItemsSource = ProductDomainContext.Products;
        }

        private void qTYTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // multiply with price textbox to get total. 
            countTotalTextBox();
            

        }

        private void countTotalTextBox()
        {
            try
            {
                totalTextBox.Text = Convert.ToString(Convert.ToDecimal(priceTextBox.Text) * Convert.ToDecimal(qTYTextBox.Text));
            }
            catch (FormatException g)
            {
                    //todo debugging point. delete after use
                MessageBox.Show(g.Message);

            }
            catch (ArgumentNullException g)
            {
                //todo debugging point. delete after use
                MessageBox.Show(g.Message);

            }
        }

        private void productDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void productRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            loadProductInventory();
        }

        private void requirementIDTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            countTotalTextBox();
        }

        private void SaveSalesOrderButton_Click(object sender, RoutedEventArgs e)
        {
            //filters for sales order.
            try
            {
                if (priceTextBox.Text.Length == 0)
                {
                    throw new ArgumentException("Price cannot be null");
                }
                else if (productIDTextBox.Text.Length == 0)
                {
                    throw new ArgumentException("Product ID cannot be null");
                }else if(requirementIDTextBox.Text.Length== 0 )
                {
                    throw new ArgumentException("requirement ID cannot be null");
                }else if (taskIDTextBox.Text.Length == 0)
                {
                    throw new ArgumentException("Task ID cannot be null");
                }
                else if (userPickedTextBox.Text.Length == 0)
                {
                    throw new ArgumentException("User Picked id Cannot be null");
                }
                else if (totalTextBox.Text.Length == 0)
                {
                    throw new ArgumentException("Total Cannot be Null");
                }
                else
                {
                    saveSalesOrders();
                }
            }
            catch (ArgumentException g)
            {

                MessageBox.Show(g.Message);
            }
            
        }
        private void saveSalesOrders()
        {

            
            productSalesOrderDomainContext = new ProductSalesOrdersDS();
            ProductSalesOrder newProductSalesOrder = new ProductSalesOrder();
            newProductSalesOrder.Price =Convert.ToDecimal( priceTextBox.Text);
            newProductSalesOrder.ProductID = Convert.ToInt32(productIDTextBox.Text);
            newProductSalesOrder.QTY = Convert.ToDecimal(qTYTextBox.Text);
            newProductSalesOrder.RequirementID = Convert.ToInt32(requirementIDTextBox.Text);
            newProductSalesOrder.TaskID = Convert.ToInt32(taskIDTextBox.Text);
            newProductSalesOrder.UserID = WebContext.Current.User.ToString();
            newProductSalesOrder.UserPicked = Convert.ToInt32(userPickedTextBox.Text);
            newProductSalesOrder.total = Convert.ToDecimal(totalTextBox.Text);
            newProductSalesOrder.trxDate =Convert.ToDateTime( ServerTimeTextBlock.Text);
            newProductSalesOrder.userPickedName = userPickedNameTextBox.Text;
            newProductSalesOrder.LotNumber = Convert.ToInt32(lotNumberTextBox.Text);

            productSalesOrderDomainContext.ProductSalesOrders.Add(newProductSalesOrder);
            productSalesOrderDomainContext.SubmitChanges().Completed += salesOrderCompleted;
        }

        private void salesOrderCompleted(object sender, EventArgs e)
        {
            ReduceInventory();
        }

        private void loadProductInventory()
        {
            productqtyDomainContext = new ProductQuantityDS();
            EntityQuery<ProductQuantity> bb = from b in productqtyDomainContext.GetProductQuantitiesQuery() where b.ProductID == Convert.ToInt32(productIDTextBox.Text) select b;
            LoadOperation<ProductQuantity> res = productqtyDomainContext.Load(bb, new Action<LoadOperation<ProductQuantity>>(productQTYLoadCompleted), true);
			
        }

        private void productQTYLoadCompleted(LoadOperation<ProductQuantity> obj)
        {
            productQuantityRadGridView.ItemsSource = productqtyDomainContext.ProductQuantities;
        }


        private void ReduceInventory()
        {
            productqtyDomainContext = new ProductQuantityDS();
            EntityQuery<ProductQuantity> bb = from b in productqtyDomainContext.GetProductQuantitiesQuery() where b.ProductID ==Convert.ToInt32( productIDTextBox.Text) select b;
            LoadOperation<ProductQuantity> res = productqtyDomainContext.Load(bb, new Action<LoadOperation<ProductQuantity>>(productQtySearchComplete), true);
			
        }

        private void productQtySearchComplete(LoadOperation<ProductQuantity> obj)
        {
            ProductQuantity bc = obj.Entities.First();
            decimal qty = Convert.ToDecimal(qTYTextBox.Text);
            int intQTY = (int)qty;

            bc.Quantity = bc.Quantity - intQTY;
            productqtyDomainContext.SubmitChanges();

        }

        private void productQuantityDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void productQuantityRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            ProductQuantity selectedProductLot = this.productQuantityRadGridView.SelectedItem as ProductQuantity;
            lotNumberTextBox.Text = selectedProductLot.LotNumber.ToString();
        }

    }
}
