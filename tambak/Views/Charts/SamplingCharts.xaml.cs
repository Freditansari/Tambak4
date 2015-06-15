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
        WaterParameterLogDS waterParameterLogDomainContext = new WaterParameterLogDS();

        int numberOfWaterParameter;

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
            loadAmmonia();
            loadNitrite();

            loadClarityChart();


          
          

        }

        private void loadClarityChart()
        {
            waterParameterLogDomainContext = new WaterParameterLogDS();
            EntityQuery<WaterParameterLog> bb = from b in waterParameterLogDomainContext.GetWaterParameterLogsQuery() where b.ProductionCycleID == SelectedPondProductionCycle.ProductionCycleID && b.Clarity != null select b;
            LoadOperation<WaterParameterLog> res = waterParameterLogDomainContext.Load(bb, new Action<LoadOperation<WaterParameterLog>>(loadClarity_completed), true);
			
        }

        private void loadClarity_completed(LoadOperation<WaterParameterLog> obj)
        {
            DataSeries lineSeries = new DataSeries();

            ClarityChart.DefaultView.ChartArea.DataSeries.Clear();
            ClarityChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            ClarityChart.DefaultView.ChartTitle.Content = "Clarity";
            lineSeries.Definition = new LineSeriesDefinition();

            foreach (var b in waterParameterLogDomainContext.WaterParameterLogs)
            {
                var DOC = (Convert.ToDateTime(b.LogDate) - Convert.ToDateTime(SelectedPondProductionCycle.StartDate)).TotalDays;
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.Clarity), XCategory = Math.Floor(DOC).ToString() });

            }
            ClarityChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
        }


        private void loadxClarityChart(int numberOfRecords)
        {
            numberOfWaterParameter = numberOfRecords;
            waterParameterLogDomainContext = new WaterParameterLogDS();
            EntityQuery<WaterParameterLog> bb = from b in waterParameterLogDomainContext.GetWaterParameterLogsQuery() where b.ProductionCycleID == SelectedPondProductionCycle.ProductionCycleID && b.Clarity != null select b;
            LoadOperation<WaterParameterLog> res = waterParameterLogDomainContext.Load(bb, new Action<LoadOperation<WaterParameterLog>>(loadxClarity_completed), true);

        }

        private void loadxClarity_completed(LoadOperation<WaterParameterLog> obj)
        {
            DataSeries lineSeries = new DataSeries();

            ClarityChart.DefaultView.ChartArea.DataSeries.Clear();
            ClarityChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            ClarityChart.DefaultView.ChartTitle.Content = "Clarity";
            lineSeries.Definition = new LineSeriesDefinition();

            var LastXClarity = (from b in waterParameterLogDomainContext.WaterParameterLogs orderby b.LogDate descending select b).Take(numberOfWaterParameter);
            var SortedClarity = from b in LastXClarity orderby b.LogDate select b;

            foreach (var b in SortedClarity)
            {
                var DOC = (Convert.ToDateTime(b.LogDate) - Convert.ToDateTime(SelectedPondProductionCycle.StartDate)).TotalDays;
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.Clarity), XCategory = Math.Floor(DOC).ToString() });

            }
            ClarityChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
        }


        private void loadNitrite()
        {
            waterParameterLogDomainContext = new WaterParameterLogDS();
			EntityQuery<WaterParameterLog> bb = from b in waterParameterLogDomainContext.GetWaterParameterLogsQuery() where b.ProductionCycleID== SelectedPondProductionCycle.ProductionCycleID && b.nitrite != null select b;
            LoadOperation<WaterParameterLog> res = waterParameterLogDomainContext.Load(bb, new Action<LoadOperation<WaterParameterLog>>(loadNitrite_completed), true);
			
        }

        private void loadNitrite_completed(LoadOperation<WaterParameterLog> obj)
        {
           

            DataSeries lineSeries = new DataSeries();

            NitriteChart.DefaultView.ChartArea.DataSeries.Clear();
            NitriteChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            NitriteChart.DefaultView.ChartTitle.Content = "Nitrite";
            lineSeries.Definition = new LineSeriesDefinition();
           
            foreach (var b in waterParameterLogDomainContext.WaterParameterLogs)
            {
                var DOC = (Convert.ToDateTime(b.LogDate) - Convert.ToDateTime(SelectedPondProductionCycle.StartDate)).TotalDays;
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.nitrite), XCategory =Math.Floor( DOC).ToString() });
                
            }
            NitriteChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
            

        }


        private void loadxNitrite(int numberOfRecords)
        {
            numberOfWaterParameter = numberOfRecords;
            waterParameterLogDomainContext = new WaterParameterLogDS();
            EntityQuery<WaterParameterLog> bb = from b in waterParameterLogDomainContext.GetWaterParameterLogsQuery() where b.ProductionCycleID == SelectedPondProductionCycle.ProductionCycleID && b.nitrite != null select b;
            LoadOperation<WaterParameterLog> res = waterParameterLogDomainContext.Load(bb, new Action<LoadOperation<WaterParameterLog>>(loadxNitrite_completed), true);

        }

        private void loadxNitrite_completed(LoadOperation<WaterParameterLog> obj)
        {


            DataSeries lineSeries = new DataSeries();

            NitriteChart.DefaultView.ChartArea.DataSeries.Clear();
            NitriteChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            NitriteChart.DefaultView.ChartTitle.Content = "Nitrite";
            lineSeries.Definition = new LineSeriesDefinition();

            var TakeXNitriteRecord = (from b in waterParameterLogDomainContext.WaterParameterLogs orderby b.LogDate descending select b).Take(numberOfWaterParameter);
            var SortedNitriteRecord = from b in TakeXNitriteRecord orderby b.LogDate select b;

            foreach (var b in SortedNitriteRecord)
            {
                var DOC = (Convert.ToDateTime(b.LogDate) - Convert.ToDateTime(SelectedPondProductionCycle.StartDate)).TotalDays;
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.nitrite), XCategory = Math.Floor(DOC).ToString() });

            }
            NitriteChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);


        }


        private void loadAmmonia()
        {
            waterParameterLogDomainContext = new WaterParameterLogDS();
            EntityQuery<WaterParameterLog> bb = from b in waterParameterLogDomainContext.GetWaterParameterLogsQuery() where b.ProductionCycleID == SelectedPondProductionCycle.ProductionCycleID && b.Amonnia != null select b;
            LoadOperation<WaterParameterLog> res = waterParameterLogDomainContext.Load(bb, new Action<LoadOperation<WaterParameterLog>>(loadAmmonia_completed), true);
			
        }

        private void loadAmmonia_completed(LoadOperation<WaterParameterLog> obj)
        {
            DataSeries lineSeries = new DataSeries();

            AmmoniaChart.DefaultView.ChartArea.DataSeries.Clear();
            AmmoniaChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            AmmoniaChart.DefaultView.ChartTitle.Content = "Ammonia";
            lineSeries.Definition = new LineSeriesDefinition();

            foreach (var b in waterParameterLogDomainContext.WaterParameterLogs)
            {
                var DOC = (Convert.ToDateTime(b.LogDate) - Convert.ToDateTime(SelectedPondProductionCycle.StartDate)).TotalDays;
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.Amonnia), XCategory = Math.Floor( DOC).ToString() });

            }
            AmmoniaChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);

        }

        private void loadxAmmonia(int numberOfRecords)
        {
            numberOfWaterParameter = numberOfRecords;
            waterParameterLogDomainContext = new WaterParameterLogDS();
            EntityQuery<WaterParameterLog> bb = from b in waterParameterLogDomainContext.GetWaterParameterLogsQuery() where b.ProductionCycleID == SelectedPondProductionCycle.ProductionCycleID && b.Amonnia != null select b;
            LoadOperation<WaterParameterLog> res = waterParameterLogDomainContext.Load(bb, new Action<LoadOperation<WaterParameterLog>>(loadxAmmonia_completed), true);

        }

        private void loadxAmmonia_completed(LoadOperation<WaterParameterLog> obj)
        {
            DataSeries lineSeries = new DataSeries();

            AmmoniaChart.DefaultView.ChartArea.DataSeries.Clear();
            AmmoniaChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            AmmoniaChart.DefaultView.ChartTitle.Content = "Ammonia";
            lineSeries.Definition = new LineSeriesDefinition();

            var TakeXAmmonia = (from b in waterParameterLogDomainContext.WaterParameterLogs orderby b.LogDate descending select b).Take(numberOfWaterParameter);
            var SortAmmonia = from b in TakeXAmmonia orderby b.LogDate select b;

            foreach (var b in SortAmmonia)
            {
                var DOC = (Convert.ToDateTime(b.LogDate) - Convert.ToDateTime(SelectedPondProductionCycle.StartDate)).TotalDays;
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.Amonnia), XCategory = Math.Floor(DOC).ToString() });

            }
            AmmoniaChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);

        }

        private void loadWaterParameterRange()
        {
            waterParameterRangeDomainContext = new WaterParameterRangeDS();
			EntityQuery<WaterParameterRangeView> bb = (from b in waterParameterRangeDomainContext.GetWaterParameterRangeViewsQuery() where b.ProductionCycleID == SelectedPondProductionCycle.ProductionCycleID select b).OrderBy(b => b.LogDate);
            LoadOperation<WaterParameterRangeView> res = waterParameterRangeDomainContext.Load(bb, new Action<LoadOperation<WaterParameterRangeView>>(loadWaterParameterRange_completed), true);
			
        }

        private void loadWaterParameterRange_completed(LoadOperation<WaterParameterRangeView> obj)
        {
           


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
                var DOC = (Convert.ToDateTime(b.LogDate) - Convert.ToDateTime(SelectedPondProductionCycle.StartDate)).TotalDays;
               


                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.RangePH), XCategory = Math.Floor(DOC).ToString() });
                MaxPHSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.MaxPH), XCategory = Math.Floor(DOC).ToString() });
                minPHSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.MinPH), XCategory = Math.Floor(DOC).ToString() });

                
            }
            PHRangeChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
            PHRangeChart.DefaultView.ChartArea.DataSeries.Add(MaxPHSeries);
            PHRangeChart.DefaultView.ChartArea.DataSeries.Add(minPHSeries);


            detailedPHChart.DefaultView.ChartArea.DataSeries.Clear();
            detailedPHChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            detailedPHChart.DefaultView.ChartTitle.Content = "PH Range";
            lineSeries.Definition = new LineSeriesDefinition();
            MaxPHSeries.Definition = new LineSeriesDefinition();
            minPHSeries.Definition = new LineSeriesDefinition();
            detailedPHChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
            detailedPHChart.DefaultView.ChartArea.DataSeries.Add(MaxPHSeries);
            detailedPHChart.DefaultView.ChartArea.DataSeries.Add(minPHSeries);

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
                //lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.RangeDO), XCategory = b.LogDate.ToString().Split(' ')[0] });
                //var currentDOC = (DateTime.Now - Convert.ToDateTime(SelectedPondProductionCycle.StartDate)).TotalDays;
                var DOC = ( Convert.ToDateTime( b.LogDate) - Convert.ToDateTime( SelectedPondProductionCycle.StartDate)).TotalDays;
                //lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.RangeDO), XCategory = b.LogDate.ToString().Split(' ')[0] });
                //MaxDOSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.MaxDO), XCategory = b.LogDate.ToString().Split(' ')[0] });
                //minDOSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.MinDO), XCategory = b.LogDate.ToString().Split(' ')[0] });
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.RangeDO), XCategory = Math.Floor( DOC).ToString() });
                MaxDOSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.MaxDO), XCategory = Math.Floor(DOC).ToString() });
                minDOSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.MinDO), XCategory = Math.Floor(DOC).ToString() });
            }
            DOrangeChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
            DOrangeChart.DefaultView.ChartArea.DataSeries.Add(MaxDOSeries);
            DOrangeChart.DefaultView.ChartArea.DataSeries.Add(minDOSeries);
            //detailedDOChart

            detailedDOChart.DefaultView.ChartArea.DataSeries.Clear();
            detailedDOChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            detailedDOChart.DefaultView.ChartTitle.Content = "DO Range";
            lineSeries.Definition = new LineSeriesDefinition();
            MaxDOSeries.Definition = new LineSeriesDefinition();
            minDOSeries.Definition = new LineSeriesDefinition();
            detailedDOChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
            detailedDOChart.DefaultView.ChartArea.DataSeries.Add(MaxDOSeries);
            detailedDOChart.DefaultView.ChartArea.DataSeries.Add(minDOSeries);

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
                var DOC = (Convert.ToDateTime(b.LogDate) - Convert.ToDateTime(SelectedPondProductionCycle.StartDate)).TotalDays;
                //lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.TotalOrganicMaterial), XCategory = b.LogDate.ToString().Split(' ')[0] });
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.TotalOrganicMaterial), XCategory = Math.Floor(DOC).ToString() });
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


           detailedFeedingChart.DefaultView.ChartArea.DataSeries.Clear();
           detailedFeedingChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
           detailedFeedingChart.DefaultView.ChartTitle.Content = "Feeding Charts(details)";
           lineSeries.Definition = new LineSeriesDefinition();
           StandardSeries.Definition = new LineSeriesDefinition();
           detailedFeedingChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
           detailedFeedingChart.DefaultView.ChartArea.DataSeries.Add(StandardSeries);
        }

       

        private void loadxFeedingAudit(int numberOfRecords)
        {
            try
            {
                numberOfWaterParameter = numberOfRecords;
                FeedingAuditDomainContext = new FeedingAuditViewDS();
                EntityQuery<FeedingAuditView> bb = from b in FeedingAuditDomainContext.GetFeedingAuditViewsQuery() where b.ProductionCycleID == SelectedPondProductionCycle.ProductionCycleID select b;
                LoadOperation<FeedingAuditView> res = FeedingAuditDomainContext.Load(bb, new Action<LoadOperation<FeedingAuditView>>(loadxFeedingAudit_Completed), true);
            }
            catch (Exception g)
            {
            }



        }

        private void loadxFeedingAudit_Completed(LoadOperation<FeedingAuditView> obj)
        {
            DataSeries lineSeries = new DataSeries();
            DataSeries StandardSeries = new DataSeries();

            FeedingAuditCharts.DefaultView.ChartArea.DataSeries.Clear();
            FeedingAuditCharts.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            FeedingAuditCharts.DefaultView.ChartTitle.Content = "Feeding Charts";
            lineSeries.Definition = new LineSeriesDefinition();
            StandardSeries.Definition = new LineSeriesDefinition();

            var TakeXFeedingAudit = (from b in FeedingAuditDomainContext.FeedingAuditViews orderby b.DayOfCulture descending select b).Take(numberOfWaterParameter);
            var SortedFeedingAudit = from b in TakeXFeedingAudit orderby b.DayOfCulture select b;

            foreach (var b in SortedFeedingAudit)
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

        private void loadXCummulativeADG(int NumberOfRecord)
        {
            DataSeries lineSeries = new DataSeries();

            CumulativeAdgChart.DefaultView.ChartArea.DataSeries.Clear();
            CumulativeAdgChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            CumulativeAdgChart.DefaultView.ChartTitle.Content = "Cummulative ADG";
            lineSeries.Definition = new LineSeriesDefinition();

            var TakeLastXCummulativeADG = (from b in SamplingLogDomainContext.SamplingLogs orderby b.LogDate descending select b).Take(NumberOfRecord) ;
            var SortedCummulativeADG = from b in TakeLastXCummulativeADG orderby b.LogDate select b;
            foreach (var b in SortedCummulativeADG)
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

        private void loadxADG(int numberOfRecord)
        {
            DataSeries lineSeries = new DataSeries();

            adgChart.DefaultView.ChartArea.DataSeries.Clear();
            adgChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            adgChart.DefaultView.ChartTitle.Content = "Average Daily Growth";
            lineSeries.Definition = new LineSeriesDefinition();

            var TakeLastXADG= (from b in SamplingLogDomainContext.SamplingLogs orderby b.LogDate descending select b).Take(numberOfRecord);
            var sortLastADG = from b in TakeLastXADG orderby b.LogDate select b;
            foreach (var b in sortLastADG)
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

        private void LoadXSurvivalRate(int NumberOfRecord)
        {
            DataSeries lineSeries = new DataSeries();

            SurvivalRateChart.DefaultView.ChartArea.DataSeries.Clear();
            SurvivalRateChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            SurvivalRateChart.DefaultView.ChartTitle.Content = "Survival Rate";
            lineSeries.Definition = new LineSeriesDefinition();

            var TakeXSRRecord = (from b in SamplingLogDomainContext.SamplingLogs orderby b.LogDate descending select b).Take(NumberOfRecord);
            var SortedSRRecord = from b in TakeXSRRecord orderby b.LogDate select b;
            foreach (var b in SortedSRRecord)
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


        private void loadXPopulation(int NumberOfRecord)
        {
            DataSeries lineSeries = new DataSeries();

            PopulationChart.DefaultView.ChartArea.DataSeries.Clear();
            PopulationChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            PopulationChart.DefaultView.ChartTitle.Content = "Population";
            lineSeries.Definition = new LineSeriesDefinition();

            var LastXPopulation = (from b in SamplingLogDomainContext.SamplingLogs orderby b.LogDate descending select b).Take(NumberOfRecord);
            var SortedPopulation = from b in LastXPopulation orderby b.LogDate select b;

            foreach (var b in SortedPopulation)
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

        private void loadXBiomass(int numberOfRecord)
        {
            DataSeries lineSeries = new DataSeries();

            BiomassChart.DefaultView.ChartArea.DataSeries.Clear();
            BiomassChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            BiomassChart.DefaultView.ChartTitle.Content = "Biomass";
            lineSeries.Definition = new LineSeriesDefinition();

            var LastXBiomass = (from b in SamplingLogDomainContext.SamplingLogs orderby b.LogDate descending select b).Take(numberOfRecord);
            var SortedBiomass = from b in LastXBiomass orderby b.LogDate select b;

            foreach (var b in SortedBiomass)
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

        private void loadXWeeklyFCR(int NumberOfRecord)
        {
            DataSeries lineSeries = new DataSeries();

            WeeklyFCR.DefaultView.ChartArea.DataSeries.Clear();
            WeeklyFCR.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            WeeklyFCR.DefaultView.ChartTitle.Content = "Weekly FCR";
            lineSeries.Definition = new LineSeriesDefinition();

            var LastSevenData = (from b in SamplingLogDomainContext.SamplingLogs orderby b.LogDate descending select b).Take(NumberOfRecord);
            var SortedSevenData = from b in LastSevenData orderby b.LogDate select b;

            foreach (var b in SortedSevenData)
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

        private void loadXfcrChart(int NumberOfRecord)
        {
            DataSeries lineSeries = new DataSeries();

            FCRChart.DefaultView.ChartArea.DataSeries.Clear();
            FCRChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            FCRChart.DefaultView.ChartTitle.Content = "FCR";
            lineSeries.Definition = new LineSeriesDefinition();

            var lastSevenFCR = (from b in SamplingLogDomainContext.SamplingLogs orderby b.LogDate descending select b).Take(NumberOfRecord);
            var SortedLastSevenFCR = from b in lastSevenFCR orderby b.LogDate select b;

            foreach (var b in SortedLastSevenFCR)
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

        private void loadXSizeChart(int NumberOfRecord)
        {
            DataSeries lineSeries = new DataSeries();
            DataSeries StandardSeries = new DataSeries();

            SizeChart.DefaultView.ChartArea.DataSeries.Clear();
            SizeChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            SizeChart.DefaultView.ChartTitle.Content = "Size";
            lineSeries.Definition = new LineSeriesDefinition();
            StandardSeries.Definition = new LineSeriesDefinition();

            var LastXSizeChart = (from b in SamplingLogDomainContext.SamplingLogs orderby b.LogDate descending select b).Take(NumberOfRecord);
            var SortedSizeChart = from b in  LastXSizeChart orderby  b.LogDate select b;
            foreach (var b in SortedSizeChart)
            {
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.Size), XCategory = b.Age.ToString() });
                StandardSeries.Add(new DataPoint() { YValue = Convert.ToDouble(1000 / (b.Age * 0.22)), XCategory = b.Age.ToString() });
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



        private void loadXMBWChart(int NumberOfRecord)
        {
            DataSeries lineSeries = new DataSeries();
            DataSeries StandardSeries = new DataSeries();

            agetoMBWChart.DefaultView.ChartArea.DataSeries.Clear();
            agetoMBWChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            agetoMBWChart.DefaultView.ChartTitle.Content = "MBW";
            lineSeries.Definition = new LineSeriesDefinition();
            StandardSeries.Definition = new LineSeriesDefinition();

            var lastSevenMBW = (from b in SamplingLogDomainContext.SamplingLogs orderby b.LogDate descending select b).Take(NumberOfRecord);
            var SortedLastSevenMBW = from b in lastSevenMBW orderby b.LogDate select b;

           
            foreach (var b in SortedLastSevenMBW)
            {
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.MedianBodyWeight), XCategory = b.Age.ToString() });
                StandardSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.Age * 0.22), XCategory = b.Age.ToString() });
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
            SevenDaysCheckBox.IsChecked = false;
            FifteenDaysDataCheckBox.IsChecked = false;
            PondsProductionCycleDomainContext = new PondsProductionCycleDS();
			EntityQuery<tambak.Web.PondsProductionCycle> bb = from b in PondsProductionCycleDomainContext.GetPondsProductionCyclesQuery() where b.PondID == selectedPond.PondID && b.isInProduction == true select b;
            LoadOperation<tambak.Web.PondsProductionCycle> res = PondsProductionCycleDomainContext.Load(bb, new Action<LoadOperation<tambak.Web.PondsProductionCycle>>(loadPondproductionCycle_completed), true);
			
            
        }

        private void loadPondproductionCycle_completed(LoadOperation<Web.PondsProductionCycle> obj)
        {
            productionCycleIDComboBox.ItemsSource = PondsProductionCycleDomainContext.PondsProductionCycles;
            try
            {
                productionCycleIDComboBox.SelectedIndex = 0;
                SelectedPondProductionCycle = this.productionCycleIDComboBox.SelectedItem as tambak.Web.PondsProductionCycle;
                getAllDataFromProductionCycle();
            }
            catch (Exception)
            {
            }
        }

        private void productionCycleIDComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //SelectedPondProductionCycle = this.productionCycleIDComboBox.SelectedItem as tambak.Web.PondsProductionCycle;
           // getAllDataFromProductionCycle();
        }

        private void getAllDataFromProductionCycle()
        {
            try
            {

                loadAllDataInChart();
                if (SevenDaysCheckBox.IsChecked == false && FifteenDaysDataCheckBox.IsChecked == false)
                {
                    loadAllDataInChart();
                }
                else
                    if (SevenDaysCheckBox.IsChecked == true && FifteenDaysDataCheckBox.IsChecked == false)
                    {
                        loadSevenDaysData();
                    }
                    else
                        if (SevenDaysCheckBox.IsChecked == false && FifteenDaysDataCheckBox.IsChecked == true)
                        {
                            loadFifteenDaysData();

                        }
                        else
                            if (SevenDaysCheckBox.IsChecked == true && FifteenDaysDataCheckBox.IsChecked == true)
                            {
                                loadAllDataInChart();
                            }

                var currentDOC = (DateTime.Now - Convert.ToDateTime(SelectedPondProductionCycle.StartDate)).TotalDays;
                CurrentDOCTextBlock.Text = Math.Floor(currentDOC).ToString();
                DensityTextBlock.Text = SelectedPondProductionCycle.Density.ToString();
                InitialFryTextBox.Text = Convert.ToDouble(SelectedPondProductionCycle.NumberOfFry).ToString("N");


            }
            catch (Exception g)
            {
               // MessageBox.Show(g.Message);
            }

        }

        private void loadAllDataInChart()
        {
            loadSamplingLog();
            loadFeedingAudit();
            //loadDetailedFeedingAudit();
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


        private void loadXWaterParameterRange(int numberOfRecord)
        {
            numberOfWaterParameter = numberOfRecord;
            waterParameterRangeDomainContext = new WaterParameterRangeDS();
            EntityQuery<WaterParameterRangeView> bb = (from b in waterParameterRangeDomainContext.GetWaterParameterRangeViewsQuery() where b.ProductionCycleID == SelectedPondProductionCycle.ProductionCycleID select b).OrderBy(b => b.LogDate);
            LoadOperation<WaterParameterRangeView> res = waterParameterRangeDomainContext.Load(bb, new Action<LoadOperation<WaterParameterRangeView>>(loadSevenWaterParameterRange_completed), true);

        }
        

        private void loadSevenWaterParameterRange_completed(LoadOperation<WaterParameterRangeView> obj)
        {



            DataSeries lineSeries = new DataSeries();
            DataSeries MaxPHSeries = new DataSeries();
            DataSeries minPHSeries = new DataSeries();

            PHRangeChart.DefaultView.ChartArea.DataSeries.Clear();
            PHRangeChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            PHRangeChart.DefaultView.ChartTitle.Content = "PH Range";
            lineSeries.Definition = new LineSeriesDefinition();
            MaxPHSeries.Definition = new LineSeriesDefinition();
            minPHSeries.Definition = new LineSeriesDefinition();

            var LastSevenPHRange = (from b in waterParameterRangeDomainContext.WaterParameterRangeViews orderby b.LogDate descending select b).Take(numberOfWaterParameter);
            var SortedLastSevenPHRange = from b in LastSevenPHRange orderby b.LogDate select b;

            foreach (var b in SortedLastSevenPHRange)
            {
                var DOC = (Convert.ToDateTime(b.LogDate) - Convert.ToDateTime(SelectedPondProductionCycle.StartDate)).TotalDays;



                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.RangePH), XCategory = Math.Floor(DOC).ToString() });
                MaxPHSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.MaxPH), XCategory = Math.Floor(DOC).ToString() });
                minPHSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.MinPH), XCategory = Math.Floor(DOC).ToString() });

               
            }
            PHRangeChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
            PHRangeChart.DefaultView.ChartArea.DataSeries.Add(MaxPHSeries);
            PHRangeChart.DefaultView.ChartArea.DataSeries.Add(minPHSeries);

            loadSevenDoRange();

        }

      
        private void loadSevenDoRange()
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

            var LastSevenDORange = (from b in waterParameterRangeDomainContext.WaterParameterRangeViews orderby b.LogDate descending select b).Take(numberOfWaterParameter);
            var SortedLastSevenDORange = from b in LastSevenDORange orderby b.LogDate select b;


            foreach (var b in SortedLastSevenDORange)
            {
                var DOC = (Convert.ToDateTime(b.LogDate) - Convert.ToDateTime(SelectedPondProductionCycle.StartDate)).TotalDays;
            
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.RangeDO), XCategory = Math.Floor(DOC).ToString() });
                MaxDOSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.MaxDO), XCategory = Math.Floor(DOC).ToString() });
                minDOSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.MinDO), XCategory = Math.Floor(DOC).ToString() });
            }
            DOrangeChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
            DOrangeChart.DefaultView.ChartArea.DataSeries.Add(MaxDOSeries);
            DOrangeChart.DefaultView.ChartArea.DataSeries.Add(minDOSeries);

            loadSevenTOMMax();
        }

        private void loadSevenTOMMax()
        {
            DataSeries lineSeries = new DataSeries();
            DataSeries StandardSeries = new DataSeries();

            ToMChart.DefaultView.ChartArea.DataSeries.Clear();
            ToMChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            ToMChart.DefaultView.ChartTitle.Content = "Total Organic Material";
            lineSeries.Definition = new LineSeriesDefinition();

            var LastSevenTom = (from b in waterParameterRangeDomainContext.WaterParameterRangeViews orderby b.LogDate descending select b).Take(numberOfWaterParameter);
            var SortedLastSevenTomMax = from b in LastSevenTom orderby b.LogDate select b;


            foreach (var b in SortedLastSevenTomMax)
            {
                var DOC = (Convert.ToDateTime(b.LogDate) - Convert.ToDateTime(SelectedPondProductionCycle.StartDate)).TotalDays;               
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.TotalOrganicMaterial), XCategory = Math.Floor(DOC).ToString() });
               
            }
            ToMChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
        }



        private void SevenDaysCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            loadSevenDaysData();
        }

        private void loadSevenDaysData()
        {
            //SelectedPondProductionCycle = this.productionCycleIDComboBox.SelectedItem as tambak.Web.PondsProductionCycle;
            int numberOfRecord = 7;
            loadXMBWChart(numberOfRecord);
            loadXWaterParameterRange(numberOfRecord);
            loadXSizeChart(numberOfRecord);
            loadXfcrChart(numberOfRecord);
            loadXWeeklyFCR(numberOfRecord);
            loadXBiomass(numberOfRecord);
            loadXPopulation(numberOfRecord);
            LoadXSurvivalRate(numberOfRecord);
            loadxADG(numberOfRecord);
            loadXCummulativeADG(numberOfRecord);
            loadxAmmonia(numberOfRecord);
            loadxNitrite(numberOfRecord);
            loadxClarityChart(numberOfRecord);
            loadxFeedingAudit(numberOfRecord);


        }

        private void loadFifteenDaysData()
        {
           // SelectedPondProductionCycle = this.productionCycleIDComboBox.SelectedItem as tambak.Web.PondsProductionCycle;
            int numberOfRecord = 15;
            loadXMBWChart(numberOfRecord);
            loadXWaterParameterRange(numberOfRecord);
            loadXSizeChart(numberOfRecord);
            loadXfcrChart(numberOfRecord);
            loadXWeeklyFCR(numberOfRecord);
            loadXBiomass(numberOfRecord);
            loadXPopulation(numberOfRecord);
            LoadXSurvivalRate(numberOfRecord);
            loadxADG(numberOfRecord);
            loadXCummulativeADG(numberOfRecord);
            loadxAmmonia(numberOfRecord);
            loadxNitrite(numberOfRecord);
            loadxClarityChart(numberOfRecord);
            loadxFeedingAudit(numberOfRecord);

        }

        private void SevenDaysCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            loadAllDataInChart();
        }

        private void FifteenDaysDataCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            SevenDaysCheckBox.IsChecked = false;
            loadFifteenDaysData();
        }

        private void FifteenDaysDataCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            loadAllDataInChart();
        }

    }
}
