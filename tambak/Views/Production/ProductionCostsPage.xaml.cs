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
using System.Windows.Data;
using tambak.Web;
using tambak.Web.DomainServices;
using System.ServiceModel.DomainServices.Client;
using System.Globalization;

namespace tambak.Views.Production
{
    public partial class ProductionCostsPage : Page
    {
        public Pond SelectedPond { get; set; }

        public PondsProductionCycleDS PondsProductionCycleDomainContext { get; set; }
        public Web.PondsProductionCycle SelectedPondProductionCycle { get; set; }
        CultureInfo cultInfo = new CultureInfo(App.cultInfo.ToString());

        public ProductionCostsPage()
        {
            try
            {
                if (WebContext.Current.User.IsInRole("Manager") || WebContext.Current.User.IsInRole("Field Accounting") || WebContext.Current.User.IsInRole("Super Admin"))
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

        private void productionCycleCostDetailViewDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
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

            PondsProductionCycleDomainContext = new PondsProductionCycleDS();
            EntityQuery<tambak.Web.PondsProductionCycle> bb = from b in PondsProductionCycleDomainContext.GetPondsProductionCyclesQuery() where b.PondID == SelectedPond.PondID select b;
            LoadOperation<tambak.Web.PondsProductionCycle> res = PondsProductionCycleDomainContext.Load(bb, new Action<LoadOperation<tambak.Web.PondsProductionCycle>>(loadPondproductionCycle_completed), true);
			
        }

        private void loadPondproductionCycle_completed(LoadOperation<Web.PondsProductionCycle> obj)
        {
            try
            {
                productionCycleIDComboBox.ItemsSource = PondsProductionCycleDomainContext.PondsProductionCycles;
                productionCycleCostDetailViewRadGridView.ItemsSource = null;
                TotalCostTextBlock.Text = "0";
            }
            catch (Exception g)
            {
            }
        }

        private void productionCycleIDComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedPondProductionCycle = this.productionCycleIDComboBox.SelectedItem as tambak.Web.PondsProductionCycle;

            loadProductionCycleCost();

        }

        private void loadProductionCycleCost()
        {
            try
            {
                productionCycleCostDomainContext = new ProductionCycleCostDetailViewDS();
                EntityQuery<ProductionCycleCostDetailView> bb = from b in productionCycleCostDomainContext.GetProductionCycleCostDetailViewsQuery() where b.ProductionCycleID == SelectedPondProductionCycle.ProductionCycleID select b;
                LoadOperation<ProductionCycleCostDetailView> res = productionCycleCostDomainContext.Load(bb, new Action<LoadOperation<ProductionCycleCostDetailView>>(getProductionCycleCost_completed), true);
            }
            catch (Exception g)
            {

            }
			
        }

        private void getProductionCycleCost_completed(LoadOperation<ProductionCycleCostDetailView> obj)
        {
            try
            {
                TotalCostPerProductionCycle =Convert.ToDecimal( (from b in productionCycleCostDomainContext.ProductionCycleCostDetailViews select b.Cost).Sum());
                TotalCostTextBlock.Text = TotalCostPerProductionCycle.ToString("C", cultInfo);
                productionCycleCostDetailViewRadGridView.ItemsSource = productionCycleCostDomainContext.ProductionCycleCostDetailViews;
            }
            catch(Exception g)
            {
                productionCycleCostDetailViewRadGridView.ItemsSource = null;
                TotalCostTextBlock.Text = "0";
            }
        }
        Decimal TotalCostPerProductionCycle;

       ProductionCycleCostDetailViewDS productionCycleCostDomainContext = new ProductionCycleCostDetailViewDS();




        
    }
}
