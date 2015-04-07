using System;
using System.Collections.Generic;
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
using System.Windows.Printing;

namespace tambak.Views
{
    public partial class TasksView : UserControl
    {
        TasksDS tasksDomainContext = new TasksDS();
        PondsProductionCycleDS prodCycleDomainContext = new PondsProductionCycleDS();
        ProductRequiredDS requiredProductDC = new ProductRequiredDS();
        ResultNoteDS resultNoteDomainContext = new ResultNoteDS();

        EmployeeNameView selectedEmployee = new EmployeeNameView();

        public TasksView()
        {

            try
            {
                if (WebContext.Current.User.IsInRole("Technician") || WebContext.Current.User.IsInRole("Super Admin"))
                {
                    InitializeComponent();
                    Loaded += TasksView_Loaded;

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

        void TasksView_Loaded(object sender, RoutedEventArgs e)
        {
            addNewTask();
        }

        private void loadTasks()
        {
            //load tasks and put in radgridview.
            tasksDomainContext = new TasksDS();
            EntityQuery<Task> bb = from b in tasksDomainContext.GetTasksQuery() where b.assignedTo ==Convert.ToInt32(contactIDTextBox.Text) select b;
            LoadOperation<Task> res = tasksDomainContext.Load(bb, new Action<LoadOperation<Task>>(gettaskCompleted), true);
            
        }

        private void gettaskCompleted(LoadOperation<Task> obj)
        {
            
            taskRadGridView.ItemsSource = tasksDomainContext.Tasks;
        }

        private void contactDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
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

        private void contactDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void taskDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void startDateRadScheduleView_AppointmentCreating(object sender, Telerik.Windows.Controls.AppointmentCreatingEventArgs e)
        {

        }

        private void taskDomainDataSource_LoadedData_2(object sender, LoadedDataEventArgs e)
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

        private void SaveNewTaskButton_Click(object sender, RoutedEventArgs e)
        {
            //todo filter input here
            try
            {
                if (!Regex.IsMatch(completePercentageTextBox.Text, "[0-9]"))
                {
                    throw new ArgumentException("Numbers only");
                }
                else if (descriptionTextBox.Text.Length == 0)
                {
                    throw new ArgumentException("description cannot be null");
                }
                else
                {
                    savenewTask();
                }
            }
            catch (ArgumentException f)
            {
                MessageBox.Show(f.Message);
            }

            
        }

        private void addNewTask()
        {
            try
            {
                Task newTask = new Task();
                newTask.Attachments = attachmentsTextBox.Text;
                newTask.CompletePercentage = Convert.ToDouble(completePercentageTextBox.Text);
                newTask.Description = descriptionTextBox.Text;
                newTask.DueDate = dueDateRadDateTimePicker.SelectedValue;
                newTask.EndDate = endDateRadDateTimePicker.SelectedValue;
                newTask.Priority = priorityTextBox.Text;
                newTask.ProductionCycleID = Convert.ToInt32(productionCycleIDTextBox.Text);
                newTask.ReccurencePattern = reccurencePatternTextBox.Text;
                newTask.StartDate = startDateRadDateTimePicker.SelectedValue;
                newTask.Status = statusTextBox.Text;
                newTask.PondID = Convert.ToInt32(pondIDTextBox.Text);
                newTask.Title = titleTextBox.Text;
                newTask.UserId = WebContext.Current.User.ToString();
                //newTask.assignedTo = Convert.ToInt32(assignedToTextBox.Text);
                newTask.assignedTo = selectedEmployee.ContactID;
                newTask.plannedManHours = Convert.ToDouble(plannedManHoursTextBox.Text);
            }
            catch (Exception g)
            {
            }

        }


        private void savenewTask()
        {
            tasksDomainContext = new TasksDS();
            Task newTask = new Task();
            newTask.Attachments = attachmentsTextBox.Text;
            newTask.CompletePercentage = Convert.ToDouble(completePercentageTextBox.Text);
            newTask.Description = descriptionTextBox.Text;
            newTask.DueDate = dueDateRadDateTimePicker.SelectedValue;
            newTask.EndDate = endDateRadDateTimePicker.SelectedValue;
            newTask.Priority = priorityTextBox.Text;
            newTask.ProductionCycleID = Convert.ToInt32(productionCycleIDTextBox.Text);
            newTask.ReccurencePattern = reccurencePatternTextBox.Text;
            newTask.StartDate = startDateRadDateTimePicker.SelectedValue;
            newTask.Status = statusTextBox.Text;
            newTask.PondID = Convert.ToInt32(pondIDTextBox.Text);
            newTask.Title = titleTextBox.Text;
            newTask.UserId = WebContext.Current.User.ToString();
            //newTask.assignedTo = Convert.ToInt32(assignedToTextBox.Text);
            newTask.assignedTo = selectedEmployee.ContactID;
            newTask.plannedManHours = Convert.ToDouble(plannedManHoursTextBox.Text);

            tasksDomainContext.Tasks.Add(newTask);
            tasksDomainContext.SubmitChanges();
        }

        private void contactIDTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            loadTasks();
            //assignedToTextBox.Text = contactIDTextBox.Text;
            ManageTaskRadTabItem.IsEnabled = true;
            newTaskRadTabItem.IsEnabled = true;
            requiredProductRadTabItem.IsEnabled = true;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //todo update tasks goes here.
            tasksDomainContext = new TasksDS();
            EntityQuery<Task> bb = from b in tasksDomainContext.GetTasksQuery() where b.TaskID == Convert.ToInt32( taskIDTextBox1.Text) select b;
            LoadOperation<Task> res = tasksDomainContext.Load(bb, new Action<LoadOperation<Task>>(gettaskupdateCompleted), true);
        }

        private void gettaskupdateCompleted(LoadOperation<Task> obj)
        {
            //todo update procedures for tasks and results.
            Task bc = obj.Entities.First();
            
            bc.Attachments = attachmentsTextBox.Text;
            bc.CompletePercentage = Convert.ToDouble(completePercentageTextBox.Text);
            bc.Description = descriptionTextBox.Text;
            bc.DueDate = dueDateRadDateTimePicker.SelectedValue;
            bc.EndDate = endDateRadDateTimePicker.SelectedValue;
            bc.Priority = priorityTextBox.Text;
            bc.ProductionCycleID = Convert.ToInt32(productionCycleIDTextBox.Text);
            bc.ReccurencePattern = reccurencePatternTextBox.Text;
            bc.StartDate = startDateRadDateTimePicker.SelectedValue;
            bc.Status = statusTextBox.Text;
            bc.PondID = Convert.ToInt32(pondIDTextBox.Text);
            bc.Title = titleTextBox.Text;
            bc.UserId = WebContext.Current.User.ToString();
            bc.assignedTo = selectedEmployee.ContactID;
            //bc.assignedTo = Convert.ToInt32(assignedToTextBox.Text);
            bc.plannedManHours = Convert.ToDouble(plannedManHoursTextBox.Text);
            tasksDomainContext.SubmitChanges();
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

        private void productionCycleIDTextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void pondIDTextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            prodCycleDomainContext = new PondsProductionCycleDS();
            EntityQuery<tambak.Web.PondsProductionCycle> bb = from b in prodCycleDomainContext.GetPondsProductionCyclesQuery() where b.PondID == Convert.ToInt32(pondIDTextBox2.Text) && b.isInProduction == true select b;
            LoadOperation<tambak.Web.PondsProductionCycle> res = prodCycleDomainContext.Load(bb, new Action<LoadOperation<tambak.Web.PondsProductionCycle>>(getpondProductionCycleCompleted), true);
        }

        private void getpondProductionCycleCompleted(LoadOperation<Web.PondsProductionCycle> obj)
        {
            pondsProductionCycleRadGridView.ItemsSource = prodCycleDomainContext.PondsProductionCycles;
            pondIDTextBox.Text = pondIDTextBox2.Text;
        }

        private void pondsProductionCycleRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            try
            {
                tambak.Web.PondsProductionCycle selectedItem = this.pondsProductionCycleRadGridView.SelectedItem as tambak.Web.PondsProductionCycle;
                productionCycleIDTextBox.Text = selectedItem.ProductionCycleID.ToString();
            }
            catch (NullReferenceException g)
            {

            }
        }

        private void completePercentageTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void taskRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            //todo populate the textboxes with selected value. 
            try
            {
                Task selectedTask = this.taskRadGridView.SelectedItem as Task;
                taskIDTextBox3.Text = selectedTask.TaskID.ToString();
                attachmentsTextBox1.Text = selectedTask.Attachments.ToString();
                completePercentageTextBox1.Text = selectedTask.CompletePercentage.ToString();
                descriptionTextBox1.Text = selectedTask.Description.ToString();
                pondIDTextBox1.Text = selectedTask.PondID.ToString();
                priorityTextBox1.Text = selectedTask.Priority.ToString();
                productionCycleIDTextBox1.Text = selectedTask.ProductionCycleID.ToString();
                reccurencePatternTextBox1.Text = selectedTask.ReccurencePattern.ToString();
                startDateRadDateTimePicker1.SelectedValue = selectedTask.StartDate;
                dueDateRadDateTimePicker1.SelectedValue = selectedTask.DueDate;
                endDateRadDateTimePicker1.SelectedValue = selectedTask.EndDate;
                statusTextBox1.Text = selectedTask.Status.ToString();
                taskIDTextBox1.Text = selectedTask.TaskID.ToString();
                titleTextBox1.Text = selectedTask.Title.ToString();
                userIdTextBox1.Text = selectedTask.UserId.ToString();
                assignedToTextBox1.Text = selectedTask.assignedTo.ToString();
                isDoneCheckBox1.IsChecked = selectedTask.isDone;
                plannedManHoursTextBox1.Text = selectedTask.plannedManHours.ToString();
            }
            catch (NullReferenceException g)
            {
                taskIDTextBox3.Text = "";
                
            }
           
        }

