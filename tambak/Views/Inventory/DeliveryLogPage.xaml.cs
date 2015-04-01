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
using System.ServiceModel.DomainServices.Client;
using tambak.Web;
using tambak.Web.DomainServices;

namespace tambak.Views.Inventory
{
    public partial class DeliveryLogPage : Page
    {
        PurchaseOrderHeaderDS POHeaderDomainContext = new PurchaseOrderHeaderDS();
        PODetailsViewsDS PODetailsViewDomainContext = new PODetailsViewsDS();
        DeliveryLogDS DeliveryLogDomainContext = new DeliveryLogDS();
        PurchaseOrder selectedPOheader = new PurchaseOrder();
        PODetailsView selectedPODetails;
        BatchHeaderDS batchheaderDomainContext = new BatchHeaderDS();
        string DeliveryLogID;
        BatchHeader newBatchHeader;
        BatchDetailDS BatchDetailDomainContext = new BatchDetailDS();
        public BatchDetail newBatchDetail { get; set; }
        String deliveryBatchID  = Guid.NewGuid().ToString("N");
        public DeliveryLog SelectedDeliveryLog { get; set; }

        PODeliveredQuantityDS poqtyDomainContex = new PODeliveredQuantityDS();
       
        public DeliveryLogPage()
        {
            try
            {
                if (WebContext.Current.User.IsInRole("Manager") || WebContext.Current.User.IsInRole("Field Accounting") || WebContext.Current.User.IsInRole("Super Admin"))
                {

                    InitializeComponent();
                    Loaded += DeliveryLogPage_Loaded;
                    deliveryBatchTextBox.Text = deliveryBatchID;

                    DeliveryReceiptReportViewer.RenderBegin += DeliveryReceiptReportViewer_RenderBegin;
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

        void DeliveryReceiptReportViewer_RenderBegin(object sender, Telerik.ReportViewer.Silverlight.RenderBeginEventArgs args)
        {
            try
            {
                if (SelectedDeliveryLog.DeliveryBatch.Length <= 0)
                {
                    deliveryLogDataGrid.SelectedIndex = 0;
                }
                else
                {
                    args.ParameterValues["DeliveryBatchParameter"] = SelectedDeliveryLog.DeliveryBatch;
                }
            }
            catch (Exception g)
            {
            }
        }

        void DeliveryLogPage_Loaded(object sender, RoutedEventArgs e)
        {
            //loadComboBoxData();
            FieldSelectionCombobox.ItemsSource = loadComboBoxData();
           
           
        }

        private string[] loadComboBoxData()
        {
            string[] strArray =
                {
                   "POReference",
                   "POID",
                   "Due Date"
                };
            return strArray;
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void pODetailsViewDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void purchaseOrderDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                POHeaderDomainContext = new PurchaseOrderHeaderDS();
                string selectedField = FieldSelectionCombobox.SelectedItem.ToString();
                if (selectedField == "POID")
                {

			        EntityQuery<PurchaseOrder> bb = from b in POHeaderDomainContext.GetPurchaseOrdersQuery() where b.POID.Contains(SearchTextBox.Text) select b;
                    LoadOperation<PurchaseOrder> res = POHeaderDomainContext.Load(bb, new Action<LoadOperation<PurchaseOrder>>(loadPOID_completed), true);
			
                }
                else if (selectedField == "POReference")
                {
                    EntityQuery<PurchaseOrder> bb = from b in POHeaderDomainContext.GetPurchaseOrdersQuery() where b.POReference.Contains( SearchTextBox.Text) select b;
                    LoadOperation<PurchaseOrder> res = POHeaderDomainContext.Load(bb, new Action<LoadOperation<PurchaseOrder>>(loadPOID_completed), true);
			
                }
                else if (selectedField == "Due Date")
                {
                    EntityQuery<PurchaseOrder> bb = from b in POHeaderDomainContext.GetPurchaseOrdersQuery() where b.DueDate== Convert.ToDateTime(SearchTextBox.Text) select b;
                    LoadOperation<PurchaseOrder> res = POHeaderDomainContext.Load(bb, new Action<LoadOperation<PurchaseOrder>>(loadPOID_completed), true);
			
                }
                 
            }
            catch (Exception g)
            {
                
                
            }
        }

        private void loadPOID_completed(LoadOperation<PurchaseOrder> obj)
        {
            purchaseOrderDataGrid.ItemsSource = POHeaderDomainContext.PurchaseOrders;
        }

        private void supplierDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void companyNameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            POHeaderDomainContext = new PurchaseOrderHeaderDS();
            Supplier selectedSupplier = this.companyNameComboBox.SelectedItem as Supplier;
            EntityQuery<PurchaseOrder> bb = from b in POHeaderDomainContext.GetPurchaseOrdersQuery() where b.VendorID == selectedSupplier.SupplierID && b.isComplete == false select b;
            LoadOperation<PurchaseOrder> res = POHeaderDomainContext.Load(bb, new Action<LoadOperation<PurchaseOrder>>(loadPOID_completed), true);
			
        }

        private void purchaseOrderDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedPOheader = this.purchaseOrderDataGrid.SelectedItem as PurchaseOrder;
            deliveryBatchTextBox.Text = Guid.NewGuid().ToString("N");
            DeliveryLogTabItem.IsEnabled = true;
            try
            {
                PODetailsViewDomainContext = new PODetailsViewsDS();
                EntityQuery<PODetailsView> bb = from b in PODetailsViewDomainContext.GetPODetailsViewsQuery() where b.POID == selectedPOheader.POID select b;
                LoadOperation<PODetailsView> res = PODetailsViewDomainContext.Load(bb, new Action<LoadOperation<PODetailsView>>(getPoDetail_Completed), true);
              
            }
            catch (Exception g)
            {
            }
			
        }

