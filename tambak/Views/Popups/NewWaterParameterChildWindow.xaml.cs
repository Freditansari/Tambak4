using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.ServiceModel.DomainServices.Client;
using System.Text.RegularExpressions;
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
    public partial class NewWaterParameterChildWindow : ChildWindow
    {

       


        Pond selectedPond = new Pond();
        tambak.Web.PondsProductionCycle selectedProductionCycle = new tambak.Web.PondsProductionCycle();
        PondsProductionCycleDS ProductionCycleDomainContext = new PondsProductionCycleDS();
        public NewWaterParameterChildWindow()
        {
            InitializeComponent();
            Loaded += NewWaterParameterChildWindow_Loaded;
        }

        void NewWaterParameterChildWindow_Loaded(object sender, RoutedEventArgs e)
        {
            grid1.DataContext = null;
            cleartextBoxes();
        }

        private void cleartextBoxes()
        {
            try
            {
                newWaterparam = new WaterParameterLog();
                newWaterparam.Amonnia = null;
                newWaterparam.Bacteria = null;
                newWaterparam.DissolvedOxygen = null;
                newWaterparam.Paddlewheel = null;
                newWaterparam.Phospate = null;
                newWaterparam.Planktons = null;
                newWaterparam.Salinity = null;
                newWaterparam.Temperature = null;
                newWaterparam.Vibrio = null;
                newWaterparam.ammonium = null;
                newWaterparam.nitrate = null;
                newWaterparam.nitrite = null;
                newWaterparam.pH = null;
                newWaterparam.PotentialRedox = null;


                grid1.DataContext = newWaterparam;
            }
            catch (Exception)
            {
            }
        }


        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void waterParameterLogDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
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

        private void pondDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
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

            try
            {
                ProductionCycleDomainContext = new PondsProductionCycleDS();
                EntityQuery<tambak.Web.PondsProductionCycle> bb = from b in ProductionCycleDomainContext.GetPondsProductionCyclesQuery() where b.PondID == selectedPond.PondID && b.isInProduction == true select b;
                LoadOperation<tambak.Web.PondsProductionCycle> res = ProductionCycleDomainContext.Load(bb, new Action<LoadOperation<tambak.Web.PondsProductionCycle>>(LoadProduction_cycle_completed), true);
            }
            catch (Exception)
            {
            }

        }

        private void LoadProduction_cycle_completed(LoadOperation<Web.PondsProductionCycle> obj)
        {
            productionCycleIDComboBox.ItemsSource = ProductionCycleDomainContext.PondsProductionCycles;
            this.productionCycleIDComboBox.SelectedIndex = 0;
        }

        private void productionCycleIDComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedProductionCycle = this.productionCycleIDComboBox.SelectedItem as tambak.Web.PondsProductionCycle;

        }


        public WaterParameterLog newWaterparam { get; set; }

        private void AddWaterParameterButton_Click(object sender, RoutedEventArgs e)
        {
            SaveWaterParameter();
        }

        private void SaveWaterParameter()
        {
            //save water parameter to datagrid. 


            waterParamLogDomainContext = new WaterParameterLogDS();
            WaterParameterLog newWaterParameter = new WaterParameterLog();
            try
            {
                double? amonia =  Convert.ToDouble(amonniaTextBox.Text);
                newWaterParameter.Amonnia = amonia;
            }
            catch (Exception)
            {

                newWaterParameter.Amonnia = null;
            }

            try
            {
                newWaterParameter.Bacteria = bacteriaTextBox.Text;
            }
            catch (Exception)
            {

                newWaterParameter.Bacteria = null;
            }

            try
            {
                double DO= Convert.ToDouble(dissolvedOxygenTextBox.Text);
                newWaterParameter.DissolvedOxygen = DO;
            }
            catch (Exception)
            {

                newWaterParameter.DissolvedOxygen = null;
            }

            try
            {
                newWaterParameter.Paddlewheel = Convert.ToInt32(paddlewheelTextBox.Text);
            }
            catch (Exception)
            {

                newWaterParameter.Paddlewheel = null;
            }
            try
            {
                newWaterParameter.Phospate = Convert.ToDouble(phospateTextBox.Text);
            }
            catch (Exception)
            {

                newWaterParameter.Phospate = null;
            }
            try
            {
                newWaterParameter.Planktons = Convert.ToInt32(planktonsTextBox.Text);
            }
            catch (Exception)
            {

                newWaterParameter.Planktons = null;
            }

     
            newWaterParameter.ProductionCycleID = selectedProductionCycle.ProductionCycleID;

            try
            {
                newWaterParameter.Salinity = Convert.ToDouble(salinityTextBox.Text);
            }
            catch (Exception)
            {

                newWaterParameter.Salinity = null;
            }
            try
            {
                newWaterParameter.Temperature = Convert.ToDouble(temperatureTextBox.Text);
            }
            catch (Exception)
            {

                newWaterParameter.Temperature = null;
            }
            try
            {
                newWaterParameter.Vibrio = vibrioTextBox.Text;
            }
            catch (Exception)
            {

                newWaterParameter.Vibrio = null;
            }
            try
            {
                newWaterParameter.ammonium = Convert.ToDouble(ammoniumTextBox.Text);
            }
            catch (Exception)
            {

                newWaterParameter.ammonium = null;
            }
            try
            {
                newWaterParameter.nitrate = Convert.ToDouble(nitrateTextBox.Text);
            }
            catch (Exception)
            {

                newWaterParameter.nitrate = null;
            }



            newWaterParameter.UserID = WebContext.Current.User.ToString();

            try
            {
                newWaterParameter.nitrite = Convert.ToDouble(nitriteTextBox.Text);
            }
            catch (Exception)
            {

                newWaterParameter.nitrite = null;

            }

            try
            {
                newWaterParameter.pH = Convert.ToDouble(pHTextBox.Text);
            }
            catch (Exception)
            {

                newWaterParameter.pH = null;
            }

            try
            {
                newWaterParameter.PotentialRedox = Convert.ToDouble(potentialRedoxTextBox.Text);
            }
            catch (Exception)
            {
                newWaterParameter.PotentialRedox = null;

            }

            try
            {
                newWaterParameter.LogDate = logDateDatePicker.SelectedValue.Value;
            }
            catch
            {
                // newWaterParameter.LogDate = null;
            }

            try
            {
                newWaterParameter.alkalinity =Convert.ToDouble( alkalinityTextBox.Text);        
            }
            catch (Exception)
            {

                newWaterParameter.alkalinity = null;

            }
            try
            {
                newWaterParameter.TotalOrganicMaterial = Convert.ToDouble(totalOrganicMaterialTextBox.Text);
            }
            catch (Exception)
            {

                newWaterParameter.TotalOrganicMaterial = null;

            }
            try
            {
                newWaterParameter.TotalOrganicMaterial = Convert.ToDouble(totalOrganicMaterialTextBox.Text);
            }
            catch (Exception)
            {

                newWaterParameter.TotalOrganicMaterial = null;

            }
            try
            {
                newWaterParameter.Clarity = Convert.ToDouble(clarityTextBox.Text);
            }
            catch (Exception)
            {

                newWaterParameter.Clarity = null;

            }


            newWaterParameter.Note = noteTextBox.Text;
            newWaterParameter.isVibrioExist = isVibrioExistCheckBox.IsChecked;
            newWaterParameter.IMNV = iMNVCheckBox.IsChecked;
            newWaterParameter.WhiteSpot = whiteSpotCheckBox.IsChecked;




            waterParamLogDomainContext.WaterParameterLogs.Add(newWaterParameter);
            waterParamLogDomainContext.SubmitChanges().Completed += waterparameterSaved;




        }

        private void waterparameterSaved(object sender, EventArgs e)
        {
            cleartextBoxes();
        }


        public WaterParameterLogDS waterParamLogDomainContext { get; set; }
    }
}



