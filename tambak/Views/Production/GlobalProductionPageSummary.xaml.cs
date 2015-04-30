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
    public partial class GlobalProductionPageSummary : Page
    {
        ActiveProductionCycleSummaryViewDS SummaryProductionCycleDS = new ActiveProductionCycleSummaryViewDS();
        public GlobalProductionPageSummary()
        {
            

            try
            {
                if (WebContext.Current.User.IsInRole("Manager") || WebContext.Current.User.IsInRole("Accounting") || WebContext.Current.User.IsInRole("Super Admin"))
                {


                    InitializeComponent();
                    Loaded += GlobalProductionPageSummary_Loaded;

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

        void GlobalProductionPageSummary_Loaded(object sender, RoutedEventArgs e)
        {
            loadAllActiveProductionCycle();
			
        }

        private void loadAllActiveProductionCycle()
        {
            EntityQuery<ActiveProductionCycleSamplingLogSummary> bb = from b in SummaryProductionCycleDS.GetActiveProductionCycleSamplingLogSummariesQuery() select b;
            LoadOperation<ActiveProductionCycleSamplingLogSummary> res = SummaryProductionCycleDS.Load(bb, new Action<LoadOperation<ActiveProductionCycleSamplingLogSummary>>(loadActiveProductionCycle_completed), true);
			
        }

        private void loadActiveProductionCycle_completed(LoadOperation<ActiveProductionCycleSamplingLogSummary> obj)
        {
            ActiveProductionCycleRadGridView.ItemsSource = SummaryProductionCycleDS.ActiveProductionCycleSamplingLogSummaries;
            double TotalBiomass =Convert.ToDouble( SummaryProductionCycleDS.ActiveProductionCycleSamplingLogSummaries.Sum(b => b.Biomass));
            double TotalCummulative = Convert.ToDouble(SummaryProductionCycleDS.ActiveProductionCycleSamplingLogSummaries.Sum(b => b.CummulativeFeed));
            TotalBiomassTextBlock.Text =  TotalBiomass.ToString("N", App.cultInfo);
            TotalCummulativeFeedTextBlock.Text = TotalCummulative.ToString("N", App.cultInfo);

        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

    }
}
