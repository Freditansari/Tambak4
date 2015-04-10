﻿using System;
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
        Pond selectedPond = new Pond();
        SamplingLogDS SamplingLogDomainContext = new SamplingLogDS();

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

            SizeChart.DefaultView.ChartArea.DataSeries.Clear();
            SizeChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            SizeChart.DefaultView.ChartTitle.Content = "Size";
            lineSeries.Definition = new LineSeriesDefinition();
            foreach (var b in SamplingLogDomainContext.SamplingLogs)
            {
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.Size), XCategory = b.Age.ToString() });
            }
            SizeChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
        }

        private void loadMBWChart()
        {
            DataSeries lineSeries = new DataSeries();

            agetoMBWChart.DefaultView.ChartArea.DataSeries.Clear();
            agetoMBWChart.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed;
            agetoMBWChart.DefaultView.ChartTitle.Content = "MBW";
            lineSeries.Definition = new LineSeriesDefinition();
            foreach (var b in SamplingLogDomainContext.SamplingLogs)
            {
                lineSeries.Add(new DataPoint() { YValue = Convert.ToDouble(b.MedianBodyWeight), XCategory = b.Age.ToString() });
            }
            agetoMBWChart.DefaultView.ChartArea.DataSeries.Add(lineSeries);
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
        }

        private void productionCycleIDComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedPondProductionCycle = this.productionCycleIDComboBox.SelectedItem as tambak.Web.PondsProductionCycle;
            loadSamplingLog();
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


       
    }
}
