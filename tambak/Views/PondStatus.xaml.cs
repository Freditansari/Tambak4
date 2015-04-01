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
using tambak.Web.DomainServices;
using tambak.Web;
using System.ServiceModel.DomainServices.Client;
namespace tambak.Views
{
    public partial class PondStatus : Page
    {
        PondsProductionCycleDS prodDomainContext = new PondsProductionCycleDS();
        TasksDS tasksDomainContext = new TasksDS();
        ProductRequiredViewDS productReqDomainContext =new ProductRequiredViewDS();
        ResultNoteDS ResultDomainContext = new ResultNoteDS();
        WaterParameterLogDS waterParamDomainContext = new WaterParameterLogDS();
        public PondStatus()
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

        private void pondDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void pondRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            try
            {
                pondStatusRadTabItem.IsEnabled = true;
                tambak.Web.Pond selectedPond = this.pondRadGridView.SelectedItem as tambak.Web.Pond;
                loadProductionCycle(selectedPond.PondID);
            }
            catch (NullReferenceException g)
            {
                pondStatusRadTabItem.IsEnabled = false;
            }
           
        }

        private void loadProductionCycle(int selectedPond)
        {
            prodDomainContext = new PondsProductionCycleDS();
            EntityQuery<tambak.Web.PondsProductionCycle> bb = from b in prodDomainContext.GetPondsProductionCyclesQuery() where b.PondID == selectedPond select b;
            LoadOperation<tambak.Web.PondsProductionCycle> res = prodDomainContext.Load(bb, new Action<LoadOperation<tambak.Web.PondsProductionCycle>>(getProdCycleCompleted), true);
        }

        private void getProdCycleCompleted(LoadOperation<Web.PondsProductionCycle> obj)
        {
            pondsProductionCycleRadGridView.ItemsSource = prodDomainContext.PondsProductionCycles;
        }

        private void pondsProductionCycleDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void taskDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void pondsProductionCycleRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            try
            {
                pondStatusRadTabItem.IsEnabled = true;
                tambak.Web.PondsProductionCycle selectedCycle = this.pondsProductionCycleRadGridView.SelectedItem as tambak.Web.PondsProductionCycle;
          
                    loadTasksDue(selectedCycle.ProductionCycleID);
                    loadWaterParameter(selectedCycle.ProductionCycleID);
            }
            catch (NullReferenceException g)
            {
                pondStatusRadTabItem.IsEnabled = false;
                
            }
            
        }

        private void loadWaterParameter(int pondsProdCycle)
        {
            waterParamDomainContext = new WaterParameterLogDS();
            EntityQuery<WaterParameterLog> bb = from b in waterParamDomainContext.GetWaterParameterLogsQuery() where b.ProductionCycleID == pondsProdCycle select b;
            LoadOperation<WaterParameterLog> res = waterParamDomainContext.Load(bb, new Action<LoadOperation<WaterParameterLog>>(getwaterParameterCompleted), true);
        }

        private void getwaterParameterCompleted(LoadOperation<WaterParameterLog> obj)
        {
            waterParameterLogRadGridView.ItemsSource = waterParamDomainContext.WaterParameterLogs;
        }

        private void loadTasksDue(int pondsProductionCycle)
        {
            DateTime todayDate = DateTime.Now;
            DateTime aweekFromToday = todayDate.AddDays(7);
            tasksDomainContext = new TasksDS();
            //EntityQuery<Task> bb = from b in tasksDomainContext.GetTasksQuery() where b.ProductionCycleID == pondsProductionCycle && b.DueDate>=todayDate && b.DueDate <= aweekFromToday select b;
            EntityQuery<Task> bb = from b in tasksDomainContext.GetTasksQuery() where b.ProductionCycleID == pondsProductionCycle select b;
            LoadOperation<Task> res = tasksDomainContext.Load(bb, new Action<LoadOperation<Task>>(gettaskCompleted), true);
        }

        private void gettaskCompleted(LoadOperation<Task> obj)
        {
            taskRadGridView.ItemsSource = tasksDomainContext.Tasks;
        }

        private void taskRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            try
            {
                tambak.Web.Task selectedTask = this.taskRadGridView.SelectedItem as tambak.Web.Task;
                loadProductRequired(selectedTask.TaskID);
                loadTasksResult(selectedTask.TaskID);
            }
            catch (NullReferenceException g)
            {
                

            }
            
        }

        //todo load data for results 

        private void loadTasksResult(int taskID)
        {
            ResultDomainContext = new ResultNoteDS();
            EntityQuery<ResultNote> bb = from b in ResultDomainContext.GetResultNotesQuery() where b.taskID == taskID select b;
            LoadOperation<ResultNote> res = ResultDomainContext.Load(bb, new Action<LoadOperation<ResultNote>>(getResultNoteCompleted), true);
        }

        private void getResultNoteCompleted(LoadOperation<ResultNote> obj)
        {
            resultNoteRadGridView.ItemsSource = ResultDomainContext.ResultNotes;
        }

        private void loadProductRequired(int taskID)
        {
            //load data for productsRequiredView
            productReqDomainContext = new ProductRequiredViewDS();
            EntityQuery<ProductRequiredView> bb = from b in productReqDomainContext.GetProductRequiredViewsQuery() where b.TaskID == taskID select b;
            LoadOperation<ProductRequiredView> res = productReqDomainContext.Load(bb, new Action<LoadOperation<ProductRequiredView>>(getProdRequirementCompleted), true);
        }

        private void getProdRequirementCompleted(LoadOperation<ProductRequiredView> obj)
        {
            productRequiredViewRadGridView.ItemsSource = productReqDomainContext.ProductRequiredViews;
        }

        private void productRequiredViewDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void resultNoteDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void waterParameterLogDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void sumProductRequiredViewDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void sumProductRequiredViewDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void sumProductRequiredViewDomainDataSource_LoadedData_2(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

    }
}
