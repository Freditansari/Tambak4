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

namespace tambak.Views.Production
{

    /*
     * <summary>
     * bug : BatchDetailDomainContext need to be cleaned first before get into the loop. It causing multiple primary key crash in the database and causing inconsistency on join table. 
     * Solution: cleaned up the batchdetaildomaincontext after each submit changes on BatchConsumptionJoin table submit changes completed. 
     * </summary>
     * 
     */
    public partial class ConsumeMaterialPage : Page
    {
        BatchHeaderDS BatchHeaderDomainContext = new BatchHeaderDS();
        BatchDetailDS BatchDetailDomainContext = new BatchDetailDS();
        PondsDS PondsDomainContext = new PondsDS();
        PondsProductionCycleDS ProductionCycleDomainContext = new PondsProductionCycleDS();
        PondConsumptionLogDS pondsConsumptionLogDomainContext = new PondConsumptionLogDS();
        BatchQuantityViewDS batchQuantityDomainContext = new BatchQuantityViewDS();
        Product selectedProduct = new Product();Pond SelectedPond = new Pond();
        BatchConsumptionJoinDS BatchConsumptionJoinDomainContext = new BatchConsumptionJoinDS();
        tambak.Web.PondsProductionCycle SelectedProductionCycle = new tambak.Web.PondsProductionCycle();
        string CurrentActiveUser = WebContext.Current.User.ToString();
        public batchQuantityView SelectedBatchQuantityView { get; set; }
        PondConsumptionsLog newPondConsumptions = new PondConsumptionsLog();
        BatchDetail newBatchDetail = new BatchDetail();
        BatchConsumptionJoin newBatchConsumptionsJoin = new BatchConsumptionJoin();

        public string ConsumptionBatch { get; set; }


        public ConsumeMaterialPage()
        {
            try
            {
                if (WebContext.Current.User.IsInRole("Technician") || WebContext.Current.User.IsInRole("Field Accounting") || WebContext.Current.User.IsInRole("Super Admin"))
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

        private void SelectProductButton_Click(object sender, RoutedEventArgs e)
        {
            Popups.SelectProducts SelectProductsCW = new Popups.SelectProducts();
            SelectProductsCW.Show();
            SelectProductsCW.Closed += SelectProductsCW_Closed;
        }

        void SelectProductsCW_Closed(object sender, EventArgs e)
        {
            List<Product> SelectedProduct = App.SelectedProduct;
            SelectedProductDataGrid.ItemsSource = SelectedProduct;
        }

        private void pondConsumptionsLogDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void pondDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void SelectedProductDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //todo load batch header and detail 
            selectedProduct = this.SelectedProductDataGrid.SelectedItem as Product;


            uOMTextBox.Text = selectedProduct.Uom;
            batchQuantityDomainContext = new BatchQuantityViewDS();
            try
            {
                EntityQuery<batchQuantityView> bb = from b in batchQuantityDomainContext.GetBatchQuantityViewsQuery() where b.ProductID == selectedProduct.ProductID orderby b.BatchDate select b;
                LoadOperation<batchQuantityView> res = batchQuantityDomainContext.Load(bb, new Action<LoadOperation<batchQuantityView>>(getBatchQuantityView_completed), true);
			    

            }
            catch (Exception g)
            {
                
                
            }
            

        }

       

        private void pondDescriptionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //todo load pond production cycle where isActive = true
            SelectedPond = this.pondDescriptionComboBox.SelectedItem as Pond;
            //SelectedPondID = SelectedPond.PondID;
            
			EntityQuery<tambak.Web.PondsProductionCycle> bb = from b in ProductionCycleDomainContext.GetPondsProductionCyclesQuery() where b.PondID == SelectedPond.PondID && b.isInProduction == true  select b;
            LoadOperation<tambak.Web.PondsProductionCycle> res = ProductionCycleDomainContext.Load(bb, new Action<LoadOperation<tambak.Web.PondsProductionCycle>>(getPondProductionCycle_completed), true);
			
        }

        private void getPondProductionCycle_completed(LoadOperation<tambak.Web.PondsProductionCycle> obj)
        {
            try
            {
                SelectedProductionCycle = obj.Entities.FirstOrDefault();
                productionCycleIDTextBox.Text = SelectedProductionCycle.ProductionCycleID.ToString();
                EnablesTextBoxes();
            }
            catch (Exception g)
            {
                
                
            }
        }

