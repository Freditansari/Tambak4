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
using System.Text.RegularExpressions;
using System.Reflection;
using System.Collections;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices.Automation;
using tambak.Views.Popups;



namespace tambak.Views
{
    public partial class SamplingLogs : Page
    {

        //todo load previous Median Body weight
        //todo inventory cutting
        //todo filter cannot add mbw more than >100
        //todo fix the damn date noob 
        //todo feeding rate automatically selected from feeding guide tables. 
        //todo put default water level on feeding log to last feeding log water level

        PondsProductionCycleDS pondProdDomainContext = new PondsProductionCycleDS();
        FeedingLogsDS feedingLogDomainContext = new FeedingLogsDS();
        FeedingLogsDS CummulativefeedingLogDomainContext = new FeedingLogsDS();
        FeedingLogsDS DailyFeedingLogDomainContext = new FeedingLogsDS();
        SamplingLogDS PreviousSamplingLogDomainContext = new SamplingLogDS();
        SamplingLogDS SamplingLogDomainContext = new SamplingLogDS();
        WaterParameterLogDS waterParamLogDomainContext = new WaterParameterLogDS();
        SamplingLogDS samplingLogDomainContext = new SamplingLogDS();
        CummulativeFeedViewDS cummulativeFeedDS = new CummulativeFeedViewDS();
        double cumulativeFeed;
        //DailyFeedSummaryViewDS dailyFeedDomainContext = new DailyFeedSummaryViewDS(); deprecated due to bug in view
        AverageDailyFeedSummaryDS averagedailyFeedContext = new AverageDailyFeedSummaryDS();
        FeedingRateGuideDS feedingRateGuideDomainContext = new FeedingRateGuideDS();

        

        //SamplingLogs samplinglogData = new SamplingLogs();

        tambak.Web.PondsProductionCycle selectedID = new Web.PondsProductionCycle();
        DateTime ServerDate = new DateTime();
        public double daily_feed { get; set; }


        public int age { get; set; }
        //public int age {
        //    get
        //    {
        //        return age
        //    }
        //    set
        //    {
        //        if (value <= 0 || value >= 120)
        //            throw new Exception("please enter value between 0-120");
        //    }
        //}
        public double medianBodyWeight { get; set; }
        public double feedingRate { get; set; }
        public int? lastSamplingAge { get; set; }
        
        

        getServerTimeReference.GetServerTimeClient newServertimeClient = new getServerTimeReference.GetServerTimeClient();
        runCmdShellServiceReference.RunCmdShellClient runCmdShellClient = new runCmdShellServiceReference.RunCmdShellClient();

        public void StartTimer()
        {
            System.Windows.Threading.DispatcherTimer myDispatcherTimer = new System.Windows.Threading.DispatcherTimer();
         //   myDispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 500); // 500 Milliseconds 
            myDispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1000); // 500 Milliseconds 
            myDispatcherTimer.Tick += new EventHandler(Each_Tick);
            myDispatcherTimer.Start();
        }
        public void Each_Tick(object o, EventArgs sender)
        {
            //getserverTime();
            try
            {
                DateTime serverTime = Convert.ToDateTime(ServerTimeTextBlock.Text);
                TimeSpan time = new TimeSpan(0, 0, 0, 1, 0);
                DateTime addServerTime = serverTime.Add(time);
                ServerTimeTextBlock.Text = addServerTime.ToString();
            }
            catch (FormatException g)
            {
                getserverTime();
            }
        }
        private void getserverTime()
        {
            try
            {
                newServertimeClient.getServerTimeAsync();
                newServertimeClient.getServerTimeCompleted += getTimeCompleted;
            }
            catch (Exception g)
            {
            }
        }

        private void getTimeCompleted(object sender, getServerTimeReference.getServerTimeCompletedEventArgs e)
        {
           // ServerTimeTextBlock.Text = e.Result.ToString();
            logDateDatePicker1.SelectedDate = e.Result;
            ServerDate = e.Result;

        }

