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
using tambak.Web.DomainServices;
using tambak.Web;

namespace tambak.Views.Production
{
    public partial class ProductionReportPage : Page
    {
        public ProductionReportPage()
        {
            InitializeComponent();
            //ProductionReportReportViewer.RenderBegin += ProductionReportReportViewer_RenderBegin;
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
            //todo load is in production production cycle id in production id combobox
            selectedPond = pondDescriptionComboBox.SelectedItem as Pond;
            LoadPondsProductionCycle();
	
        }

        private void LoadPondsProductionCycle()
        {
            pondsProductionCycleDomainContext = new PondsProductionCycleDS();
            EntityQuery<tambak.Web.PondsProductionCycle> bb = from b in pondsProductionCycleDomainContext.GetPondsProductionCyclesQuery() where b.PondID == selectedPond.PondID && b.isInProduction == true select b;
            LoadOperation<tambak.Web.PondsProductionCycle> res = pondsProductionCycleDomainContext.Load(bb, new Action<LoadOperation<tambak.Web.PondsProductionCycle>>(LoadPondsProductionCycle_completed), true);
		
        }

        private void LoadPondsProductionCycle_completed(LoadOperation<Web.PondsProductionCycle> obj)
        {
            

            
            try
            {
                productionCycleIDComboBox.ItemsSource = pondsProductionCycleDomainContext.PondsProductionCycles;
                productionCycleIDComboBox.SelectedIndex = 0;
            }
            catch (Exception)
            {
                
                
            }
            

            //ProductionReportReportViewer.RenderBegin += ProductionReportReportViewer_RenderBegin;
            //todo load report when selected production cycle id selected. 
        }

        void ProductionReportReportViewer_RenderBegin(object sender, Telerik.ReportViewer.Silverlight.RenderBeginEventArgs args)
        {
            try
            {
                args.ParameterValues["ProductionCycleIDParameter"] = selectedPondProductionCycle.ProductionCycleID;
            }
            catch (Exception)
            {
                
                
            }
           
        }

        private void productionCycleIDComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedPondProductionCycle = productionCycleIDComboBox.SelectedItem as tambak.Web.PondsProductionCycle;
           
            ProductionReportReportViewer.RenderBegin += ProductionReportReportViewer_RenderBegin;

            this.ProductionReportReportViewer.ReportServiceUri = new Uri("../ReportService.svc", UriKind.RelativeOrAbsolute);
        }

        PondsProductionCycleDS pondsProductionCycleDomainContext = new PondsProductionCycleDS();

        public Pond selectedPond= new Pond();

        public tambak.Web.PondsProductionCycle selectedPondProductionCycle { get; set; }
    }
}
