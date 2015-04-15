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
using System.Text.RegularExpressions;
using tambak.Web;
using tambak.Web.DomainServices;
using System.ServiceModel.DomainServices.Client;

namespace tambak.Views
{
    public partial class PondsProductionCycle : Page
    {
        //todo known bug. the density in radgridview will change when the selection changed. 
        PondsProductionCycleDS pondsCycleDomainContext = new PondsProductionCycleDS();
        runCmdShellServiceReference.RunCmdShellClient runCmdShellClient = new runCmdShellServiceReference.RunCmdShellClient();
        
        public PondsProductionCycle()
        {
            try
            {
                if (WebContext.Current.User.IsInRole("Technician") || WebContext.Current.User.IsInRole("Super Admin"))
                {
                    InitializeComponent();

                }
                else
                {
                    throw new ArgumentException("Insufficient Access. Please login with higher access.");
                }
            }

            catch (ArgumentException g)
            {
                MessageBox.Show(g.Message);

            }
           
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
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

        private void contactDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void pondIDTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            

        }

        private void numberOfFryTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(numberOfFryTextBox.Text, "[0-9]"))
                {
                    throw new ArgumentException("numbers only");
                }
                else
                {
                    int pondSize = Convert.ToInt32( pondSizeTextBox.Text);
                    int numOfFry = Convert.ToInt32( numberOfFryTextBox.Text);

                    int pondDensity = numOfFry/pondSize;

                    densityTextBox.Text =Convert.ToString( pondDensity );

                }

            }
            catch (ArgumentException f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {

            //clear fields, enable new production cycle and disable the save button. 
            densityTextBox.Text = "";
            endDateDatePicker.SelectedDate = null;
            fryOriginTextBox.Text = "";
            noteTextBox.Text = "";
            numberOfFryTextBox.Text = "";
            productionCycleIDTextBox.Text = "";
            startDateDatePicker.SelectedDate =  null;
            //technicianTextBox.Text =  ""; ==> ommited due to bug on clear button that cause unable to insert. 
            pondIDTextBox1.Text = pondIDTextBox.Text;
            isInProductionCheckBox.IsChecked=false;
            NewProdCycleButton.IsEnabled = true;
            SaveButton.IsEnabled = false;

        }

        private void contactIDTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            technicianTextBox.Text = contactIDTextBox.Text;
        }

        private void NewProdCycleButton_Click(object sender, RoutedEventArgs e)
        {
            //save production cycle to database procedures, enable save button, disable new production cycle button. 

            tambak.Web.PondsProductionCycle newProdCycle = new tambak.Web.PondsProductionCycle();
            newProdCycle.Density = Convert.ToDouble( densityTextBox.Text);
            newProdCycle.EndDate = endDateDatePicker.SelectedDate;
            newProdCycle.FryOrigin = fryOriginTextBox.Text;
            newProdCycle.isInProduction = isInProductionCheckBox.IsChecked;
            newProdCycle.NumberOfFry = Convert.ToInt32(numberOfFryTextBox.Text);
            newProdCycle.StartDate = startDateDatePicker.SelectedDate;
            newProdCycle.Technician = Convert.ToInt32(contactIDTextBox.Text);
            newProdCycle.Note = noteTextBox.Text;
            newProdCycle.PondID = Convert.ToInt32(pondIDTextBox.Text);

            pondsCycleDomainContext.PondsProductionCycles.Add(newProdCycle);
            pondsCycleDomainContext.SubmitChanges().Completed += PondCycleSubmitChanges_completed;

            SaveButton.IsEnabled = true;
            NewProdCycleButton.IsEnabled = false;

            
            
        }

        private void PondCycleSubmitChanges_completed(object sender, EventArgs e)
        {
            string PythonCommands = "python C:\\LeoRepo\\perkiraanpakan.py " + App.DatabaseName;
            runCmdShellClient.runAverageCommandAsync(PythonCommands);
            //runCmdShellClient.runAverageCommandCompleted += runCmdShellClient_runAverageCommandCompleted;
        }

        private void pondIDTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            //this code is to bind with the second pond ID
            pondIDTextBox1.Text = pondIDTextBox.Text;

            //put ponds selected production cycle 
            pondsCycleDomainContext = new PondsProductionCycleDS();
            EntityQuery<tambak.Web.PondsProductionCycle> bb = from b in pondsCycleDomainContext.GetPondsProductionCyclesQuery() where b.PondID == Convert.ToInt32(pondIDTextBox.Text) select b;
            LoadOperation<tambak.Web.PondsProductionCycle> res = pondsCycleDomainContext.Load(bb, new Action<LoadOperation<tambak.Web.PondsProductionCycle>>(getPondsProdCompleted), true);
        }

        private void getPondsProdCompleted(LoadOperation<Web.PondsProductionCycle> obj)
        {
            pondsProductionCycleRadGridView.ItemsSource = pondsCycleDomainContext.PondsProductionCycles;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //update procedures here. 
                pondsCycleDomainContext = new PondsProductionCycleDS();

                EntityQuery<tambak.Web.PondsProductionCycle> bb = from b in pondsCycleDomainContext.GetPondsProductionCyclesQuery() where b.ProductionCycleID == Convert.ToInt32(productionCycleIDTextBox.Text) select b;
                LoadOperation<tambak.Web.PondsProductionCycle> res = pondsCycleDomainContext.Load(bb, new Action<LoadOperation<tambak.Web.PondsProductionCycle>>(getPondsCycleCompleted), true);
            
            
        }

        private void getPondsCycleCompleted(LoadOperation<tambak.Web.PondsProductionCycle> obj)
        {
            tambak.Web.PondsProductionCycle bc = obj.Entities.First();

            bc.Density = Convert.ToDouble(densityTextBox.Text);
            bc.EndDate = endDateDatePicker.SelectedDate;
            bc.FryOrigin = fryOriginTextBox.Text;
            bc.isInProduction = isInProductionCheckBox.IsChecked;
            bc.NumberOfFry = Convert.ToInt32(numberOfFryTextBox.Text);
            bc.StartDate = startDateDatePicker.SelectedDate;
            bc.Technician = Convert.ToInt32(contactIDTextBox.Text);
            bc.Note = noteTextBox.Text;
            bc.PondID = Convert.ToInt32(pondIDTextBox.Text);
            pondsCycleDomainContext.SubmitChanges();
        }

        private void targetDensityTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                targetFriesTextBox.Text = Convert.ToString(Convert.ToInt32(targetDensityTextBox.Text) * Convert.ToInt32(pondSizeTextBox.Text));
            }
            catch (NullReferenceException g)
            {
            }
            catch (FormatException f)
            {
            }
        }

        private void pondsProductionCycleRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            //todo change selection procedures here. 
            //todo fill the fields next to the rad grid view
            try
            {
                tambak.Web.PondsProductionCycle selectedCycle = this.pondsProductionCycleRadGridView.SelectedItem as tambak.Web.PondsProductionCycle;
                densityTextBox.Text = selectedCycle.Density.ToString();
                endDateDatePicker.SelectedDate = selectedCycle.EndDate;
                fryOriginTextBox.Text = selectedCycle.FryOrigin.ToString();
                noteTextBox.Text = selectedCycle.Note.ToString();
                numberOfFryTextBox.Text = selectedCycle.NumberOfFry.ToString();
                pondIDTextBox.Text = selectedCycle.PondID.ToString();
                productionCycleIDTextBox.Text = selectedCycle.ProductionCycleID.ToString();
                startDateDatePicker.SelectedDate = selectedCycle.StartDate;
                technicianTextBox.Text = selectedCycle.Technician.ToString();
                isInProductionCheckBox.IsChecked = selectedCycle.isInProduction;
            }
            catch (NullReferenceException g)
            { 
            }

        }

        private void pondRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            tambak.Web.Pond selectedPond = this.pondRadGridView.SelectedItem as tambak.Web.Pond;
            pondIDTextBox.Text = selectedPond.PondID.ToString();
            loadPondRadGridView(selectedPond.PondID);
        }

        private void loadPondRadGridView(int pondID)
        {
            pondsCycleDomainContext = new PondsProductionCycleDS();
            EntityQuery<tambak.Web.PondsProductionCycle> bb = from b in pondsCycleDomainContext.GetPondsProductionCyclesQuery() where b.PondID == pondID select b;
            LoadOperation<tambak.Web.PondsProductionCycle> res = pondsCycleDomainContext.Load(bb, new Action<LoadOperation<tambak.Web.PondsProductionCycle>>(getPondProductionCycle), true);
        }

        private void getPondProductionCycle(LoadOperation<Web.PondsProductionCycle> obj)
        {
            pondsProductionCycleRadGridView.ItemsSource = pondsCycleDomainContext.PondsProductionCycles;
        }

    }
}
