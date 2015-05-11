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
    public partial class NewFeedingTrayChildWindow : ChildWindow
    {

        Pond selectedPond = new Pond();
        PondsProductionCycleDS  pondProdDomainContext = new PondsProductionCycleDS();
        public FeedingTray NewFeedingTray { get; set; }
        public Web.PondsProductionCycle selectedProductionCycleID { get; set; }
        FeedingTrayDS FeedingTrayDomainContext = new FeedingTrayDS();

        public NewFeedingTrayChildWindow()
        {
            InitializeComponent();
            Loaded += NewFeedingTrayChildWindow_Loaded;
        }

        void NewFeedingTrayChildWindow_Loaded(object sender, RoutedEventArgs e)
        {
            grid1.DataContext = null;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void feedingTrayDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
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
            selectedPond = this.pondDescriptionComboBox.SelectedItem as Pond;
            loadProductionCycle();
        }

        private void loadProductionCycle()
        {
            pondProdDomainContext = new PondsProductionCycleDS();
            EntityQuery<tambak.Web.PondsProductionCycle> bb = from b in pondProdDomainContext.GetPondsProductionCyclesQuery() where b.PondID ==selectedPond.PondID && b.isInProduction == true select b;
            LoadOperation<tambak.Web.PondsProductionCycle> res = pondProdDomainContext.Load(bb, new Action<LoadOperation<tambak.Web.PondsProductionCycle>>(getProductionCycleCompleted), true);
                    
        }

        private void getProductionCycleCompleted(LoadOperation<Web.PondsProductionCycle> obj)
        {
            productionCycleIDComboBox.ItemsSource = pondProdDomainContext.PondsProductionCycles;
            productionCycleIDComboBox.SelectedIndex = 0;
        }

        private void NewFeedingTrayRecordButton_Click(object sender, RoutedEventArgs e)
        {
            NewFeedingTrayRecord();
        }

        private void NewFeedingTrayRecord()
        {
            NewFeedingTray = new FeedingTray();
            NewFeedingTray.C10 =Convert.ToDouble( c10TextBox.Text);
            NewFeedingTray.C14 = Convert.ToDouble(c14TextBox.Text);
            NewFeedingTray.C18 = Convert.ToDouble(c18TextBox.Text);
            NewFeedingTray.C6 = Convert.ToDouble(c6TextBox.Text);
            NewFeedingTray.LogDate = logDateDatePicker.SelectedDate;
            NewFeedingTray.ProductionCycleID = selectedProductionCycleID.ProductionCycleID;
            NewFeedingTray.note = noteTextBox.Text;
            NewFeedingTray.userName = WebContext.Current.User.ToString();

            FeedingTrayDomainContext.FeedingTrays.Add(NewFeedingTray);
            FeedingTrayDomainContext.SubmitChanges().Completed += FeedingTraySubmitChanges_completed;

            
        }

        private void FeedingTraySubmitChanges_completed(object sender, EventArgs e)
        {
            
        }


        
        private void productionCycleIDComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedProductionCycleID = productionCycleIDComboBox.SelectedItem as tambak.Web.PondsProductionCycle;
        }

       
    }
}

