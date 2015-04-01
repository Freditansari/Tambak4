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
using tambak.Web;
using tambak.Web.DomainServices;

namespace tambak.Views.Inventory
{
    public partial class NewPOCOntrolChildWindow : ChildWindow
    {
        PDOControlDS poControlDomaincontext = new PDOControlDS();
        public NewPOCOntrolChildWindow()
        {
            try
            {
                if (WebContext.Current.User.IsInRole("Manager") || WebContext.Current.User.IsInRole("Super Admin"))
                {
                    InitializeComponent();
                    Loaded += NewPOCOntrolChildWindow_Loaded;

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

        void NewPOCOntrolChildWindow_Loaded(object sender, RoutedEventArgs e)
        {
            cleanTextBoxes();
        }
        private void cleanTextBoxes()
        {
            accountingNotesTextBox.Text = "";
            buyPriceTextBox.Text = "";
            dateDatePicker.SelectedDate = DateTime.Now;
            iDTextBox.Text = "";
            inventoryIDTextBox.Text = "";
            inventoryNameTextBox.Text = "";
            noPDOTextBox.Text = "";
            orderedQuantityTextBox.Text = "";
            receivedNotesTextBox.Text = "";
            //receivedQuantityTextBox.Text = "";
            uOMTextBox.Text = "";
            isClosedCheckBox.IsChecked = false;
            isOrderedCheckBox.IsChecked = false;
            isPaidCheckBox.IsChecked = false;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            newPOControl();
        }

        private void newPOControl()
        {
            PDOControl bc = new PDOControl();
            bc.AccountingNotes = accountingNotesTextBox.Text;
            bc.BuyPrice = Convert.ToSingle(buyPriceTextBox.Text);
            bc.Date = DateTime.Now;
            bc.InventoryID = inventoryIDTextBox.Text;
            bc.InventoryName = inventoryNameTextBox.Text;
            bc.NoPDO = noPDOTextBox.Text;
            bc.OrderedQuantity = Convert.ToSingle(orderedQuantityTextBox.Text);
            bc.ReceivedNotes = receivedNotesTextBox.Text;
            bc.ReceivedQuantity = Convert.ToSingle(receivedQuantityTextBox.Text);
            bc.UOM = uOMTextBox.Text;
            bc.isClosed = isClosedCheckBox.IsChecked;
            bc.isOrdered = isOrderedCheckBox.IsChecked;
            bc.isPaid = isPaidCheckBox.IsChecked;

            poControlDomaincontext.PDOControls.Add(bc);
            poControlDomaincontext.SubmitChanges().Completed += NewPOCOntrolChildWindow_Completed;

        }

        void NewPOCOntrolChildWindow_Completed(object sender, EventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void pDOControlDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }
    }
}