        private void EnablesTextBoxes()
        {
            qtyTextBox.IsReadOnly = false;
            noteTextBox.IsReadOnly = false;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
       
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double IntendedQty = Convert.ToDouble(qtyTextBox.Text);
              
                
                double? sumBatchQty = (from b in batchQuantityDomainContext.batchQuantityViews where b.ProductID == selectedProduct.ProductID select b.Unit_Available).Sum();
                if (IntendedQty > sumBatchQty)
                {
                    throw new ArgumentNullException("Intended quantity: "+IntendedQty.ToString()+ " is more than available quantity: "+sumBatchQty.ToString());
                }
              
                else
                {
              

                    foreach(batchQuantityView CurrentBatchQTYView in batchQuantityDomainContext.batchQuantityViews)
                    {
                        if (IntendedQty >0)
                        {
                            if (CurrentBatchQTYView.Unit_Available >= IntendedQty)
                            {
                                addNewBatchDetail(IntendedQty,CurrentBatchQTYView);
                                IntendedQty = 0;
                            }
                            else
                            {
                                addNewBatchDetail(Convert.ToDouble( CurrentBatchQTYView.Unit_Available),CurrentBatchQTYView);
                                IntendedQty = IntendedQty - Convert.ToDouble(CurrentBatchQTYView.Unit_Available);
                            }
                        }
                        
                    }
                    BatchDetailDomainContext.SubmitChanges().Completed += batchDetailSubmitChanges_completed;
                }
            }
            catch (ArgumentNullException g)
            {
                MessageBox.Show(g.Message);
            }

            

		
        }

        private void addNewBatchDetail(double QuantityIntended, batchQuantityView CurrentBatchQtyView)
        {
            newBatchDetail = new BatchDetail();
            
            newBatchDetail.batchHeaderID  = CurrentBatchQtyView.BatchID;
            newBatchDetail.ProductID = selectedProduct.ProductID;
            newBatchDetail.Quantity = QuantityIntended *-1;
            newBatchDetail.soldPrice = 0;
            newBatchDetail.BuyPrice = CurrentBatchQtyView.unitCost;
            newBatchDetail.ProductionCycleID = SelectedProductionCycle.ProductionCycleID;
            newBatchDetail.isVoid = false;
            newBatchDetail.userName = CurrentActiveUser;

            BatchDetailDomainContext.BatchDetails.Add(newBatchDetail);
            


        }

        private void batchDetailSubmitChanges_completed(object sender, EventArgs e)
        {
            pondsConsumptionLogDomainContext = new PondConsumptionLogDS();
            newPondConsumptions = new PondConsumptionsLog();
            newPondConsumptions.Note = noteTextBox.Text;
            newPondConsumptions.PondID = SelectedPond.PondID;
            newPondConsumptions.ProductGroupID = selectedProduct.Category;
            newPondConsumptions.ProductID = selectedProduct.ProductID;
            newPondConsumptions.ProductionCycleID = SelectedProductionCycle.ProductionCycleID;
            newPondConsumptions.Qty = Convert.ToDouble(qtyTextBox.Text);
            newPondConsumptions.UOM = selectedProduct.Uom;
            newPondConsumptions.userId = WebContext.Current.User.ToString();
            newPondConsumptions.ConsumptionsBatchID = ConsumptionBatch;

            pondsConsumptionLogDomainContext.PondConsumptionsLogs.Add(newPondConsumptions);
            pondsConsumptionLogDomainContext.SubmitChanges().Completed += addPondConsumptionsLog_Completed;
           
         
        }

        void addPondConsumptionsLog_Completed(object sender, EventArgs e)
        {
            //** addded to fix multiple item entry
            BatchConsumptionJoinDomainContext = new BatchConsumptionJoinDS();
            //****
           
          
            foreach (BatchDetail newBatchDetail in BatchDetailDomainContext.BatchDetails)
            {
                newBatchConsumptionsJoin = new BatchConsumptionJoin();
                newBatchConsumptionsJoin.BatchDetailID = newBatchDetail.BatchTrxID;
                newBatchConsumptionsJoin.ConsumptionLogID = newPondConsumptions.LogID;
                BatchConsumptionJoinDomainContext.BatchConsumptionJoins.Add(newBatchConsumptionsJoin);
            }
            BatchConsumptionJoinDomainContext.SubmitChanges().Completed += addBatchConsumptions_completed;
        }

        private void addBatchConsumptions_completed(object sender, EventArgs e)
        {
            //attempt to eliminate bug: clean up all domaincontext
            BatchDetailDomainContext = new BatchDetailDS();
            cleanupTextboxes();
   
        }

        private void cleanupTextboxes()
        {
            qtyTextBox.Text = "0";
            noteTextBox.Text = "";
        }

        private void getBatchQuantityView_completed(LoadOperation<batchQuantityView> obj)
        {
            try
            {
                SelectedBatchQuantityView = obj.Entities.FirstOrDefault();
              
            }
            catch (Exception g)
            {

                throw;
            }
            //batchQtyDataGrid.ItemsSource = batchQuantityDomainContext.batchQuantityViews;

        }

        private void newBatchButton_Click(object sender, RoutedEventArgs e)
        {
            ConsumptionBatch = Guid.NewGuid().ToString("N");
            SaveButton.IsEnabled = true;
        }









      
    }
}