        public SamplingLogs()
        {
            try
            {
                if (WebContext.Current.User.IsInRole("Technician") || WebContext.Current.User.IsInRole("Super Admin"))
                {
                    InitializeComponent();
                     // StartTimer();
                    getserverTime();
                    

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

        private void pondDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void pondsProductionCycleDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void samplingLogDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void feedingLogDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void waterParameterLogDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }
        
        private void loadSamplingLog()
        {
            samplingLogDomainContext= new SamplingLogDS();
            //EntityQuery<SamplingLog> bb = from b in PreviousSamplingLogDomainContext.GetSamplingLogsQuery() where b.ProductionCycleID == Convert.ToInt32(productionCycleIDTextBox3.Text) orderby b.LogDate descending select b;
            EntityQuery<SamplingLog> bb = from b in samplingLogDomainContext.GetSamplingLogsQuery() where b.ProductionCycleID == Convert.ToInt32(productionCycleIDTextBox3.Text) select b;
            LoadOperation<SamplingLog> res = samplingLogDomainContext.Load(bb, new Action<LoadOperation<SamplingLog>>(getSamplingCompleted), true);


        }

        private void getSamplingCompleted(LoadOperation<SamplingLog> obj)
        {
            samplingLogRadGridView.ItemsSource = samplingLogDomainContext.SamplingLogs;
            
        }

        private void loadPreviousSamplingLog()
        {
            PreviousSamplingLogDomainContext = new SamplingLogDS();
            EntityQuery<SamplingLog> bb = from b in PreviousSamplingLogDomainContext.GetSamplingLogsQuery() where b.ProductionCycleID == Convert.ToInt32(productionCycleIDTextBox3.Text) orderby b.LogDate descending select b;
            //EntityQuery<SamplingLog> bb = from b in PreviousSamplingLogDomainContext.GetSamplingLogsQuery() where b.ProductionCycleID == Convert.ToInt32(productionCycleIDTextBox3.Text) select b;
            LoadOperation<SamplingLog> res = PreviousSamplingLogDomainContext.Load(bb, new Action<LoadOperation<SamplingLog>>(getPrevSamplingCompleted), true);


        }

        private void getPrevSamplingCompleted(LoadOperation<SamplingLog> obj)
        {
            try
            {
                //getting the previous record available. 
                SamplingLog bc = obj.Entities.FirstOrDefault();
                prevMBW.Text = bc.MedianBodyWeight.ToString();
               //todo load previous cummulative feed.
                prevCumFeedTextBox.Text = bc.CummulativeFeed.ToString();
                lastSamplingAge = bc.Age;
                lastBiomass = Convert.ToDouble( bc.Biomass);
                if (bc.Biomass == null)
                {
                    lastBiomass = 0;
                }
            }
            catch (InvalidOperationException g)
            {
                prevMBW.Text = "0";
                prevCumFeedTextBox.Text = "0";
                lastSamplingAge = 0;
            }
            catch (NullReferenceException g)
            {
                prevMBW.Text = "0";
                prevCumFeedTextBox.Text = "0";
                lastSamplingAge = 0;
            }
        }

        private void pondIDTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //load only related data toward this production Cycle and only the one in production. 
            pondProdDomainContext = new PondsProductionCycleDS();
            EntityQuery<tambak.Web.PondsProductionCycle> bb = from b in pondProdDomainContext.GetPondsProductionCyclesQuery() where b.PondID == Convert.ToInt32(pondIDTextBox.Text) && b.isInProduction == true select b;
            LoadOperation<tambak.Web.PondsProductionCycle> res = pondProdDomainContext.Load(bb, new Action<LoadOperation<tambak.Web.PondsProductionCycle>>(getProductionCycleCompleted), true);
                    
        }

        private void getProductionCycleCompleted(LoadOperation<Web.PondsProductionCycle> obj)
        {
            pondsProductionCycleRadGridView.ItemsSource = pondProdDomainContext.PondsProductionCycles;
        }

        private void productionCycleIDTextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Bind to production cycle field in water parameter log, feeding log, and sampling log 

            //change feeding log radgridview along with the production cycle change.
            //load previous sampling log. 

            loadFeedingLog();
            LoadWaterParameter();
            
            //loadPreviousSamplingLog();
            //productionCycleIDTextBox2.Text = productionCycleIDTextBox3.Text;
           
        }

        private void loadFeedingLog()
        {
            try
            {
                feedingLogDomainContext = new FeedingLogsDS();
                EntityQuery<FeedingLog> bb = from b in feedingLogDomainContext.GetFeedingLogsQuery() where b.ProductionCycleID == Convert.ToInt32(productionCycleIDTextBox3.Text) select b;
                LoadOperation<FeedingLog> res = feedingLogDomainContext.Load(bb, new Action<LoadOperation<FeedingLog>>(getFeedingLogCompleted), true);
            }
            catch (Exception g)
            {
            }
        }

        private void getFeedingLogCompleted(LoadOperation<FeedingLog> obj)
        {
            //get previous daily feed for sampling log

            feedingLogRadGridView.ItemsSource = feedingLogDomainContext.FeedingLogs;
           
            getDailyFeed();
            getCumulativeFeed();
            //getAverageFeed();
            getAverageFeeds();

            try
            {
                FeedingLog bc = obj.Entities.Last();
                waterLevelTextBox.Text = bc.waterLevel.ToString();
            }
            catch (Exception G)
            {
            }
        }

