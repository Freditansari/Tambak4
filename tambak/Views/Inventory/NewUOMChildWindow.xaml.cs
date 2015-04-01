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
using tambak.Web.DomainServices;
using tambak.Web;

namespace tambak.Views.Inventory
{
    public partial class NewUOMChildWindow : ChildWindow
    {
        UnitofMeasurementDS uomDomainContext = new UnitofMeasurementDS();
        bool itHasCleared = false;
        public NewUOMChildWindow()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            UnitofMeasurement newUom = new UnitofMeasurement();
            newUom.UOMName = uOMNameTextBox.Text;

            uomDomainContext.UnitofMeasurements.Add(newUom);
            uomDomainContext.SubmitChanges().Completed += NewUOMChildWindow_Completed;
           
        }

        void NewUOMChildWindow_Completed(object sender, EventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void unitofMeasurementDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void LayoutRoot_GotFocus(object sender, RoutedEventArgs e)
        {
            cleanTextBoxes();
        }

        private void cleanTextBoxes()
        {
            if (itHasCleared == false)
            {
                uOMNameTextBox.Text = "";
                itHasCleared = true;
            }

        }
    }
}

