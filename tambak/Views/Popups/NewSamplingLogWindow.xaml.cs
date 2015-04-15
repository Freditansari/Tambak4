using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
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
    public partial class NewSamplingLogWindow : ChildWindow
    {
        public FeedingLogsDS newFeedingLogDomainContext { get; set; }
        FeedingLogsDS CummulativefeedingLogDomainContext = new FeedingLogsDS();
        public PondsProductionCycleDS productionCycleDomainContext { get; set; }
        tambak.Web.PondsProductionCycle SelectedProductionCycle { get; set; }

        runCmdShellServiceReference.RunCmdShellClient runCmdShellClient = new runCmdShellServiceReference.RunCmdShellClient();

        public FeedingRateGuideDS feedingRateGuideDomainContext { get; set; }
        SamplingLogDS samplingLogDomainContext = new SamplingLogDS();

        SamplingLogDS newSamplingLogDomainContext = new SamplingLogDS();
        

        public double medianBodyWeight { get; set; }
        public double feedingRate { get; set; }
        public int? lastSamplingAge { get; set; }

        double previousMBW;
        double previousCummulativeFeed;
        double previousBiomass;

        public double CumulativeFeed { get; set; }

        public double NumberOfFry { get; set; }

        double averageDailyFeed;

        public int age { get; set; }

        AverageDailyFeedSummaryDS averagedailyFeedContext = new AverageDailyFeedSummaryDS();

        public NewSamplingLogWindow()
        {
            InitializeComponent();
            Loaded += NewSamplingLogWindow_Loaded;
        }

        void NewSamplingLogWindow_Loaded(object sender, RoutedEventArgs e)
        {
            userIDTextBox.Text = WebContext.Current.User.ToString();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                newSamplingLogDomainContext.SubmitChanges().Completed += New_sampling_log_submit_completed;
            }
            catch (Exception g)
            {
                MessageBox.Show("Please Fix The Error " + g.Message.ToString()); 
            }
           
        }

        private void New_sampling_log_submit_completed(object sender, EventArgs e)
        {
            try
            {
                string PythonCommands = "python C:\\LeoRepo\\perkiraanpakan.py " + App.DatabaseName;
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

        private void samplingLogDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void cleanTextBoxes()
        {
            ageTextBox.Text = "";
            averageDailyGrowthTextBox.Text = "";
            biomassTextBox.Text = "";
            cummulativeADGTextBox.Text = "";
            cummulativeFeedTextBox.Text = "";
            dailyFeedTextBox.Text = "";
            fCRTextBox.Text = "";
            feedConsumptionsTextBox.Text = "";
            feedTypeTextBox.Text = "";
            medianBodyWeightTextBox.Text = "";
            populationsTextBox.Text = "";
            sizeTextBox.Text = "";
            survivalRateTextBox.Text = "";
            weeklyFCRTextBox.Text = "";
            weeklyFeedTextBox.Text = "";
            weightperWeekTextBox.Text = "";
            feedingRateTextBox.Text = "";

        }

     

        private void getCumulativeFeed()
        {

            //todo Bug happens when after customer types in everything is required in the form then move to another page and return back to the page case the required start date textbox become missing so it throws formatexceptions
            try
            {
                CummulativefeedingLogDomainContext = new FeedingLogsDS();
                EntityQuery<FeedingLog> bb = from b in CummulativefeedingLogDomainContext.GetFeedingLogsQuery() where b.ProductionCycleID == SelectedProductionCycle.ProductionCycleID select b;
                LoadOperation<FeedingLog> res = CummulativefeedingLogDomainContext.Load(bb, new Action<LoadOperation<FeedingLog>>(getCumulativeFeedCompleted), true);
            }
            catch (TargetInvocationException f)
            {
            }
        }

        private void getCumulativeFeedCompleted(LoadOperation<FeedingLog> obj)
        {
            cummulativeFeedTextBox.Text = CummulativefeedingLogDomainContext.FeedingLogs.Sum(b => b.feedGiven).ToString();
            CumulativeFeed =Convert.ToDouble( CummulativefeedingLogDomainContext.FeedingLogs.Sum(b => b.feedGiven));
        }

        private void pondDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            productionCycleDomainContext = new PondsProductionCycleDS();

            tambak.Web.Pond selectedPond = this.pondDataGrid.SelectedItem as Pond;





            EntityQuery<tambak.Web.PondsProductionCycle> bb = from b in productionCycleDomainContext.GetPondsProductionCyclesQuery() where b.PondID == selectedPond.PondID && b.isInProduction == true select b;
            LoadOperation<tambak.Web.PondsProductionCycle> res = productionCycleDomainContext.Load(bb, new Action<LoadOperation<tambak.Web.PondsProductionCycle>>(load_production_cycle_completed), true);
			
        }

        private void load_production_cycle_completed(LoadOperation<Web.PondsProductionCycle> obj)
        {
            cleanTextBoxes();
            pondsProductionCycleDataGrid.ItemsSource = productionCycleDomainContext.PondsProductionCycles;
            pondsProductionCycleDataGrid.SelectedIndex = 0;
            newFeedingLogDomainContext = new FeedingLogsDS();

            try
            {
                tambak.Web.PondsProductionCycle bc = obj.Entities.FirstOrDefault();
                NumberOfFry = Convert.ToDouble(bc.NumberOfFry);
            }
            catch (Exception g)
            {
            }
        }

        private void pondsProductionCycleDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            SelectedProductionCycle = this.pondsProductionCycleDataGrid.SelectedItem as tambak.Web.PondsProductionCycle;

            try
            {
                //this one is only to trigger the null reference exception if no production cycle id 
                if (Convert.ToInt32(SelectedProductionCycle.ProductionCycleID) == null)
                {
                    samplingLogDataGrid.ItemsSource = null;
                }
                else
                {
                    cleanTextBoxes();
                    LoadSelectedProductionCycle();
                    loadAverageDailyFeed();
                    loadPreviousSamplingLog();
                    getCumulativeFeed();
                    productionCycleIDTextBox.Text = SelectedProductionCycle.ProductionCycleID.ToString();
                }
            }
            catch (NullReferenceException g)
            {
                samplingLogDataGrid.ItemsSource = null;
            }
            

        }

        private void LoadSelectedProductionCycle()
        {

            samplingLogDomainContext = new SamplingLogDS();
            try
            {

			    EntityQuery<SamplingLog> bb = from b in samplingLogDomainContext.GetSamplingLogsQuery() where b.ProductionCycleID == SelectedProductionCycle.ProductionCycleID select b;
                LoadOperation<SamplingLog> res = samplingLogDomainContext.Load(bb, new Action<LoadOperation<SamplingLog>>(load_selected_samplinglog_completed), true);
			  
            }
            catch (Exception g)
            {
            }
			
        }

        private void load_selected_samplinglog_completed(LoadOperation<SamplingLog> obj)
        {
            samplingLogDataGrid.ItemsSource = samplingLogDomainContext.SamplingLogs;
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

        private void pondDomainDataSource_LoadedData_2(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void pondsProductionCycleDomainDataSource_LoadedData_2(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void loadPreviousSamplingLog()
        {
            PreviousSamplingLogDomainContext = new SamplingLogDS();
            EntityQuery<SamplingLog> bb = from b in PreviousSamplingLogDomainContext.GetSamplingLogsQuery() where b.ProductionCycleID == SelectedProductionCycle.ProductionCycleID orderby b.LogDate descending select b;
            //EntityQuery<SamplingLog> bb = from b in PreviousSamplingLogDomainContext.GetSamplingLogsQuery() where b.ProductionCycleID == Convert.ToInt32(productionCycleIDTextBox3.Text) select b;
            LoadOperation<SamplingLog> res = PreviousSamplingLogDomainContext.Load(bb, new Action<LoadOperation<SamplingLog>>(getPrevSamplingCompleted), true);


        }

        private void getPrevSamplingCompleted(LoadOperation<SamplingLog> obj)
        {
            try
            {
                SamplingLog bc = obj.Entities.FirstOrDefault();
                previousMBW = Convert.ToDouble( bc.MedianBodyWeight);
                previousCummulativeFeed = Convert.ToDouble(bc.CummulativeFeed);
                previousBiomass = Convert.ToDouble(bc.Biomass);
                lastSamplingAge = bc.Age;
            }
            catch (Exception g)
            {
                previousMBW = 0;
                previousCummulativeFeed = 0;
                lastSamplingAge = 0;
            }


        }








        public SamplingLogDS PreviousSamplingLogDomainContext { get; set; }

        private void ageTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                age = Convert.ToInt32(ageTextBox.Text);
            }
            catch(Exception g)
            {
            }
        }

        private void loadAverageDailyFeed()
        {

            EntityQuery<AverageDailyFeedSummary> bb = from b in averagedailyFeedContext.GetAverageDailyFeedSummariesQuery() where b.ProductionCycleID == SelectedProductionCycle.ProductionCycleID select b;
            LoadOperation<AverageDailyFeedSummary> res = averagedailyFeedContext.Load(bb, new Action<LoadOperation<AverageDailyFeedSummary>>(load_average_daily_feed_completed), true);

        }

        private void load_average_daily_feed_completed(LoadOperation<AverageDailyFeedSummary> obj)
        {
            try
            {
                AverageDailyFeedSummary bc = obj.Entities.First();
                dailyFeedTextBox.Text = bc.Average.ToString();
                averageDailyFeed = Convert.ToDouble(bc.Average);
            }
            catch (Exception g)
            {
                
               
            }
           
        }

        private void medianBodyWeightTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                medianBodyWeight = Convert.ToDouble(medianBodyWeightTextBox.Text);
                sizeTextBox.Text = Convert.ToString(1000 / Convert.ToDecimal(medianBodyWeightTextBox.Text));
                cummulativeADGTextBox.Text = Convert.ToString(Convert.ToDecimal(medianBodyWeightTextBox.Text) / Convert.ToInt32(ageTextBox.Text));
                weightperWeekTextBox.Text = Convert.ToString(Convert.ToDouble(medianBodyWeightTextBox.Text) - previousMBW);
                //todo suspect there will be bug
                averageDailyGrowthTextBox.Text = Convert.ToString(Convert.ToDecimal(weightperWeekTextBox.Text) / (Convert.ToInt32(ageTextBox.Text) - lastSamplingAge));
                weeklyFeedTextBox.Text = Convert.ToString(Convert.ToDouble(cummulativeFeedTextBox.Text) - previousCummulativeFeed);
                //calculate sampling logs 
                //calculate weekly FCR
                //weeklyFCRTextBox.Text = Convert.ToString((Convert.ToDouble(cummulativeFeedTextBox.Text) - Convert.ToDouble(prevCumFeedTextBox.Text)) / (Convert.ToDouble(biomassTextBox.Text) - lastBiomass));
                
            }
            catch (Exception g)
            {
            }
            
            //cummulativeADGTextBox.Text = Convert.ToString(Convert.ToDecimal(medianBodyWeightTextBox.Text) / Convert.ToInt32(ageTextBox.Text));
            
            //todo load feeding rate
            loadFeedingRate();
           CalculateSamplingLogs();
        }
        private void loadFeedingRate()
        {
            try
            {
                feedingRateGuideDomainContext = new FeedingRateGuideDS();
                EntityQuery<FRGuide> bb = from b in feedingRateGuideDomainContext.GetFRGuidesQuery() where b.MBW == Convert.ToDecimal(medianBodyWeightTextBox.Text) select b;
                LoadOperation<FRGuide> res = feedingRateGuideDomainContext.Load(bb, new Action<LoadOperation<FRGuide>>(load_feeding_rate_completed), true);
            }
            catch (Exception g)
            {
            }
        }

        private void load_feeding_rate_completed(LoadOperation<FRGuide> obj)
        {
            try
            {
                FRGuide bc = obj.Entities.First();
                feedingRateTextBox.Text = bc.FR.ToString();
            }
            catch (Exception g)
            {
            }
        }

        private void CalculateSamplingLogs()
        {
            try
            {
                Double biomass;
                feedingRate = Convert.ToDouble(feedingRateTextBox.Text);
                biomass = Convert.ToDouble((Convert.ToDouble(dailyFeedTextBox.Text) / feedingRate) * 100);
                biomassTextBox.Text = biomass.ToString();

                fCRTextBox.Text = Convert.ToString(CumulativeFeed / biomass);
                feedConsumptionsTextBox.Text = Convert.ToString((Convert.ToDouble(medianBodyWeightTextBox.Text) / Convert.ToDouble(dailyFeedTextBox.Text) / Convert.ToDouble(feedingRateTextBox.Text) * 100));
                populationsTextBox.Text = Convert.ToString((Convert.ToDouble(biomassTextBox.Text) / Convert.ToDouble(medianBodyWeightTextBox.Text) * 1000));
                //FIXED! populasi /jumlah tebar *100s
                //survivalRateTextBox.Text = Convert.ToString((Convert.ToDouble(populationsTextBox.Text) / Convert.ToInt32(NumberOfFryTextBox.Text)) * 100);
                survivalRateTextBox.Text = Convert.ToString((Convert.ToDouble(populationsTextBox.Text) / NumberOfFry) * 100);
                weeklyFCRTextBox.Text = Convert.ToString(((Convert.ToDouble(cummulativeFeedTextBox.Text) - previousCummulativeFeed) / (Convert.ToDouble(biomassTextBox.Text) - previousBiomass)));
            }
            catch (Exception g)
            {
            }
           // SaveSamplingLog.IsEnabled = true;
        }

        private void feedingRateTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //CalculateSamplingLogs();
        }

        private void addRecordButton_Click(object sender, RoutedEventArgs e)
        {

            newSamplingLogDomainContext = new SamplingLogDS();
            try
            {
                SamplingLog newSamplinglog = new SamplingLog();
                newSamplinglog.Age = Convert.ToInt32(ageTextBox.Text);
                newSamplinglog.AverageDailyGrowth = Convert.ToDouble(averageDailyGrowthTextBox.Text);
                newSamplinglog.Biomass = Convert.ToDouble(biomassTextBox.Text);
                newSamplinglog.CummulativeADG = Convert.ToDouble(cummulativeADGTextBox.Text);
                newSamplinglog.CummulativeFeed = Convert.ToInt32(cummulativeFeedTextBox.Text);
                newSamplinglog.DailyFeed = Convert.ToDecimal(dailyFeedTextBox.Text);
                newSamplinglog.FCR = Convert.ToDouble(fCRTextBox.Text);
                newSamplinglog.FeedConsumptions = Convert.ToDouble(feedConsumptionsTextBox.Text);
                newSamplinglog.FeedType = feedTypeTextBox.Text;
                newSamplinglog.MedianBodyWeight = Convert.ToDouble(medianBodyWeightTextBox.Text);
                newSamplinglog.Populations = Convert.ToDouble(populationsTextBox.Text);
                newSamplinglog.ProductionCycleID = Convert.ToInt32(productionCycleIDTextBox.Text);
                newSamplinglog.Size = Convert.ToDouble(sizeTextBox.Text);
                newSamplinglog.SurvivalRate = Convert.ToDouble(survivalRateTextBox.Text);
                newSamplinglog.UserID = WebContext.Current.User.ToString();
                newSamplinglog.WeeklyFCR = Convert.ToDecimal(weeklyFCRTextBox.Text);
                newSamplinglog.WeeklyFeed = Convert.ToInt32(weeklyFeedTextBox.Text);
                newSamplinglog.WeightperWeek = Convert.ToDouble(weightperWeekTextBox.Text);
                newSamplinglog.feedingRate = Convert.ToDouble(feedingRateTextBox.Text);

                newSamplingLogDomainContext.SamplingLogs.Add(newSamplinglog);
                samplingLogDataGrid.ItemsSource = newSamplingLogDomainContext.SamplingLogs;
                RemoveRecordB_utton.IsEnabled = true;
            }
            catch (Exception g)
            {
                MessageBox.Show("Please Fix The Input");
            }



        }

        private void RemoveRecordB_utton_Click(object sender, RoutedEventArgs e)
        {
            SamplingLog selectedsamplinglog = new SamplingLog();
            newSamplingLogDomainContext.SamplingLogs.Remove(selectedsamplinglog);
        }





     
    }
}