        private void productRequiredDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void productDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void taskIDTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //change taskid in product required. 
            taskIDTextBox3.Text = taskIDTextBox1.Text;
            taskIDTextBox2.Text = taskIDTextBox1.Text;
            taskIDRadBarcode.Text = taskIDTextBox1.Text;
        }

        private void productRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            Product selectedProduct = this.productRadGridView.SelectedItem as Product;
            productIDTextBox.Text= selectedProduct.ProductID.ToString();
        }

        private void SaveRequiredProductButton_Click(object sender, RoutedEventArgs e)
        {
            //todo bug if it goes to exception still save database. 
            try
            {
                if (taskIDTextBox3.Text.Length == 0)
                {
                    throw new ArgumentException("task id cannot be empty");

                }
                else if (productIDTextBox.Text.Length == 0)
                {
                    throw new ArgumentException("Product id cannot be empty");
                }
                else
                {
                    saveRequiredProduct();
                }
            }
            catch (ArgumentException g)
            {

                MessageBox.Show(g.Message);
            }
            
        }

        private void saveRequiredProduct()
        {
            ProductRequired newProductRequirement = new ProductRequired();
            newProductRequirement.Amount = Convert.ToDecimal(amountTextBox.Text);
            newProductRequirement.ProductID = Convert.ToInt32(productIDTextBox.Text);
            newProductRequirement.TaskID = Convert.ToInt32(taskIDTextBox3.Text);

            requiredProductDC.ProductRequireds.Add(newProductRequirement);
            requiredProductDC.SubmitChanges();
        }

        private void addResultsButton_Click(object sender, RoutedEventArgs e)
        {
            resultNoteDomainContext = new ResultNoteDS();
            ResultNote newResultNote = new ResultNote();
            newResultNote.UserId = WebContext.Current.User.ToString();
            newResultNote.entryDate = DateTime.Now;
            newResultNote.taskID =Convert.ToInt32( taskIDTextBox1.Text);
            newResultNote.ResultNote1 = resultNote1TextBox.Text;
            resultNoteDomainContext.ResultNotes.Add(newResultNote);
            resultNoteDomainContext.SubmitChanges();

        }

        private void titleTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            taskTitleTextBlock.Text = titleTextBox1.Text;
            
        }

        private void descriptionTextBox1_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            TaskDescriptionTextBlock.Text = descriptionTextBox1.Text;
            DueDateTextbox.Text = dueDateRadDateTimePicker1.SelectedValue.ToString();
            ProductionCycleIDBarcode.Text = productionCycleIDTextBox1.Text;

        }

        private void assignedToTextBox1_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            AssignedToBarcode.Text = assignedToTextBox1.Text;
        }

        private void priorityTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            PriorityTextblock.Text = priorityTextBox1.Text;
        }

        private void PrintTaskButton_Click(object sender, RoutedEventArgs e)
        {
            PrintDocument docs = new PrintDocument();
            docs.PrintPage += (s, args) =>
                {
                    args.PageVisual = PrintTaskGrid;
                    
                };
            docs.Print("Printing Task ");
        }

        private void employeeNameViewDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void nameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedEmployee = this.nameComboBox.SelectedItem as EmployeeNameView;
        }

        

       

        
    }
}
 