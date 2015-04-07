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
using tambak.Web;
using tambak.Web.DomainServices;

namespace tambak.Views.TasksModule
{
    public partial class ManageTasks : Page
    {
        Pond selectedPond = new Pond();
        tambak.Web.PondsProductionCycle selectedProductionCycle = new tambak.Web.PondsProductionCycle();
        PondsProductionCycleDS ProductionCycleDomainContext = new PondsProductionCycleDS();
        TasksDS taskDomainContext = new TasksDS();
        Task selectedTask = new Task();

        
        
        public ManageTasks()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void NewTasksButton_Click(object sender, RoutedEventArgs e)
        {
            NewTaskChildWindow newTaskCW = new NewTaskChildWindow();
            newTaskCW.Show();
        }

        private void pondDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
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

        private void pondDescriptionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedPond = this.pondDescriptionComboBox.SelectedItem as Pond;

			EntityQuery<tambak.Web.PondsProductionCycle> bb = from b in ProductionCycleDomainContext.GetPondsProductionCyclesQuery() where b.PondID == selectedPond.PondID && b.isInProduction == true select b;
            LoadOperation<tambak.Web.PondsProductionCycle> res = ProductionCycleDomainContext.Load(bb, new Action<LoadOperation<tambak.Web.PondsProductionCycle>>(getPondsProductionCycle_completed), true);
			
        }

        private void getPondsProductionCycle_completed(LoadOperation<Web.PondsProductionCycle> obj)
        {
            try
            {
                selectedProductionCycle = obj.Entities.FirstOrDefault();

                taskDomainContext = new TasksDS();
                EntityQuery<Task> bb = from b in taskDomainContext.GetTasksQuery() where b.ProductionCycleID == selectedProductionCycle.ProductionCycleID && b.PondID == selectedPond.PondID select b;
                LoadOperation<Task> res = taskDomainContext.Load(bb, new Action<LoadOperation<Task>>(getTask_Completed), true);
			
            }
            catch (Exception g)
            {
                
                
            }
                    
          
        }

        private void getTask_Completed(LoadOperation<Task> obj)
        {
            try
            {
                taskRadGridView.ItemsSource = taskDomainContext.Tasks;
                selectedTask = obj.Entities.FirstOrDefault();
                grid2.DataContext = selectedTask;
                
            }
            catch (Exception g)
            {
                
                
            }
                    
        }

        private void taskRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            selectedTask = this.taskRadGridView.SelectedItem as Task;
            grid2.DataContext = selectedTask;
        }

    }
}
