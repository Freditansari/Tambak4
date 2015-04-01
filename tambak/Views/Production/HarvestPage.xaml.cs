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
    public partial class HarvestPage : Page
    {
        public Pond SelectedPond { get; set; }
        PondsProductionCycleDS ProductionCycleDomainContext = new PondsProductionCycleDS();
        public Web.PondsProductionCycle SelectedProductionCycle { get; set; }
        Harvest newHarvest = new Harvest();
        CurrentActivePondsViewDS currentActivePondDomainContext = new CurrentActivePondsViewDS();
        SamplingLogDS samplingLogDomainContext = new SamplingLogDS();
        SamplingLog SelectedSamplingLog;
        HarvestDS HarvestDomainContext = new HarvestDS();



        public HarvestPage()
        {
            try
            {
                if (WebContext.Current.User.IsInRole("Manager") || WebContext.Current.User.IsInRole("Field Accounting") || WebContext.Current.User.IsInRole("Super Admin"))
                {

                    InitializeComponent();
                    Loaded += HarvestPage_Loaded;
                  
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

        void HarvestPage_Loaded(object sender, RoutedEventArgs e)
        {
            grid2.DataContext = newHarvest;
            isFinalHarvestCheckBox.IsChecked = false;
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

        private void harvestDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void harvestDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void pondDescriptionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedPond = this.pondDescriptionComboBox.SelectedItem as Pond;
            //SelectedPondID = SelectedPond.PondID;

            EntityQuery<tambak.Web.PondsProductionCycle> bb = from b in ProductionCycleDomainContext.GetPondsProductionCyclesQuery() where b.PondID == SelectedPond.PondID && b.isInProduction == true select b;
            LoadOperation<tambak.Web.PondsProductionCycle> res = ProductionCycleDomainContext.Load(bb, new Action<LoadOperation<tambak.Web.PondsProductionCycle>>(getPondProductionCycle_completed), true);

   
			
        }

        private void getPondProductionCycle_completed(LoadOperation<Web.PondsProductionCycle> obj)
        {
          


            try
            {
                SelectedProductionCycle = obj.Entities.FirstOrDefault();
                productionCycleIDTextBox.Text = SelectedProductionCycle.ProductionCycleID.ToString();
                EntityQuery<CurrentActivePond> bb = from b in currentActivePondDomainContext.GetCurrentActivePondsQuery() where b.ProductionCycleID == SelectedProductionCycle.ProductionCycleID select b;
                LoadOperation<CurrentActivePond> res = currentActivePondDomainContext.Load(bb, new Action<LoadOperation<CurrentActivePond>>(getCurrentActivePond_completed), true);

                EntityQuery<SamplingLog> bz = from bk  in samplingLogDomainContext.GetSamplingLogsQuery() where bk.ProductionCycleID == SelectedProductionCycle.ProductionCycleID orderby bk.Age descending select bk;
                LoadOperation<SamplingLog> resz = samplingLogDomainContext.Load(bz, new Action<LoadOperation<SamplingLog>>(getSamplingLog_completed), true);


			    EntityQuery<Harvest> bl = from c in HarvestDomainContext.GetHarvestsQuery() where c.ProductionCycleID == SelectedProductionCycle.ProductionCycleID select c;
                LoadOperation<Harvest> resc = HarvestDomainContext.Load(bl, new Action<LoadOperation<Harvest>>(loadHarvest_completed), true);
			
			

            }
            catch (NullReferenceException g)
            {
                ageTextBox.Text = "";
            }
            catch (Exception g)
            {


            }
        }

        private void loadHarvest_completed(LoadOperation<Harvest> obj)
        {
            harvestRadGridView.ItemsSource = HarvestDomainContext.Harvests;
        }

        private void getSamplingLog_completed(LoadOperation<SamplingLog> obj)
        {

            try
            {
                SelectedSamplingLog = obj.Entities.FirstOrDefault();
                sizeTextBox.Text = SelectedSamplingLog.Size.ToString();
                weightTextBox.Text = SelectedSamplingLog.Biomass.ToString();
                calculatePopulation();

            }
            catch (Exception g)
            {
                sizeTextBox.Text = "0";
                weightTextBox.Text = "0";
                
            }
        }

        private void calculatePopulation()
        {
            try
            {
                //rom b in currentActivePondDomainContext.GetCurrentActivePondsQuery() where b.ProductionCycleID == SelectedProductionCycle.ProductionCycleID select b;
                double? sumPreviousHarvestedPopulation = (from b in HarvestDomainContext.Harvests where b.ProductionCycleID == SelectedProductionCycle.ProductionCycleID select b.HarvestedPopulation).Sum();
                if (sumPreviousHarvestedPopulation == null)
                {
                    sumPreviousHarvestedPopulation = 0;
                }
                

                harvestedPopulationTextBox.Text = Convert.ToString(Convert.ToDouble(sizeTextBox.Text) * Convert.ToDouble(weightTextBox.Text));
                populationLeftTextBox.Text = Convert.ToString(Convert.ToDouble(numberOfFryTextBox.Text) - Convert.ToDouble(harvestedPopulationTextBox.Text)-sumPreviousHarvestedPopulation);
            }
            catch (DivideByZeroException g)
            {
                MessageBox.Show("Check Size and Weight " + g.Message);

            }
            catch (Exception g)
            {
            }
        }

        private void getCurrentActivePond_completed(LoadOperation<CurrentActivePond> obj)
        {
            try
            {
                CurrentActivePond bc = obj.Entities.FirstOrDefault();
                ageTextBox.Text = bc.DOC.ToString();
                monthTextBox.Text = DateTime.Now.Month.ToString();
                numberOfFryTextBox.Text = bc.NumberOfFry.ToString();
                pondIDTextBox.Text = bc.PondID.ToString();
                productionCycleIDTextBox.Text = bc.ProductionCycleID.ToString();
                weightTextBox.Text = "0";




            }
            catch (Exception g)
            {
                ageTextBox.Text = "";
            }
        }

        private void sizeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            calculatePopulation();
        }

        private void weightTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            calculatePopulation();
        }

        private void saveHarvestLogButton_Click(object sender, RoutedEventArgs e)
        {
            Harvest newHarvest = new Harvest();
            newHarvest.Age = Convert.ToInt32(ageTextBox.Text);
            newHarvest.HarvestedPopulation = Convert.ToDouble(harvestedPopulationTextBox.Text);
            newHarvest.Month = Convert.ToInt32(monthTextBox.Text);
            newHarvest.NumberOfFry = Convert.ToDouble(numberOfFryTextBox.Text);
            newHarvest.PondID = Convert.ToInt32(pondIDTextBox.Text);
            newHarvest.PopulationLeft = Convert.ToDouble(populationLeftTextBox);
            newHarvest.ProductionCycleID = Convert.ToInt32(productionCycleIDTextBox.Text);
            newHarvest.Size = Convert.ToDouble(sizeTextBox.Text);
            newHarvest.Weight = Convert.ToDouble(weightTextBox.Text);
            newHarvest.isFinalHarvest = isFinalHarvestCheckBox.IsChecked;

            HarvestDomainContext.Harvests.Add(newHarvest);
            HarvestDomainContext.SubmitChanges().Completed += HarvestSubmitChanges_completed;


        }

        void HarvestSubmitChanges_completed(object sender, EventArgs e)
        {
            //todo change if is final harvest update ponds production cycle isInProduction 
            //
        }




     
    }
}