        private void getPoDetail_Completed(LoadOperation<PODetailsView> obj)
        {
            pODetailsViewDataGrid.ItemsSource = PODetailsViewDomainContext.PODetailsViews;
            pODetailsViewDataGrid.SelectedIndex = 0;
        }

        private void deliveryLogDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void pODetailsViewDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (deliveryBatchTextBox.Text.Length <= 1)
            {
                deliveryBatchTextBox.Text = Guid.NewGuid().ToString("N");
            }
            
            try
            {
                selectedPODetails = this.pODetailsViewDataGrid.SelectedItem as PODetailsView;
                DeliveryLogDomainContext = new DeliveryLogDS();
			    EntityQuery<DeliveryLog> bb = from b in DeliveryLogDomainContext.GetDeliveryLogsQuery() where b.PODetailsID == selectedPODetails.PODetailsID select b;
                LoadOperation<DeliveryLog> res = DeliveryLogDomainContext.Load(bb, new Action<LoadOperation<DeliveryLog>>(GetDeliveryLog_Completed), true);
			
            }
            catch (Exception g)
            {
            }

        }
      

        private void GetDeliveryLog_Completed(LoadOperation<DeliveryLog> obj)
        {
            deliveryLogDataGrid.ItemsSource = DeliveryLogDomainContext.DeliveryLogs;

             //POHeaderTaxRate = Convert.ToDecimal( (from b in SelectedList select b.TaxRate).Sum());

            double DeliveredQuantity = (from b in DeliveryLogDomainContext.DeliveryLogs select b.qtyReceived).Sum();

            qtyReceivedTextBox.Text =Convert.ToString( Convert.ToDouble( selectedPODetails.qty) - DeliveredQuantity);
            pODetailsIDTextBox.Text = selectedPODetails.PODetailsID.ToString();
            productIDTextBox.Text = selectedPODetails.ProductID.ToString();
            userIDTextBox.Text = WebContext.Current.User.ToString();

        }

