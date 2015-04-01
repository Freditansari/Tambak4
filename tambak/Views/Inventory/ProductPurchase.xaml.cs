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
    //todo URGENT: CHECK FOR PRODUCT QUANTITY INSERT AFTER PURCHASE LOG ENTERED TO DATABASE!!!
    /*
     * todo: create PO 
     * todo : Create PO prints
     * 
      * */
    public partial class ProductPurchase : UserControl
    {
        ProductPurchaseLogDS purchaseDC = new ProductPurchaseLogDS();
        ProductQuantityDS productQuantityDomainContext = new ProductQuantityDS();
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


        public ProductPurchase()
        {
            try
            {
                if (WebContext.Current.User.IsInRole("Manager") || WebContext.Current.User.IsInRole("Super Admin"))
                {
                    InitializeComponent();
                    loadPurchaseLog();
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

        private void loadPurchaseLog()
        {
            EntityQuery<ProductPurchaseLog> bb = from b in purchaseDC.GetProductPurchaseLogsQuery() select b;
            LoadOperation<ProductPurchaseLog> res = purchaseDC.Load(bb, new Action<LoadOperation<ProductPurchaseLog>>(getpurchaseLogCompleted), true);
        }

        private void getpurchaseLogCompleted(LoadOperation<ProductPurchaseLog> obj)
        {
            productPurchaseLogRadGridView.ItemsSource = purchaseDC.ProductPurchaseLogs;
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

        }

        private void productPurchaseLogDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            ProductPurchaseLog newProductPurchaseLog = new ProductPurchaseLog();
            newProductPurchaseLog.Currency = currencyTextBox.Text;
            newProductPurchaseLog.Date = dateDatePicker.SelectedDate;
            newProductPurchaseLog.ExpireDate = expireDateDatePicker.SelectedDate;
            newProductPurchaseLog.PurchasePrice =Convert.ToDecimal( purchasePriceTextBox.Text);
            newProductPurchaseLog.Quantity = Convert.ToInt32(quantityTextBox.Text);
            newProductPurchaseLog.Requester = requesterTextBox.Text;
            newProductPurchaseLog.Shipping =Convert.ToDecimal( shippingTextBox.Text);
            newProductPurchaseLog.Total = Convert.ToDecimal(totalTextBox.Text);
            newProductPurchaseLog.batchID = batchIDTextBox.Text;
            newProductPurchaseLog.location = locationTextBox.Text;
            newProductPurchaseLog.tax = Convert.ToDecimal(taxTextBox.Text);
            newProductPurchaseLog.userID = WebContext.Current.User.ToString();
            newProductPurchaseLog.ProductID = Convert.ToInt32(productIDTextBox.Text);

            purchaseDC.ProductPurchaseLogs.Add(newProductPurchaseLog);
            purchaseDC.SubmitChanges().Completed += PurchaseLogInsertCompleted;
            //purchaseDC.SubmitChanges();
            //todo save purchase orders
        }

        private void PurchaseLogInsertCompleted(object sender, EventArgs e)
        {
            purchaseDC = new ProductPurchaseLogDS();
            loadPurchaseLog();
        }

        private void productQuantityDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void productPurchaseLogRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            try
            {
                ProductPurchaseLog selectedItem = this.productPurchaseLogRadGridView.SelectedItem as ProductPurchaseLog;
                purchaseLogIDTextBox1.Text = selectedItem.PurchaseLogID.ToString();
                quantityTextBox1.Text = selectedItem.Quantity.ToString();
                expireDateDatePicker1.SelectedDate = selectedItem.ExpireDate;
                locationTextBox1.Text = selectedItem.location.ToString();
                productIDTextBox1.Text = selectedItem.ProductID.ToString();

            }
            catch (NullReferenceException g)
            {
                
                
            }
           
        }

        private void SaveProductInventoryButton_Click(object sender, RoutedEventArgs e)
        {
          // new inventory procedures
            // update if the isDeliveryComplete checkbox is checked. 
            if (IsDeliveryComplete.IsChecked == true)
            {
                updateProductPurchaseLog();
                NewInventory();
            }
            else
            {
                NewInventory();
            }


        }

        private void updateProductPurchaseLog()
        {
            EntityQuery<ProductPurchaseLog> bb = from b in purchaseDC.GetProductPurchaseLogsQuery() where b.PurchaseLogID ==Convert.ToInt32( purchaseLogIDTextBox1.Text) select b;
            LoadOperation<ProductPurchaseLog> res = purchaseDC.Load(bb, new Action<LoadOperation<ProductPurchaseLog>>(updatePurchaseLog), true);
        }

        private void updatePurchaseLog(LoadOperation<ProductPurchaseLog> obj)
        {
            ProductPurchaseLog bc = obj.Entities.First();
            bc.isDelivered = true;
            purchaseDC.SubmitChanges();
        }

        private void NewInventory()
        {
            ProductQuantity newProductQuantity = new ProductQuantity();
            newProductQuantity.ProductID = Convert.ToInt32(productIDTextBox1.Text);
            newProductQuantity.ContainerID = containerIDTextBox.Text;
            newProductQuantity.Location = locationTextBox1.Text;
            newProductQuantity.Quantity = Convert.ToInt32(quantityTextBox1.Text);
            newProductQuantity.PurchaseLogID = Convert.ToInt32(purchaseLogIDTextBox1.Text);
            newProductQuantity.expireDate = expireDateDatePicker1.SelectedDate;
            newProductQuantity.userID = WebContext.Current.User.ToString();
            newProductQuantity.trxDate = Convert.ToDateTime (ServerTimeTextBlock.Text);

            productQuantityDomainContext.ProductQuantities.Add(newProductQuantity);
            productQuantityDomainContext.SubmitChanges();
        }
    }
}
