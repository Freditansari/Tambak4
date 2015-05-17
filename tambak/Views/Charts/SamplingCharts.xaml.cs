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
using Telerik.Windows.Controls.Charting;

namespace tambak.Views.Charts
{
    
    
    public partial class SamplingCharts : Page
    {
        PondsProductionCycleDS PondsProductionCycleDomainContext = new PondsProductionCycleDS();
        tambak.Web.PondsProductionCycle SelectedPondProductionCycle = new tambak.Web.PondsProductionCycle();
        PondsDS pondsDomainContext = new PondsDS();
        FeedingAuditViewDS FeedingAuditDomainContext = new FeedingAuditViewDS();
        Pond selectedPond = new Pond();
        SamplingLogDS SamplingLogDomainContext = new SamplingLogDS();
        WaterParameterRangeDS waterParameterRangeDomainContext = new WaterParameterRangeDS();
        WaterParameterRangeView SelectedWaterParameterRange = new WaterParameterRangeView();


        //List<WaterParameterRange> WaterParamRangeList = new List<WaterParameterRange>();

        public SamplingCharts()
        {
            try
            {
                if (WebContext.Current.User.IsInRole("Manager") || WebContext.Current.User.IsInRole("Technician") || WebContext.Current.User.IsInRole("Super Admin"))
                {


                    InitializeComponent();
                    Loaded += SamplingCharts_Loaded;

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

        void SamplingCharts_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

       

        private void loadSamplingLog_completed(LoadOperation<SamplingLog> obj)
        {

            loadMBWChart();
            loadSizeChart();
            loadfcrChart();
            loadWeeklyFCR();
            loadBiomass();
            loadPopulation();
            LoadSurvivalRate();
            loadADG();
            loadCummulativeADG();
            loadWaterParameterRange();
            

          

        }

        private void loadWaterParameterRange()
        {
            waterParameterRangeDomainContext = new WaterParameterRangeDS();
			EntityQuery<WaterParameterRangeView> bb = (from b in waterParameterRangeDomainContext.GetWaterParameterRangeViewsQuery() where b.ProductionCycleID == SelectedPondProductionCycle.ProductionCycleID select b).OrderBy(b => b.LogDate);
            LoadOperation<WaterParameterRangeView> res = waterParameterRangeDomainContext.Load(bb, new Action<LoadOperation<WaterParameterRangeView>>(loadWaterParameterRange_completed), true);
			
        }

        private void loadWaterParameterRange_completed(LoadOperation<WaterParameterRangeView> obj)
        {
            //DataSeries lineSeries = new DataSeries();
            //DataSeries StandardSeries = new DataSeries();

            //FeedingAuditCharts.DefaultView.ChartArea.DataSeries.Clear();
            //FeedingAuditCharts.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            //FeedingAuditCharts.DefaultView.ChartTitle.Content = "Feeding Charts";
            //lineSeries.Definition = new LineSeriesDefinition();
            //StandardSeries.Definition = new LineSeriesDefinition();
            //foreach (var b in FeedingAuditDomainContext.FeedingAuditViews)
            //{
            //    lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.Total_Feed), XCategory = b.DayOfCulture.ToString() });
            //    StandardSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.FeedingPlan), XCategory = b.DayOfCulture.ToString() });
            //}
            //FeedingAuditCharts.DefaultView.ChartArea.DataSeries.Add(lineSeries);
            //FeedingAuditCharts.DefaultView.ChartArea.DataSeries.Add(StandardSeries);


            DataSeries lineSeries = new DataSeries();
            DataSeries MaxPHSeries = new DataSeries();
            DataSeries minPHSeries = new DataSeries();

            PHRangeChart.DefaultView.ChartArea.DataSeries.Clear();
            PHRangeChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            PHRangeChart.DefaultView.ChartTitle.Content = "PH Range";
            lineSeries.Definition = new LineSeriesDefinition();
            MaxPHSeries.Definition = new LineSeriesDefinition();
            minPHSeries.Definition = new LineSeriesDefinition();

            foreach (var b in waterParameterRangeDomainContext.WaterParameterRangeViews)
            {
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.RangePH), XCategory = b.LogDate.ToString().Split(' ')[0] });
                MaxPHSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.MaxPH), XCategory = b.LogDate.ToString().Split(' ')[0] });
                minPHSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.MinPH), XCategory = b.LogDate.ToString().Split(' ')[0] });
                //StandardSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.RangePH), XCategory = b.LogDate.ToString() });
            }
            PHRangeChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
            PHRangeChart.DefaultView.ChartArea.DataSeries.Add(MaxPHSeries);
            PHRangeChart.DefaultView.ChartArea.DataSeries.Add(minPHSeries);

            loadDoRange();

        }

        private void loadDoRange()
        {
            DataSeries lineSeries = new DataSeries();
            DataSeries MaxDOSeries = new DataSeries();
            DataSeries minDOSeries = new DataSeries();

            DOrangeChart.DefaultView.ChartArea.DataSeries.Clear();
            DOrangeChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            DOrangeChart.DefaultView.ChartTitle.Content = "DO Range";
            lineSeries.Definition = new LineSeriesDefinition();
            MaxDOSeries.Definition = new LineSeriesDefinition();
            minDOSeries.Definition = new LineSeriesDefinition();
            //StandardSeries.Definition = new LineSeriesDefinition();

            foreach (var b in waterParameterRangeDomainContext.WaterParameterRangeViews)
            {
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.RangeDO), XCategory = b.LogDate.ToString().Split(' ')[0] });
                MaxDOSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.MaxDO), XCategory = b.LogDate.ToString().Split(' ')[0] });
                minDOSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.MinDO), XCategory = b.LogDate.ToString().Split(' ')[0] });
            }
            DOrangeChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
            DOrangeChart.DefaultView.ChartArea.DataSeries.Add(MaxDOSeries);
            DOrangeChart.DefaultView.ChartArea.DataSeries.Add(minDOSeries);

            loadTOMMax();
        }

        private void loadTOMMax()
        {
            DataSeries lineSeries = new DataSeries();
            DataSeries StandardSeries = new DataSeries();

            ToMChart.DefaultView.ChartArea.DataSeries.Clear();
            ToMChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            ToMChart.DefaultView.ChartTitle.Content = "Total Organic Material";
            lineSeries.Definition = new LineSeriesDefinition();
            //StandardSeries.Definition = new LineSeriesDefinition();

            foreach (var b in waterParameterRangeDomainContext.WaterParameterRangeViews)
            {
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.TotalOrganicMaterial), XCategory = b.LogDate.ToString().Split(' ')[0] });
                //StandardSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.RangePH), XCategory = b.LogDate.ToString() });
            }
            ToMChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
        }

        private void loadFeedingAudit()
        {
            try
            {
                FeedingAuditDomainContext = new FeedingAuditViewDS();
                EntityQuery<FeedingAuditView> bb = from b in FeedingAuditDomainContext.GetFeedingAuditViewsQuery() where b.ProductionCycleID == SelectedPondProductionCycle.ProductionCycleID select b;
                LoadOperation<FeedingAuditView> res = FeedingAuditDomainContext.Load(bb, new Action<LoadOperation<FeedingAuditView>>(loadFeedingAudit_Completed), true);
            }
            catch (Exception g)
            {
            }


           
        }

        private void loadFeedingAudit_Completed(LoadOperation<FeedingAuditView> obj)
        {
            DataSeries lineSeries = new DataSeries();
            DataSeries StandardSeries = new DataSeries();

            FeedingAuditCharts.DefaultView.ChartArea.DataSeries.Clear();
            FeedingAuditCharts.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            FeedingAuditCharts.DefaultView.ChartTitle.Content = "Feeding Charts";
            lineSeries.Definition = new LineSeriesDefinition();
            StandardSeries.Definition = new LineSeriesDefinition();
            foreach (var b in FeedingAuditDomainContext.FeedingAuditViews)
            {
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.Total_Feed), XCategory = b.DayOfCulture.ToString() });
                StandardSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.FeedingPlan), XCategory = b.DayOfCulture.ToString() });
            }
           FeedingAuditCharts.DefaultView.ChartArea.DataSeries.Add(lineSeries);
           FeedingAuditCharts.DefaultView.ChartArea.DataSeries.Add(StandardSeries);
        }

        private void loadCummulativeADG()
        {
            DataSeries lineSeries = new DataSeries();

            CumulativeAdgChart.DefaultView.ChartArea.DataSeries.Clear();
            CumulativeAdgChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            CumulativeAdgChart.DefaultView.ChartTitle.Content = "Cummulative ADG";
            lineSeries.Definition = new LineSeriesDefinition();
            foreach (var b in SamplingLogDomainContext.SamplingLogs)
            {
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.CummulativeADG), XCategory = b.Age.ToString() });
            }
            CumulativeAdgChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
        }

        private void loadADG()
        {
            DataSeries lineSeries = new DataSeries();

            adgChart.DefaultView.ChartArea.DataSeries.Clear();
            adgChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            adgChart.DefaultView.ChartTitle.Content = "Average Daily Growth";
            lineSeries.Definition = new LineSeriesDefinition();
            foreach (var b in SamplingLogDomainContext.SamplingLogs)
            {
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.AverageDailyGrowth), XCategory = b.Age.ToString() });
            }
            adgChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
        }

        private void LoadSurvivalRate()
        {
            DataSeries lineSeries = new DataSeries();

            SurvivalRateChart.DefaultView.ChartArea.DataSeries.Clear();
            SurvivalRateChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            SurvivalRateChart.DefaultView.ChartTitle.Content = "Survival Rate";
            lineSeries.Definition = new LineSeriesDefinition();
            foreach (var b in SamplingLogDomainContext.SamplingLogs)
            {
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.SurvivalRate), XCategory = b.Age.ToString() });
            }
            SurvivalRateChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
        }

        private void loadPopulation()
        {
            DataSeries lineSeries = new DataSeries();

            PopulationChart.DefaultView.ChartArea.DataSeries.Clear();
            PopulationChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            PopulationChart.DefaultView.ChartTitle.Content = "Population";
            lineSeries.Definition = new LineSeriesDefinition();
            foreach (var b in SamplingLogDomainContext.SamplingLogs)
            {
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.Populations), XCategory = b.Age.ToString() });
            }
            PopulationChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
        }

        private void loadBiomass()
        {
            DataSeries lineSeries = new DataSeries();

            BiomassChart.DefaultView.ChartArea.DataSeries.Clear();
            BiomassChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            BiomassChart.DefaultView.ChartTitle.Content = "Biomass";
            lineSeries.Definition = new LineSeriesDefinition();
            foreach (var b in SamplingLogDomainContext.SamplingLogs)
            {
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.Biomass), XCategory = b.Age.ToString() });
            }
            BiomassChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
        }

        private void loadWeeklyFCR()
        {
            DataSeries lineSeries = new DataSeries();

            WeeklyFCR.DefaultView.ChartArea.DataSeries.Clear();
            WeeklyFCR.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            WeeklyFCR.DefaultView.ChartTitle.Content = "Weekly FCR";
            lineSeries.Definition = new LineSeriesDefinition();
            foreach (var b in SamplingLogDomainContext.SamplingLogs)
            {
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.WeeklyFCR), XCategory = b.Age.ToString() });
            }
            WeeklyFCR.DefaultView.ChartArea.DataSeries.Add(lineSeries);
        }

        private void loadfcrChart()
        {
            DataSeries lineSeries = new DataSeries();

            FCRChart.DefaultView.ChartArea.DataSeries.Clear();
            FCRChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            FCRChart.DefaultView.ChartTitle.Content = "FCR";
            lineSeries.Definition = new LineSeriesDefinition();
            foreach (var b in SamplingLogDomainContext.SamplingLogs)
            {
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.FCR), XCategory = b.Age.ToString() });
            }
            FCRChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
        }

        private void loadSizeChart()
        {
            DataSeries lineSeries = new DataSeries();
            DataSeries StandardSeries = new DataSeries();

            SizeChart.DefaultView.ChartArea.DataSeries.Clear();
            SizeChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            SizeChart.DefaultView.ChartTitle.Content = "Size";
            lineSeries.Definition = new LineSeriesDefinition();
            StandardSeries.Definition = new LineSeriesDefinition();
            foreach (var b in SamplingLogDomainContext.SamplingLogs)
            {
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.Size), XCategory = b.Age.ToString() });
                StandardSeries.Add(new DataPoint() { YValue = Convert.ToDouble(1000/(b.Age * 0.22)), XCategory = b.Age.ToString() });
            }
            SizeChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
            SizeChart.DefaultView.ChartArea.DataSeries.Add(StandardSeries);
        }

        private void loadMBWChart()
        {
            DataSeries lineSeries = new DataSeries();
            DataSeries StandardSeries = new DataSeries();

            agetoMBWChart.DefaultView.ChartArea.DataSeries.Clear();
            agetoMBWChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            agetoMBWChart.DefaultView.ChartTitle.Content = "MBW";
            lineSeries.Definition = new LineSeriesDefinition();
            StandardSeries.Definition = new LineSeriesDefinition();
            foreach (var b in SamplingLogDomainContext.SamplingLogs)
            {
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.MedianBodyWeight), XCategory = b.Age.ToString() });
                StandardSeries.Add(new DataPoint() { YValue =Convert.ToDouble( b.Age *0.22), XCategory = b.Age.ToString() });
            }
            
            agetoMBWChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
            agetoMBWChart.DefaultView.ChartArea.DataSeries.Add(StandardSeries);
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

        private void pondDescriptionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedPond = this.pondDescriptionComboBox.SelectedItem as tambak.Web.Pond;

            PondsProductionCycleDomainContext = new PondsProductionCycleDS();
			EntityQuery<tambak.Web.PondsProductionCycle> bb = from b in PondsProductionCycleDomainContext.GetPondsProductionCyclesQuery() where b.PondID == selectedPond.PondID select b;
            LoadOperation<tambak.Web.PondsProductionCycle> res = PondsProductionCycleDomainContext.Load(bb, new Action<LoadOperation<tambak.Web.PondsProductionCycle>>(loadPondproductionCycle_completed), true);
			
            
        }

        private void loadPondproductionCycle_completed(LoadOperation<Web.PondsProductionCycle> obj)
        {
            productionCycleIDComboBox.ItemsSource = PondsProductionCycleDomainContext.PondsProductionCycles;
            productionCycleIDComboBox.SelectedIndex = 0;
        }

        private void productionCycleIDComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                SelectedPondProductionCycle = this.productionCycleIDComboBox.SelectedItem as tambak.Web.PondsProductionCycle;
                loadSamplingLog();
                loadFeedingAudit();
                var currentDOC =(DateTime.Now - Convert.ToDateTime( SelectedPondProductionCycle.StartDate)).TotalDays;
                CurrentDOCTextBlock.Text =Math.Floor(currentDOC).ToString();
                DensityTextBlock.Text = SelectedPondProductionCycle.Density.ToString() ;
                InitialFryTextBox.Text =Convert.ToDouble( SelectedPondProductionCycle.NumberOfFry).ToString("N");

               
            }
            catch (Exception)
            { 
            }

        }

        private void loadSamplingLog()
        {
            try
            {
                SamplingLogDomainContext = new SamplingLogDS();
                EntityQuery<SamplingLog> bb = from b in SamplingLogDomainContext.GetSamplingLogsQuery() where b.ProductionCycleID == SelectedPondProductionCycle.ProductionCycleID select b;
                LoadOperation<SamplingLog> res = SamplingLogDomainContext.Load(bb, new Action<LoadOperation<SamplingLog>>(loadSamplingLog_completed), true);
			
            }
            catch (Exception g)
            {
                
                
            }
            
        }

        private void waterParameterRangeViewDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }


       
    }
}