        private void deliveryLogDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedDeliveryLog = this.deliveryLogDataGrid.SelectedItem as DeliveryLog;
            this.DeliveryReceiptReportViewer.ReportServiceUri = new Uri("../ReportService.svc", UriKind.RelativeOrAbsolute);
        }

        private void addToDeliveryButton_Click(object sender, RoutedEventArgs e)
        {
            if (deliveryBatchTextBox.Text.Length <= 1)
            {
                deliveryBatchTextBox.Text = Guid.NewGuid().ToString("N");
            }
            
            //todo check on total po quantity vs the delivery log quantity and press the check if it's completed. 
            try
            {
                DeliveryLog newDeliveryLog = new DeliveryLog();
                newDeliveryLog.DeliveryLogID = Guid.NewGuid().ToString("N");
                DeliveryLogID = newDeliveryLog.DeliveryLogID;
                newDeliveryLog.DeliveryNote = deliveryNoteTextBox.Text;
                newDeliveryLog.Location = deliveryNoteTextBox.Text;
                newDeliveryLog.PODetailsID = selectedPODetails.PODetailsID;
                newDeliveryLog.ProductID = Convert.ToInt32( selectedPODetails.ProductID);
                newDeliveryLog.UserID = WebContext.Current.User.ToString();
                newDeliveryLog.qtyReceived = Convert.ToDouble(qtyReceivedTextBox.Text);
                newDeliveryLog.DeliveryBatch = deliveryBatchTextBox.Text;

                DeliveryLogDomainContext.DeliveryLogs.Add(newDeliveryLog);
                DeliveryLogDomainContext.SubmitChanges().Completed += addDeliveryLog_completed;
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }

        private void addDeliveryLog_completed(object sender, EventArgs e)
        {
            newBatchHeader = new BatchHeader();
            newBatchHeader.ProductID = Convert.ToInt32(selectedPODetails.ProductID);
            newBatchHeader.unitCost = Convert.ToDouble(selectedPODetails.ConvertedUnitPrice);
            newBatchHeader.ExpireDate = ExpireDateDatePicker.SelectedDate;
            newBatchHeader.Location = locationTextBox.Text;
            newBatchHeader.FacilitiesID = selectedPOheader.ShipTo;
            newBatchHeader.DeliveryLogID = DeliveryLogID;
            newBatchHeader.PODetailID = selectedPODetails.PODetailsID;

            batchheaderDomainContext.BatchHeaders.Add(newBatchHeader);
            batchheaderDomainContext.SubmitChanges().Completed += batchHeaderInsert_Completed;
            

        }

        private void batchHeaderInsert_Completed(object sender, EventArgs e)
        {
            newBatchDetail = new BatchDetail();
            newBatchDetail.ProductID = selectedPODetails.ProductID;
            //newBatchDetail.TrxDate = newBatchHeader.BatchDate;
            newBatchDetail.Quantity = Convert.ToDouble( qtyReceivedTextBox.Text);
            newBatchDetail.soldPrice = 0;
            newBatchDetail.BuyPrice = Convert.ToDouble( selectedPODetails.ConvertedUnitPrice);
            newBatchDetail.batchHeaderID = newBatchHeader.BatchID;
            newBatchDetail.isVoid = false;
            newBatchDetail.userName = WebContext.Current.User.ToString();

            BatchDetailDomainContext.BatchDetails.Add(newBatchDetail);
            BatchDetailDomainContext.SubmitChanges().Completed += batchdetailInsert_Completed;
        }

        private void batchdetailInsert_Completed(object sender, EventArgs e)
        {
           //todo cleanup 
            //double DeliveredQuantity = (from b in DeliveryLogDomainContext.DeliveryLogs select b.qtyReceived).Sum();


            //EntityQuery<PODeliveredQuantity> bb = from b in .GetPODeliveredQtiesQuery() where b.POID == selectedPOheader.POID select b;
            //LoadOperation<PODeliveredQty> res = PODeliveredQtyDomainContext.Load(bb, new Action<LoadOperation<PODeliveredQty>>(loadPODeliveredQty_completed), true);

            poqtyDomainContex = new PODeliveredQuantityDS();

            EntityQuery<PODeliveredQuantity> bb = from b in poqtyDomainContex.GetPODeliveredQuantitiesQuery() where b.POID == selectedPOheader.POID select b;
            LoadOperation<PODeliveredQuantity> res = poqtyDomainContex.Load(bb, new Action<LoadOperation<PODeliveredQuantity>>(loadPODeliveredQty_completed), true);
			

         
            
        }

        private void loadPODeliveredQty_completed(LoadOperation<PODeliveredQuantity> obj)
        {
            Boolean isAllFullFilled = true;

            foreach (PODetailsView item in PODetailsViewDomainContext.PODetailsViews)
            {
                //double DeliveredQuantity = (from b in DeliveryLogDomainContext.DeliveryLogs where b.ProductID == item.ProductID && b.PODetailsID == item.PODetailsID select b.qtyReceived).Sum();
                double? DeliveredQuantity = (from b in poqtyDomainContex.PODeliveredQuantities where b.PODetailsID == item.PODetailsID select b.qtyReceived).Sum();
                System.Diagnostics.Debug.WriteLine(DeliveredQuantity.ToString() + " " + item.ProductID.ToString()+ " "+ item.PODetailsID);
                if (DeliveredQuantity < Convert.ToDouble(item.qty))
                {
                    isAllFullFilled = false;
                }

            }

            if (isAllFullFilled == true)
            {
                selectedPOheader.isComplete = true;
                POHeaderDomainContext.SubmitChanges().Completed += updatePOHeaderCompleted;
            }
            cleanUpMethod();
        }

        private void updatePOHeaderCompleted(object sender, EventArgs e)
        {
            //todo load data after save purchaseOrderDomainDataSource.Load();

            
        }

        private void cleanUpMethod()
        {
            Double sumDeliveredQty= (from b in DeliveryLogDomainContext.DeliveryLogs where b.ProductID == selectedPODetails.ProductID && b.PODetailsID == selectedPODetails.PODetailsID select b.qtyReceived).Sum();
            qtyReceivedTextBox.Text = Convert.ToString(Convert.ToDouble(selectedPODetails.qty) - sumDeliveredQty);
            ExpireDateDatePicker.SelectedDate = null;
        }










      
    }
}
