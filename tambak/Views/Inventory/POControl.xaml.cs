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

namespace tambak.Views.Inventory
{
    public partial class POControl : Page
    {
        PDOControlDS poControlDomainContext = new PDOControlDS();
        PDOControl selectedPDO;
       
        public POControl()
        {
            try
            {
                if (WebContext.Current.User.IsInRole("Manager") || WebContext.Current.User.IsInRole("Field Accounting") || WebContext.Current.User.IsInRole("Super Admin"))
                {
                    InitializeComponent();
                    Loaded += POControl_Loaded;

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

        void POControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (WebContext.Current.User.IsInRole("Field Accounting"))
            {
                buyPriceTextBox.Opacity = 0;
                pDOControlRadGridView.IsEnabled = false;
                pDOControlRadGridView.Opacity = 0;



            }
            else
            {
                pDOControlRadGridView2.IsEnabled = false;
                pDOControlRadGridView2.Opacity = 0;
            }
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void pDOControlDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void loadPDOControl()
        {
            poControlDomainContext = new PDOControlDS();

			EntityQuery<PDOControl> bb = from b in poControlDomainContext.GetPDOControlsQuery() select b;
            LoadOperation<PDOControl> res = poControlDomainContext.Load(bb, new Action<LoadOperation<PDOControl>>(load_pdocontrol_completed), true);
			
        }

        private void load_pdocontrol_completed(LoadOperation<PDOControl> obj)
        {
            pDOControlRadGridView.ItemsSource = poControlDomainContext.PDOControls;
        }

        private void UpdatePoButton_Click(object sender, RoutedEventArgs e)
        {
            EntityQuery<PDOControl> bb = from b in poControlDomainContext.GetPDOControlsQuery() where b.ID == selectedPDO.ID select b;
            LoadOperation<PDOControl> res = poControlDomainContext.Load(bb, new Action<LoadOperation<PDOControl>>(updatePO_Completed), true);
			
			
        }

        private void updatePO_Completed(LoadOperation<PDOControl> obj)
        {
            try
            {
                PDOControl bc = obj.Entities.First();
                bc.AccountingNotes = accountingNotesTextBox.Text;
                bc.BuyPrice = Convert.ToSingle(buyPriceTextBox.Text);
                bc.Date = dateDatePicker.SelectedDate;
                bc.InventoryID = inventoryIDTextBox.Text;
                bc.InventoryName = inventoryNameTextBox.Text;
                bc.NoPDO = noPDOTextBox.Text;
                bc.OrderedQuantity = Convert.ToSingle( orderedQuantityTextBox.Text);
                bc.ReceivedNotes = receivedNotesTextBox.Text;
                bc.ReceivedQuantity = Convert.ToSingle( receivedQuantityTextBox.Text);
                bc.UOM = uOMTextBox.Text;
                bc.isClosed = isClosedCheckBox.IsChecked;
                bc.isOrdered = isOrderedCheckBox.IsChecked;
                bc.isPaid = isPaidCheckBox.IsChecked;

                poControlDomainContext.SubmitChanges().Completed += update_PO_SubmitChanges_completed;
            }
            catch (Exception g)
            {

            }
        }

        private void update_PO_SubmitChanges_completed(object sender, EventArgs e)
        {
            loadPDOControl();
        }

   

      
        
        private void pDOControlRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            selectedPDO = this.pDOControlRadGridView.SelectedItem as PDOControl;
            accountingNotesTextBox.Text = selectedPDO.AccountingNotes;
            buyPriceTextBox.Text = selectedPDO.BuyPrice.ToString();
            dateDatePicker.SelectedDate = selectedPDO.Date;
            iDTextBox.Text = selectedPDO.ID.ToString();
            inventoryIDTextBox.Text = selectedPDO.InventoryID;
            inventoryNameTextBox.Text = selectedPDO.InventoryName;
            noPDOTextBox.Text = selectedPDO.NoPDO;
            orderedQuantityTextBox.Text = selectedPDO.OrderedQuantity.ToString();
            receivedNotesTextBox.Text = selectedPDO.ReceivedNotes;
            receivedQuantityTextBox.Text = selectedPDO.ReceivedQuantity.ToString();
            uOMTextBox.Text = selectedPDO.UOM;
            isClosedCheckBox.IsChecked = selectedPDO.isClosed;
            isOrderedCheckBox.IsChecked = selectedPDO.isOrdered;
            isPaidCheckBox.IsChecked = selectedPDO.isPaid;
        }

        private void load_selected_pdo_completed(LoadOperation<PDOControl> obj)
        {
            try
            {
                PDOControl bc = obj.Entities.First();
            }
            catch (Exception g)
            {
            }
        }

        private void NewPOButton_Click(object sender, RoutedEventArgs e)
        {
            tambak.Views.Inventory.NewPOCOntrolChildWindow cw = new NewPOCOntrolChildWindow();
            cw.Show();
            cw.Closed += cw_Closed;
        }

        void cw_Closed(object sender, EventArgs e)
        {
            loadPDOControl();
        }

    }
}