        private void pondsProductionCycleRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            loadNecessaryInformations();
        }

        private void loadNecessaryInformations()
        {
            try
            {
                selectedID = this.pondsProductionCycleRadGridView.SelectedItem as tambak.Web.PondsProductionCycle;
                productionCycleIDTextBox3.Text = selectedID.ProductionCycleID.ToString();
                startDateTextBox.Text = selectedID.StartDate.ToString();
                NumberOfFryTextBox.Text = selectedID.NumberOfFry.ToString();
                productionCycleIDTextBox2.Text = selectedID.ProductionCycleID.ToString();
                //productionCycleIDTextBox.Text = selectedID.ProductionCycleID.ToString();
                productionCycleIDTextBox1.Text = selectedID.ProductionCycleID.ToString();
                loadPreviousSamplingLog();
                loadSamplingLog();
                loadDailyFeed();
                loadAverageDailyFeed();

                //load cumulative feed variable. 
                CumulativeFeedView cumView = new CumulativeFeedView();

                EntityQuery<CumulativeFeedView> bb = from b in cummulativeFeedDS.GetCumulativeFeedViewsQuery() where b.ProductionCycleID == selectedID.ProductionCycleID select b;
                LoadOperation<CumulativeFeedView> res = cummulativeFeedDS.Load(bb, new Action<LoadOperation<CumulativeFeedView>>(load_cummulative_feed_completed), true);


            }
            catch (NullReferenceException f)
            {
                productionCycleIDTextBox3.Text = "";
            }
        }

        private void loadFeedingRate()
        {

            EntityQuery<FRGuide> bb = from b in feedingRateGuideDomainContext.GetFRGuidesQuery() where b.MBW == Convert.ToDecimal(medianBodyWeightTextBox.Text) select b;
            LoadOperation<FRGuide> res = feedingRateGuideDomainContext.Load(bb, new Action<LoadOperation<FRGuide>>(load_feeding_rate_completed), true);
			
        }

        private void load_feeding_rate_completed(LoadOperation<FRGuide> obj)
        {
            FRGuide bc = obj.Entities.First();
            feedingRateTextBox.Text = bc.FR.ToString();
            
        }

        private void loadAverageDailyFeed()
        {

			EntityQuery<AverageDailyFeedSummary> bb = from b in averagedailyFeedContext.GetAverageDailyFeedSummariesQuery() where b.ProductionCycleID == selectedID.ProductionCycleID select b;
            LoadOperation<AverageDailyFeedSummary> res = averagedailyFeedContext.Load(bb, new Action<LoadOperation<AverageDailyFeedSummary>>(load_average_daily_feed_completed), true);
			
        }

        private void load_average_daily_feed_completed(LoadOperation<AverageDailyFeedSummary> obj)
        {
            try
            {
                AverageDailyFeedSummary bc = obj.Entities.First();
                dailyFeedTextBox.Text = bc.Average.ToString();
                CurrentDailyFeed.Text = bc.Average.ToString();
                avgDailyFeedTextbox.Text = bc.Average.ToString();
            }
            catch (Exception g)
            {
            }
        }

        private void loadDailyFeed()
        {
                
            //EntityQuery<DailyFeedSummaryView> bb = from b in dailyFeedDomainContext.GetDailyFeedSummaryViewsQuery() where b.ProductionCycleID == selectedID.ProductionCycleID && b.Date == ServerDate.Date select b;
            //LoadOperation<DailyFeedSummaryView> res = dailyFeedDomainContext.Load(bb, new Action<LoadOperation<DailyFeedSummaryView>>(load_daily_feed_completed), true);
			
        }

        //private void load_daily_feed_completed(LoadOperation<DailyFeedSummaryView> obj)
        //{
        //    try
        //    {
        //        DailyFeedSummaryView bc = obj.Entities.First();
        //        dailyFeedTextBox.Text = bc.feedPerDay.ToString();
        //    }
        //    catch (Exception g)
        //    {
        //        dailyFeedTextBox.Text = "0";
        //    }
        //}

        private void load_cummulative_feed_completed(LoadOperation<CumulativeFeedView> obj)
        {
            try
            {
                CumulativeFeedView bc = obj.Entities.First();
                cumulativeFeed = Convert.ToDouble(bc.Cumulative_Feed);
                cummulativeFeedTextBox.Text = cumulativeFeed.ToString();
                cummulativeFeedTextBox1.Text = cumulativeFeed.ToString();
                CurrentCumFeed.Text = cumulativeFeed.ToString();
                
            }
            catch (Exception g)
            {
            }

        }
            

        private void LoadWaterParameter()
        {
            waterParamLogDomainContext = new WaterParameterLogDS();
            EntityQuery<WaterParameterLog> bb = from b in waterParamLogDomainContext.GetWaterParameterLogsQuery() where b.ProductionCycleID == Convert.ToInt32(productionCycleIDTextBox3.Text) select b;
            LoadOperation<WaterParameterLog> res = waterParamLogDomainContext.Load(bb, new Action<LoadOperation<WaterParameterLog>>(getwaterparamCompleted), true);
        }

        private void getwaterparamCompleted(LoadOperation<WaterParameterLog> obj)
        {
            waterParameterLogRadGridView.ItemsSource = waterParamLogDomainContext.WaterParameterLogs;
        }

        private void SaveWaterParameter()
        {
            //save water parameter to datagrid. 

            try
            {
                waterParamLogDomainContext = new WaterParameterLogDS();
                WaterParameterLog newWaterParameter = new WaterParameterLog();
                newWaterParameter.Amonnia = Convert.ToDouble(amonniaTextBox.Text);
                newWaterParameter.Bacteria = bacteriaTextBox.Text;
                newWaterParameter.DissolvedOxygen = Convert.ToDouble(dissolvedOxygenTextBox.Text);
                //newWaterParameter.LogDate = Convert.ToDateTime(ServerTimeTextBlock.Text);
                newWaterParameter.Paddlewheel = Convert.ToInt32(paddlewheelTextBox.Text);
                newWaterParameter.Phospate = Convert.ToDouble(phospateTextBox.Text);
                newWaterParameter.Planktons = Convert.ToInt32(planktonsTextBox.Text);

                if (productionCycleIDTextBox2.Text.Length == 0)
                {
                    productionCycleIDTextBox2.Text = productionCycleIDTextBox3.Text;
                }

                newWaterParameter.ProductionCycleID = Convert.ToInt32(productionCycleIDTextBox2.Text);
                newWaterParameter.Salinity = Convert.ToInt32(salinityTextBox.Text);
                newWaterParameter.Temperature = Convert.ToDouble(temperatureTextBox.Text);
                newWaterParameter.UserID = WebContext.Current.User.ToString();
                newWaterParameter.Vibrio = vibrioTextBox.Text;
                newWaterParameter.ammonium = Convert.ToDouble(ammoniumTextBox.Text);
                newWaterParameter.nitrate = Convert.ToInt32(nitrateTextBox.Text);
                newWaterParameter.nitrite = Convert.ToInt32(nitriteTextBox.Text);
                newWaterParameter.pH = Convert.ToDouble(pHTextBox.Text);



                waterParamLogDomainContext.WaterParameterLogs.Add(newWaterParameter);
                waterParamLogDomainContext.SubmitChanges().Completed += waterparameterSaved;
            }
            catch (Exception g)
            {
            }
        }

        private void waterparameterSaved(object sender, EventArgs e)
        {
            LoadWaterParameter();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          // not necessary  cummulativeFeedTextBox1.Text = DateTime.Today.ToString() + "00:01";
            getDailyFeed();
            getCumulativeFeed();
        }


        private void getDailyFeed()
        {
            try
            {
                DailyFeedingLogDomainContext = new FeedingLogsDS();
                EntityQuery<FeedingLog> bb = from b in DailyFeedingLogDomainContext.GetFeedingLogsQuery() where b.ProductionCycleID == Convert.ToInt32(productionCycleIDTextBox3.Text) && b.LogDate >= DateTime.Today && b.LogDate <= Convert.ToDateTime(ServerTimeTextBlock.Text) select b;
                LoadOperation<FeedingLog> res = DailyFeedingLogDomainContext.Load(bb, new Action<LoadOperation<FeedingLog>>(getDailyFeedCompleted), true);
            }
            catch (TargetInvocationException g)
            {
            }
    
        }

        private void getDailyFeedCompleted(LoadOperation<FeedingLog> obj)
        {

            CurrentDailyFeed.Text = DailyFeedingLogDomainContext.FeedingLogs.Sum(b => b.feedGiven).ToString();
            
        }

        private void getAverageFeed()
        {
          /**
          * Bug Fix: 
          * -The software has been rectified due to lower SR rate since the average feeding uses the blind feeding feeding weight. This cause the lower SR Rate. 
          * 23/2/2015: bugfix. Going to take from daily feeding summary view instead of take the last 7 feed log. This will cause an issue if there are multiple feeding log in a day. 
         **/

           // dailyFeedDomainContext = new DailyFeedSummaryViewDS();
           // ////EntityQuery<DailyFeedSummaryView> bb = from b in dailyFeedDomainContext.GetDailyFeedSummaryViewsQuery() where b.ProductionCycleID == selectedID.ProductionCycleID select b;
           // EntityQuery<DailyFeedSummaryView> bb = from b in dailyFeedDomainContext.GetDailyFeedSummaryViewsQuery() select b;
           // // EntityQuery<DailyFeedSummaryView> bb = from b in dailyFeedDomainContext.getDailyFeedAverageQuery(selectedID.ProductionCycleID) select b;
           // LoadOperation<DailyFeedSummaryView> res = dailyFeedDomainContext.Load(bb, new Action<LoadOperation<DailyFeedSummaryView>>(getAverageFeedCompleted), true);



           //// //DailyFeedingLogDomainContext = new FeedingLogsDS();
           //// //EntityQuery<FeedingLog> bb = from b in DailyFeedingLogDomainContext.GetFeedingLogsQuery() where b.ProductionCycleID == Convert.ToInt32(productionCycleIDTextBox3.Text) select b;
           //// //LoadOperation<FeedingLog> res = DailyFeedingLogDomainContext.Load(bb, new Action<LoadOperation<FeedingLog>>(getAverageFeedCompleted), true);
        }

        //private void getAverageFeedCompleted(LoadOperation<DailyFeedSummaryView> obj)
        //{
        //    /**
        //     * Bug Fix: 
        //     * -The software has been rectified due to lower SR rate since the average feeding uses the blind feeding feeding weight. This cause the lower SR Rate. 
        //     * 23/2/2015: bugfix. Going to take from daily feeding summary view instead of take the last 7 feed log. This will cause an issue if there are multiple feeding log in a day. 
        //    **/

        //    //feedingLogDatagrid.ItemsSource = dailyFeedDomainContext.DailyFeedSummaryViews;
        //    //double averageDailyFeed =Convert.ToDouble( DailyFeedingLogDomainContext.FeedingLogs.Average(b => b.feedGiven));
        //    //avgDailyFeedTextbox.Text = Math.Ceiling(averageDailyFeed).ToString();
        //    //FeedingLogsDS last7Logs = new FeedingLogsDS();
        //    //var last7Logs = (from p in DailyFeedingLogDomainContext.FeedingLogs orderby p.LogDate descending select p.).Take(7);

        //    //double last7Logs =Convert.ToDouble( DailyFeedingLogDomainContext.FeedingLogs.OrderByDescending(x => x.LogDate).Take(7).Average(b => b.feedGiven));
        //    //avgDailyFeedTextbox.Text = Math.Ceiling(last7Logs).ToString();

        //    //double lastSevenDays = Convert.ToDouble(dailyFeedDomainContext.DailyFeedSummaryViews.OrderBy(x => x.Date).Take(7).Average(b => b.feedPerDay));
        //    //avgDailyFeedTextbox.Text = lastSevenDays.ToString();

        //}

        private void getCumulativeFeed()
        {

            //todo Bug happens when after customer types in everything is required in the form then move to another page and return back to the page case the required start date textbox become missing so it throws formatexceptions
            try
            {
                CummulativefeedingLogDomainContext = new FeedingLogsDS();
                EntityQuery<FeedingLog> bb = from b in CummulativefeedingLogDomainContext.GetFeedingLogsQuery() where b.ProductionCycleID == Convert.ToInt32(productionCycleIDTextBox3.Text) && b.LogDate >= Convert.ToDateTime(startDateTextBox.Text) && b.LogDate <= Convert.ToDateTime(ServerTimeTextBlock.Text) select b;
                LoadOperation<FeedingLog> res = CummulativefeedingLogDomainContext.Load(bb, new Action<LoadOperation<FeedingLog>>(getCumulativeFeedCompleted), true);
            }
            catch (TargetInvocationException f)
            {
            }
        }

        private void getCumulativeFeedCompleted(LoadOperation<FeedingLog> obj)
        {
            CurrentCumFeed.Text = CummulativefeedingLogDomainContext.FeedingLogs.Sum(b => b.feedGiven).ToString();
        }

        private void feedGivenTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(feedGivenTextBox.Text, "[0-9]"))
                {
                    throw new ArgumentException("numbers only");
                }
                else
                {
                    feedPerDayTextBox.Text = Convert.ToString(Convert.ToInt32(CurrentDailyFeed.Text) + Convert.ToInt32(feedGivenTextBox.Text));
                    cummulativeFeedTextBox1.Text = Convert.ToString(Convert.ToInt32(CurrentCumFeed.Text) + Convert.ToInt32(feedGivenTextBox.Text));
                }

            }
            catch (ArgumentException f)
            {
                MessageBox.Show(f.Message);
            }
            catch (FormatException g)
            {
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
            //write down the SKU unit in the feed type field.
            try
            {
                Product selectedID = this.productRadGridView.SelectedItem as Product;
                //feedTypeTextBox1.Text= selectedID.SKU.ToString();
                feedTypeTextBox1.Text = selectedID.ProductID.ToString();
                
            }
            catch (NullReferenceException f)
            {
                
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //save feeding log 
            
            saveFeedingLog();
            

        }

        private void saveFeedingLog()
        {

           
            try
            {

                feedingLogDomainContext = new FeedingLogsDS();
                FeedingLog NewFeedingLog = new FeedingLog();
                NewFeedingLog.feedGiven = Convert.ToDouble(feedGivenTextBox.Text);
                NewFeedingLog.waterLevel = Convert.ToInt32(waterLevelTextBox.Text);
                NewFeedingLog.LogDate = logDateDatePicker1.SelectedDate;

                NewFeedingLog.ProductionCycleID = Convert.ToInt32(productionCycleIDTextBox1.Text);
                NewFeedingLog.UserID = WebContext.Current.User.ToString();
                //NewFeedingLog.feedPerDay = Convert.ToInt32(feedPerDayTextBox.Text);
                NewFeedingLog.feedType = feedTypeTextBox1.Text;
                //NewFeedingLog.CummulativeFeed = Convert.ToInt32(cummulativeFeedTextBox1.Text);


                feedingLogDomainContext.FeedingLogs.Add(NewFeedingLog);
                feedingLogDomainContext.SubmitChanges().Completed += SaveFeedinglogCompleted;
            }
            catch (FormatException f)
            {
            }
        }

        private void SaveFeedinglogCompleted(object sender, EventArgs e)
        {
            loadFeedingLog();
        }

        private void medianBodyWeightTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {
                medianBodyWeight = Convert.ToDouble(medianBodyWeightTextBox.Text);
                if (medianBodyWeight < 0 || medianBodyWeight >= 21)
                {
                    medianBodyWeightTextBox.Text = "";
                    throw new System.FormatException("Median Body Weight cannot go more than 21 or less than 0");
                    
                }
                else
                {
                    sizeTextBox.Text = Convert.ToString(1000 / Convert.ToDecimal(medianBodyWeightTextBox.Text));
                    cummulativeADGTextBox.Text = Convert.ToString(Convert.ToDecimal(medianBodyWeightTextBox.Text) / Convert.ToInt32(ageTextBox.Text));
                    // dailyFeedTextBox.Text = avgDailyFeedTextbox.Text;
                    //cummulativeFeedTextBox.Text = CurrentCumFeed.Text;
                    weightperWeekTextBox.Text = Convert.ToString(Convert.ToDecimal(medianBodyWeightTextBox.Text) - Convert.ToDecimal(prevMBW.Text));
                    averageDailyGrowthTextBox.Text = Convert.ToString(Convert.ToDecimal(weightperWeekTextBox.Text) / (Convert.ToInt32(ageTextBox.Text) - lastSamplingAge));
                    cummulativeADGTextBox.Text = Convert.ToString(Convert.ToDecimal(medianBodyWeightTextBox.Text) / Convert.ToInt32(ageTextBox.Text));
                    weeklyFeedTextBox.Text = Convert.ToString(Convert.ToDecimal(cummulativeFeedTextBox.Text) - Convert.ToDecimal(prevCumFeedTextBox.Text));
                  
                    loadFeedingRate();
                    CalculateSamplingLogs();
                    weeklyFCRTextBox.Text = Convert.ToString((Convert.ToDouble(cummulativeFeedTextBox.Text) - Convert.ToDouble(prevCumFeedTextBox.Text)) / (Convert.ToDouble(biomassTextBox.Text) - lastBiomass));

                }


            }
            catch (FormatException f)
            {
                ////MessageBox.Show(f.Message);
            }
            catch (DivideByZeroException g)
            {
            }

        }

        private void CurrentCumFeed_TextChanged(object sender, TextChangedEventArgs e)
        {
            //bug some how this line doesn't work. the event does not fire. 
            //cummulativeFeedTextBox.Text = CurrentCumFeed.Text;
        }

        private void CurrentDailyFeed_TextChanged(object sender, TextChangedEventArgs e)
        {
            //bug somehow this line doesn't work. the event does not fire. 
            //dailyFeedTextBox.Text = CurrentDailyFeed.Text;
        }

        private void productionCycleIDTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
         
        }

        private void ageTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //grab cummulative feed and daily feed from the textbox in feeding log.
           // cummulativeFeedTextBox.Text = CurrentCumFeed.Text;
           // dailyFeedTextBox.Text = avgDailyFeedTextbox.Text; ==> cause bugs
            age = Convert.ToInt32(ageTextBox.Text);
            //if (age <= 0 || age >= 120)
            //    throw new Exception("age cannot be less than 0 or bigger than 120");
            //catch (Exception g)
            //{
            //}

        }

        //private void validateAge(int age)
        //{
        //    try
        //    {
        //        if (age <= 0 || age >= 120)
        //        {
        //            throw new Exception("age cannot be less than 0 or bigger than 120");
        //        }
        //    }
        //    catch (Exception g)
        //    {
        //    }

        //}

        private void feedingRateTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //count biomass, Feed Conversion Ratio, Feed Consumptions rate, Population, Survival rate
            //biomass = (daily feed / feeding rate) *100
            //feed Conversion ratio = cummulative feed/biomass
            //feed consumptions rate = (MBW/Daily Feed)/ feeding rate*100
            //Populations = (biomass /MBW)*1000
            //Survival Rate = (Jumlah tebar/populasi)*1000
            
                
             
                
            
            
        //    try
        //    {
        //        Double biomass;
        //        biomass = Convert.ToDouble((Convert.ToDouble(dailyFeedTextBox.Text) / Convert.ToDouble(feedingRateTextBox.Text)) * 100);
        //        biomassTextBox.Text = biomass.ToString();
        //        fCRTextBox.Text = Convert.ToString(Convert.ToDouble(cummulativeFeedTextBox.Text) / Convert.ToDouble(biomassTextBox.Text));
        //        feedConsumptionsTextBox.Text = Convert.ToString((Convert.ToDouble(medianBodyWeightTextBox.Text) / Convert.ToDouble(dailyFeedTextBox.Text) / Convert.ToDouble(feedingRateTextBox.Text) * 100));
        //        populationsTextBox.Text = Convert.ToString((Convert.ToDouble(biomassTextBox.Text) / Convert.ToDouble(medianBodyWeightTextBox.Text) * 1000));
        //        //FIXED! populasi /jumlah tebar *100s
        //        survivalRateTextBox.Text = Convert.ToString((Convert.ToDouble(populationsTextBox.Text) / Convert.ToInt32(NumberOfFryTextBox.Text)) * 100);
        //        SaveSamplingLog.IsEnabled = true;

        //    }
        ////    catch (DivideByZeroException f)
        ////    {
        ////        MessageBox.Show(f.Message);
        ////    }
        ////    catch (FormatException g)
        ////    {
        ////        MessageBox.Show(g.Message);
        ////    }
        }

        private void CalculateSamplingLogs()
        {
            Double biomass;
            feedingRate = Convert.ToDouble(feedingRateTextBox.Text);
            biomass = Convert.ToDouble((Convert.ToDouble(dailyFeedTextBox.Text) / feedingRate) * 100);
            biomassTextBox.Text = biomass.ToString();
            //fCRTextBox.Text = Convert.ToString(Convert.ToDouble(cummulativeFeedTextBox.Text) / Convert.ToDouble(biomassTextBox.Text));
            //todo convert to use the cummulative feed view
            //  fCRTextBox.Text = Convert.ToString(Convert.ToDouble(cummulativeFeedTextBox.Text) / biomass);
            fCRTextBox.Text = Convert.ToString(cumulativeFeed / biomass);
            feedConsumptionsTextBox.Text = Convert.ToString((Convert.ToDouble(medianBodyWeightTextBox.Text) / Convert.ToDouble(dailyFeedTextBox.Text) / Convert.ToDouble(feedingRateTextBox.Text) * 100));
            populationsTextBox.Text = Convert.ToString((Convert.ToDouble(biomassTextBox.Text) / Convert.ToDouble(medianBodyWeightTextBox.Text) * 1000));
            //FIXED! populasi /jumlah tebar *100s
            survivalRateTextBox.Text = Convert.ToString((Convert.ToDouble(populationsTextBox.Text) / Convert.ToInt32(NumberOfFryTextBox.Text)) * 100);
            SaveSamplingLog.IsEnabled = true;
        }

        private void SaveSamplingLog_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
                SamplingLogDomainContext = new SamplingLogDS();
                SamplingLog newSamplingLog = new SamplingLog();
                newSamplingLog.Age = Convert.ToInt32(ageTextBox.Text);
                newSamplingLog.AverageDailyGrowth = Convert.ToDouble(averageDailyGrowthTextBox.Text);
                newSamplingLog.Biomass = Convert.ToDouble(biomassTextBox.Text);
                newSamplingLog.CummulativeADG = Convert.ToDouble(cummulativeADGTextBox.Text);
                newSamplingLog.CummulativeFeed = Convert.ToInt32(cummulativeFeedTextBox.Text);
               // newSamplingLog.ProductionCycleID = Convert.ToInt32(productionCycleIDTextBox.Text);
                newSamplingLog.DailyFeed = Convert.ToDecimal(dailyFeedTextBox.Text);
                newSamplingLog.FCR = Convert.ToDouble(fCRTextBox.Text);
                newSamplingLog.FeedConsumptions = Convert.ToDouble(feedConsumptionsTextBox.Text);
                newSamplingLog.FeedType = feedTypeTextBox.Text;
                //newSamplingLog.LogDate = Convert.ToDateTime(ServerTimeTextBlock.Text);
                newSamplingLog.MedianBodyWeight = Convert.ToDouble(medianBodyWeightTextBox.Text);
                newSamplingLog.Populations = Convert.ToDouble(populationsTextBox.Text);
                newSamplingLog.Size = Convert.ToDouble(sizeTextBox.Text);
                newSamplingLog.SurvivalRate = Convert.ToDouble(survivalRateTextBox.Text);
                newSamplingLog.UserID = WebContext.Current.User.ToString();
                newSamplingLog.WeeklyFeed = Convert.ToInt32(weeklyFeedTextBox.Text);
                newSamplingLog.WeightperWeek = Convert.ToDouble(weightperWeekTextBox.Text);
                newSamplingLog.feedingRate = Convert.ToDouble(feedingRateTextBox.Text);
                newSamplingLog.WeeklyFCR = Convert.ToDecimal(weeklyFCRTextBox.Text);

                SamplingLogDomainContext.SamplingLogs.Add(newSamplingLog);
                SamplingLogDomainContext.SubmitChanges().Completed += samplinglogSaved;

            //}
            //catch (FormatException g)
            //{

            //    //MessageBox.Show(g.Message);
            //}
            
        }

        private void samplinglogSaved(object sender, EventArgs e)
        {
            loadSamplingLog();
        }

        private void amonniaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(amonniaTextBox.Text, "[0-9]"))
                {
                    throw new ArgumentException("numbers only");
                }
                else
                {
                }

            }
            catch (ArgumentException f)
            {
                MessageBox.Show(f.Message);
            }
            catch (FormatException g)
            {
            }
        }

        private void dissolvedOxygenTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(dissolvedOxygenTextBox.Text, "[0-9]"))
                {
                    throw new ArgumentException("numbers only");
                }
                else
                {
                }

            }
            catch (ArgumentException f)
            {
                MessageBox.Show(f.Message);
            }
            catch (FormatException g)
            {
            }
        }

        private void paddlewheelTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(paddlewheelTextBox.Text, "[0-9]"))
                {
                    throw new ArgumentException("numbers only");
                }
                else
                {
                }

            }
            catch (ArgumentException f)
            {
                MessageBox.Show(f.Message);
            }
            catch (FormatException g)
            {
            }
        }

        private void phospateTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(phospateTextBox.Text, "[0-9]"))
                {
                    throw new ArgumentException("numbers only");
                }
                else
                {
                }

            }
            catch (ArgumentException f)
            {
                MessageBox.Show(f.Message);
            }
            catch (FormatException g)
            {
            }
        }

        private void planktonsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(planktonsTextBox.Text, "[0-9]"))
                {
                    throw new ArgumentException("numbers only");
                }
                else
                {
                }

            }
            catch (ArgumentException f)
            {
                MessageBox.Show(f.Message);
            }
            catch (FormatException g)
            {
            }
        }

        private void salinityTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(salinityTextBox.Text, "[0-9]"))
                {
                    throw new ArgumentException("numbers only");
                }
                else
                {
                }

            }
            catch (ArgumentException f)
            {
                MessageBox.Show(f.Message);
            }
            catch (FormatException g)
            {
            }
        }

        private void temperatureTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(temperatureTextBox.Text, "[0-9]"))
                {
                    throw new ArgumentException("numbers only");
                }
                else
                {
                }

            }
            catch (ArgumentException f)
            {
                MessageBox.Show(f.Message);
            }
            catch (FormatException g)
            {
            }
        }

        private void waterLogIDTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
     
        }

        private void ammoniumTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(ammoniumTextBox.Text, "[0-9]"))
                {
                    throw new ArgumentException("numbers only");
                }
                else
                {
                }

            }
            catch (ArgumentException f)
            {
                MessageBox.Show(f.Message);
            }
            catch (FormatException g)
            {
            }
        }

        private void nitrateTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(nitrateTextBox.Text, "[0-9]"))
                {
                    throw new ArgumentException("numbers only");
                }
                else
                {
                }

            }
            catch (ArgumentException f)
            {
                MessageBox.Show(f.Message);
            }
            catch (FormatException g)
            {
            }
        }

        private void nitriteTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(nitriteTextBox.Text, "[0-9]"))
                {
                    throw new ArgumentException("numbers only");
                }
                else
                {
                }

            }
            catch (ArgumentException f)
            {
                MessageBox.Show(f.Message);
            }
            catch (FormatException g)
            {
            }
        }

        private void pHTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(pHTextBox.Text, "[0-9]"))
                {
                    throw new ArgumentException("numbers only");
                }
                else
                {
                }

            }
            catch (ArgumentException f)
            {
                MessageBox.Show(f.Message);
            }
            catch (FormatException g)
            {
            }
        }

        private void SaveWaterParamButton_Click(object sender, RoutedEventArgs e)
        {
            SaveWaterParameter();
        }

        private void avgDailyFeedTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            dailyFeedTextBox.Text = avgDailyFeedTextbox.Text;
        }

        private void productionCycleIDTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            productionCycleIDTextBox2.Text = productionCycleIDTextBox1.Text;
        }

        private void getAverageFeeds()
        {
            //feedingLogDomainContext = new FeedingLogsDS();

            //EntityQuery<FeedingLog> bb = from b in feedingLogDomainContext.getLastSevenDaysAverageQuery(selectedID.ProductionCycleID) select b;
            //LoadOperation<FeedingLog> res = feedingLogDomainContext.Load(bb, new Action<LoadOperation<FeedingLog>>(get_average_feedinglog_completed), true);
			
			
                
			
        }

        private void get_average_feedinglog_completed(LoadOperation<FeedingLog> obj)
        {
            //feedingLogDatagrid.ItemsSource = feedingLogDomainContext.FeedingLogs;
        }

        private void pODetailsViewDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void summaryFeedPerDayViewDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void salesOrderDetailsViewDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void dailyFeedTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
                daily_feed = Convert.ToDouble(dailyFeedTextBox.Text);
 
        }

        private void prevMBW_TextChanged(object sender, TextChangedEventArgs e)
        {

        }














        public double lastBiomass { get; set; }

   

        private void newFeedingLogButton_Click_1(object sender, RoutedEventArgs e)
        {
            NewFeedingLogChildWindows cw = new NewFeedingLogChildWindows();
            cw.Show();
            cw.Closed += newFeedingLogWindow_closed;

        }

        private void newFeedingLogWindow_closed(object sender, EventArgs e)
        {
            loadNecessaryInformations();
            loadFeedingLog();
        }

        private void newSamplingButton_Click_1(object sender, RoutedEventArgs e)
        {
            NewSamplingLogWindow cw = new NewSamplingLogWindow();
            cw.Show();
            cw.Closed += samplingLogChildWindow_closed;
        }

        void samplingLogChildWindow_closed(object sender, EventArgs e)
        {
            loadSamplingLog();
        }

        private void weeklyFCRTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void totalSevenDaysFeedDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }


        //SendMailServiceReference.SendMailsClient EmailClient = new SendMailServiceReference.SendMailsClient();

        //private void Button_Click_2(object sender, RoutedEventArgs e)
        //{
        //    EmailClient.SendEmailAsync(totextbox.Text, subjectTextBox.Text, BodyTextBox.Text);
        //    EmailClient.SendEmailCompleted += EmailClient_SendEmailCompleted;
        //}

        //void EmailClient_SendEmailCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        //{
        //    try
        //    {
        //        MessageBox.Show("OK" + e.Error);
        //    }
        //    catch (Exception f)
        //    {

        //        MessageBox.Show(f.Message);
        //    }
        //}
    }
}
