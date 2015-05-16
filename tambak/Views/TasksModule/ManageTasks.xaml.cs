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

        ProductRequiredViewDS productRequiredDomainContext = new ProductRequiredViewDS();

        ProductRequiredDS ProductRequirementDomainContext = new ProductRequiredDS();
        public ProductRequired newProductRequirement { get; set; }
        public Product selectedProduct { get; set; }
        
        public ManageTasks()
        {
            try
            {
                if (WebContext.Current.User.IsInRole("Manager") || WebContext.Current.User.IsInRole("Field Accounting") || WebContext.Current.User.IsInRole("Super Admin"))
                {


                    InitializeComponent();
                    Loaded += ManageTasks_Loaded;

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

        void ManageTasks_Loaded(object sender, RoutedEventArgs e)
        {
            TasksReportViewer.RenderBegin += TasksReportViewer_RenderBegin;
        }

        void TasksReportViewer_RenderBegin(object sender, Telerik.ReportViewer.Silverlight.RenderBeginEventArgs args)
        {
            try
            {
                if (selectedTask.TaskID == null)
                {
                    taskRadGridView.SelectedItem = null;
                }
                else
                {
                    args.ParameterValues["TaskIDParameter"] = selectedTask.TaskID;
                }
            }
            catch (Exception g)
            {
                
                throw;
            }
                  
           
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void NewTasksButton_Click(object sender, RoutedEventArgs e)
        {
            NewTaskChildWindow newTaskCW = new NewTaskChildWindow();
            newTaskCW.Show();
            newTaskCW.Closed += newTaskCW_Closed;
        }

        void newTaskCW_Closed(object sender, EventArgs e)
        {
            loadPondProductionCycle();
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
            loadPondProductionCycle();
        }

        private void loadPondProductionCycle()
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
            this.TasksReportViewer.ReportServiceUri = new Uri("../ReportService.svc", UriKind.RelativeOrAbsolute);

            loadRequiredProducts();
        }

        private void loadRequiredProducts()
        {
            productRequiredDomainContext = new ProductRequiredViewDS();
			EntityQuery<ProductRequiredView> bb = from b in productRequiredDomainContext.GetProductRequiredViewsQuery() where b.TaskID == selectedTask.TaskID select b;
            LoadOperation<ProductRequiredView> res = productRequiredDomainContext.Load(bb, new Action<LoadOperation<ProductRequiredView>>(getProductRequiredView_completed), true);
			
        }

        private void getProductRequiredView_completed(LoadOperation<ProductRequiredView> obj)
        {
            productRequiredViewDataGrid.ItemsSource = productRequiredDomainContext.ProductRequiredViews;
        }

        private void updateTaskButton_Click(object sender, RoutedEventArgs e)
        {
            if (isDoneCheckBox.IsChecked == true)
            {
                selectedTask.isDone = true;
                selectedTask.EndDate = DateTime.Now;
            }
            taskDomainContext.SubmitChanges();
        }

        private void taskNotDoneViewDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void productRequiredViewDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void AddRequiredProductButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                newProductRequirement = new ProductRequired();
                newProductRequirement.ProductID = selectedProduct.ProductID;
                newProductRequirement.TaskID = selectedTask.TaskID;
                newProductRequirement.Amount = Convert.ToInt32(QtyNeededTextBox.Text);

                ProductRequirementDomainContext.ProductRequireds.Add(newProductRequirement);
                ProductRequirementDomainContext.SubmitChanges().Completed += addProductRequirmentCompleted;
            }
            catch (Exception)
            {
            }
            
        }

        private void addProductRequirmentCompleted(object sender, EventArgs e)
        {
            loadRequiredProducts();
        }

        

        private void productNameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedProduct = this.productNameComboBox.SelectedItem as Product;
        }

        private void productDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        
    }
}
