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
    public partial class NewFeedingLogChildWindows : ChildWindow
    {
        FeedingLogsDS feedinglogDomainContext = new FeedingLogsDS();
        PondsProductionCycleDS productionCycleDomainContext = new PondsProductionCycleDS();
        ProductDS ProductsDomainContext = new ProductDS();

        DateTime logDate;

        FeedingLog feedinglogLists = new FeedingLog();

        runCmdShellServiceReference.RunCmdShellClient runCmdShellClient = new runCmdShellServiceReference.RunCmdShellClient();

        public NewFeedingLogChildWindows()
        {
            InitializeComponent();

            Loaded += NewFeedingLogChildWindows_Loaded; 
           
        }

        private void NewFeedingLogChildWindows_Loaded(object sender, RoutedEventArgs e)
        {
            cleanTextboxes();
            selectProduct();

            loadproducts();
            logDate = DateTime.Now;
         // logDateDatePicker.SelectedDate= DateTime.Now;
        }

        private void loadproducts()
        {
            ProductsDomainContext= new ProductDS();
			EntityQuery<Product> bb = from b in ProductsDomainContext.GetProductsQuery() select b;
            LoadOperation<Product> res = ProductsDomainContext.Load(bb, new Action<LoadOperation<Product>>(load_products_completed), true);
			
        }

        private void load_products_completed(LoadOperation<Product> obj)
        {
            productDataGrid.ItemsSource = ProductsDomainContext.Products;
            productDataGrid.SelectedIndex = 0;
        }

        private void LoadProductsWithSKU()
        {
            ProductsDomainContext = new ProductDS();
            EntityQuery<Product> bb = from b in ProductsDomainContext.GetProductsQuery() where b.SKU == SearchTextBox.Text select b;
            LoadOperation<Product> res = ProductsDomainContext.Load(bb, new Action<LoadOperation<Product>>(load_products_with_sku_completed), true);
			
        }

        private void load_products_with_sku_completed(LoadOperation<Product> obj)
        {
            productDataGrid.ItemsSource = ProductsDomainContext.Products;
            productDataGrid.SelectedIndex = 0;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            newFeedingLogDomainContext.SubmitChanges().Completed += submitChanges_completed;
           
        }

        private void submitChanges_completed(object sender, EventArgs e)
        {
            try
            {
                //todo configure this line to run leo's python code to get feeding average.
                string PythonCommands = "python C:\\LeoRepo\\dailyfeedsummary.py";
                runCmdShellClient.runAverageCommandAsync(PythonCommands);
                runCmdShellClient.runAverageCommandCompleted += runCmdShellClient_runAverageCommandCompleted;
            }
            catch (Exception g)
            {


            }
           
        }

        private void runCmdShellClient_runAverageCommandCompleted(object sender, runCmdShellServiceReference.runAverageCommandCompletedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void feedingLogDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void pondDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void pondsProductionCycleDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void productDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            //load datagrid with selected text in here. 

            LoadProductsWithSKU();
        }

        private void cleanTextboxes()
        {
            cummulativeFeedTextBox.Text = "";
            feedLogIDTextBox.Text = "";
            //logDateDatePicker.SelectedDate = null;
            //productIDTextBox.Text = "";
            productionCycleIDTextBox.Text = "";
            userIDTextBox.Text = WebContext.Current.User.ToString();
            feedGivenTextBox.Text = "";
            feedPerDayTextBox.Text = "";
            feedTypeTextBox.Text = "";
            logDateDatePicker.SelectedDate = null;
            //waterLevelTextBox.Text = "";
        }

        private void pondDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            productionCycleDomainContext= new PondsProductionCycleDS();
            
            tambak.Web.Pond selectedPond = this.pondDataGrid.SelectedItem as Pond;
            
            

            

            EntityQuery<tambak.Web.PondsProductionCycle> bb = from b in productionCycleDomainContext.GetPondsProductionCyclesQuery() where b.PondID == selectedPond.PondID && b.isInProduction == true select b;
            LoadOperation<tambak.Web.PondsProductionCycle> res = productionCycleDomainContext.Load(bb, new Action<LoadOperation<tambak.Web.PondsProductionCycle>>(load_production_cycle_completed), true);
			
        }

        private void load_production_cycle_completed(LoadOperation<Web.PondsProductionCycle> obj)
        {
            cleanTextboxes();
            pondsProductionCycleDataGrid.ItemsSource = productionCycleDomainContext.PondsProductionCycles;
            pondsProductionCycleDataGrid.SelectedIndex = 0;
            newFeedingLogDomainContext = new FeedingLogsDS();
        }

        private void pondsProductionCycleDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            feedinglogDomainContext = new FeedingLogsDS();
            tambak.Web.PondsProductionCycle selectedCycle = this.pondsProductionCycleDataGrid.SelectedItem as tambak.Web.PondsProductionCycle;


            try
            {
                productionCycleIDTextBox.Text = selectedCycle.ProductionCycleID.ToString();
                EntityQuery<FeedingLog> bb = from b in feedinglogDomainContext.GetFeedingLogsQuery() where b.ProductionCycleID == selectedCycle.ProductionCycleID select b;
                LoadOperation<FeedingLog> res = feedinglogDomainContext.Load(bb, new Action<LoadOperation<FeedingLog>>(load_feeding_log_completed), true);
            }
            catch (Exception g)
            {
                productionCycleIDTextBox.Text = "";
            }

        }

        private void load_feeding_log_completed(LoadOperation<FeedingLog> obj)
        {
            try
            {
                FeedingLog bc = obj.Entities.Last();
                waterLevelTextBox.Text = bc.waterLevel.ToString();

            }
            catch (Exception g)
            {
            }

            feedingLogDataGrid.ItemsSource = feedinglogDomainContext.FeedingLogs;
        }

        private void productDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectProduct();
        }

        private void selectProduct()
        {
            try
            {
                tambak.Web.Product selectedProduct = this.productDataGrid.SelectedItem as Product;
                productIDTextBox.Text = selectedProduct.ProductID.ToString();
            }
            catch (Exception g)
            {
            }
        }

        private void addButton_Click_1(object sender, RoutedEventArgs e)
        {
            
            //feedinglogDomainContext = new FeedingLogsDS();


            //newFeedingLogDomainContext = new FeedingLogsDS();
            
            NewFeedingLogList = new FeedingLog();
            NewFeedingLogList.ProductID = Convert.ToInt32(productIDTextBox.Text);
            NewFeedingLogList.ProductionCycleID = Convert.ToInt32(productionCycleIDTextBox.Text);
            NewFeedingLogList.feedGiven = Convert.ToDouble(feedGivenTextBox.Text);
            NewFeedingLogList.waterLevel = Convert.ToInt32(waterLevelTextBox.Text);
            if (logDateDatePicker.SelectedDate == null)
            {
               NewFeedingLogList.LogDate = DateTime.Now.Date;
            }
            else
            {
                NewFeedingLogList.LogDate = logDateDatePicker.SelectedDate;
            }
            NewFeedingLogList.UserID = WebContext.Current.User.ToString();

            newFeedingLogDomainContext.FeedingLogs.Add(NewFeedingLogList);
            feedingLogDataGrid.ItemsSource = newFeedingLogDomainContext.FeedingLogs;
            //feedinglogDomainContext.FeedingLogs.Add(NewFeedingLogList);
            //feedingLogDataGrid.ItemsSource = feedinglogDomainContext.FeedingLogs;
            removeButton.IsEnabled = true;
        }
        FeedingLog NewFeedingLogList = new FeedingLog();
        FeedingLogsDS newFeedingLogDomainContext = new FeedingLogsDS();
        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            FeedingLog selectedFL = this.feedingLogDataGrid.SelectedItem as FeedingLog;
            newFeedingLogDomainContext.FeedingLogs.Remove(selectedFL);
        }
        //public Ponds selectedPond { get; set; }
    }
}

