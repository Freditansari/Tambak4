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
    public partial class NewTasksPage : Page
    {
        PondsProductionCycleDS pondsProductionCycleDomainContext = new PondsProductionCycleDS();
        PondsDS pondsDomainContext = new PondsDS();
        EmployeeNameView selectedEmployee;
        Task newTask = new Task();
        public tambak.Web.Pond selectedPond { get; set; }

        public TasksDS tasksDomainContext { get; set; }
        bool hasGotFocus = false;


        public NewTasksPage()
        {
            InitializeComponent();
            Loaded += NewTasksPage_Loaded;
        }

        void NewTasksPage_Loaded(object sender, RoutedEventArgs e)
        {
            //grid3.DataContext = newTask;
            PriorityComboBox.ItemsSource = LoadComboBoxData();
            StatusComboBox.ItemsSource = LoadStatusComboBoxData();
            //CleanTask();
            LayoutRoot.GotFocus +=LayoutRoot_GotFocus;
            //grid3.DataContext = newTask; 
        }

        private string[] LoadComboBoxData()
        {
            string[] strArray =
            {
              "Normal Priority",
              "Low Priority",
              "Urgent"
            };
            return strArray;
        }

        private string[] LoadStatusComboBoxData()
        {
            string[] strArray =
            {
             "Ordered",
             "Started",
             "Finished",
             "Pending"
            };
            return strArray;
        }
        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void employeeNameViewDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
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
            selectedPond = this.pondDescriptionComboBox.SelectedItem as tambak.Web.Pond;
			EntityQuery<tambak.Web.PondsProductionCycle> bb = from b in pondsProductionCycleDomainContext.GetPondsProductionCyclesQuery() where b.PondID == selectedPond.PondID && b.isInProduction == true  select b;
            LoadOperation<tambak.Web.PondsProductionCycle> res = pondsProductionCycleDomainContext.Load(bb, new Action<LoadOperation<tambak.Web.PondsProductionCycle>>(getProductionCycle_completed), true);
			
        }

        private void getProductionCycle_completed(LoadOperation<Web.PondsProductionCycle> obj)
        {
            try 
	        {	        
               tambak.Web.PondsProductionCycle bc = obj.Entities.First();
               productionCycleIDTextBox.Text = bc.ProductionCycleID.ToString();
	        }
	        catch (Exception)
	        {

                productionCycleIDTextBox.Text = "";
	        }
          
        }

        private void addNewTask()
        {
            try
            {
                if (productionCycleIDTextBox.Text == "")
                {
                    throw new Exception("Please Select an Active Production Cycle");
                }
                if (dueDateRadDateTimePicker.SelectedValue == null)
                {
                    throw new Exception("Please Select due date");
                }

                string selectedPriority = this.PriorityComboBox.SelectedItem as string;
                string selectedStatus = this.StatusComboBox.SelectedItem as string;


                tasksDomainContext = new TasksDS();
                newTask = new Task();
                newTask.Attachments = attachmentsTextBox.Text;
                newTask.CompletePercentage = Convert.ToDouble(completePercentageTextBox.Text);
                newTask.Description = descriptionTextBox.Text;
                newTask.DueDate = dueDateRadDateTimePicker.SelectedValue;
                newTask.EndDate = endDateRadDateTimePicker.SelectedValue;
                newTask.Priority = selectedPriority;
                newTask.ProductionCycleID = Convert.ToInt32(productionCycleIDTextBox.Text);
                newTask.ReccurencePattern = reccurencePatternTextBox.Text;
                newTask.StartDate = startDateRadDateTimePicker.SelectedValue;
                newTask.Status = selectedStatus;
                newTask.PondID = selectedPond.PondID;
                newTask.Title = titleTextBox.Text;
                newTask.UserId = WebContext.Current.User.ToString();
                //newTask.assignedTo = Convert.ToInt32(assignedToTextBox.Text);
                newTask.assignedTo = selectedEmployee.ContactID;
                newTask.plannedManHours = Convert.ToDouble(plannedManHoursTextBox.Text);
                saveNewTask();
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }
        private void CleanTask()
        {
            try
            {
                string selectedPriority = this.PriorityComboBox.SelectedItem as string;
                string selectedStatus = this.StatusComboBox.SelectedItem as string;

                attachmentsTextBox.Text = "";
                completePercentageTextBox.Text = "0";
                descriptionTextBox.Text = "";
                dueDateRadDateTimePicker.SelectedValue = null;
                endDateRadDateTimePicker.SelectedValue = null;

                productionCycleIDTextBox.Text = "";
                reccurencePatternTextBox.Text = "";
                startDateRadDateTimePicker.SelectedValue = null;
                titleTextBox.Text = "";
                newTask.UserId = WebContext.Current.User.ToString();
                //newTask.assignedTo = Convert.ToInt32(assignedToTextBox.Text);
                
                plannedManHoursTextBox.Text ="0";


                tasksDomainContext = new TasksDS();
                newTask = new Task();
                newTask.Attachments = "";
                newTask.CompletePercentage = 0;
                newTask.Description = "";
                newTask.DueDate = null;
                newTask.EndDate = null;
                newTask.Priority = "";
                //newTask.ProductionCycleID = Convert.ToInt32("0");
                newTask.ProductionCycleID = null;

                newTask.ReccurencePattern = "";
                newTask.StartDate = null;
                newTask.Status = "";
                newTask.PondID = 0;
                newTask.Title = "";
                newTask.UserId = WebContext.Current.User.ToString();
                //newTask.assignedTo = Convert.ToInt32(assignedToTextBox.Text);
                newTask.assignedTo = 0;
                newTask.isDone = false;
                newTask.plannedManHours = Convert.ToDouble(0);

                //grid3.DataContext = tasksDomainContext.Tasks;

               
            }
            catch (Exception g)
            {
                Console.WriteLine(g.Message);
            }
        }

        private void saveNewTask()
        {

            try
            {
                tasksDomainContext.Tasks.Add(newTask);
                tasksDomainContext.SubmitChanges().Completed += saveNewTask_completed;
            }
            catch (Exception g)
            {
            }
        }

        private void saveNewTask_completed(object sender, EventArgs e)
        {
            CleanTask();
        }

        //Pond selectedPond;
       

        private void nameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedEmployee = this.nameComboBox.SelectedItem as EmployeeNameView;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            addNewTask();
        }

        private void LayoutRoot_GotFocus(object sender, RoutedEventArgs e)
        {
            if (hasGotFocus == false)
            {
                CleanTask();
                hasGotFocus = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CleanTask();
        }
    }
}
