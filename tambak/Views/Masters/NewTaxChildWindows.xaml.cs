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

namespace tambak.Views.Masters
{
    public partial class NewTaxChildWindows : ChildWindow
    {
        MasterTax newTax = new MasterTax();
        MasterTaxDS TaxDomainContext = new MasterTaxDS();
        public NewTaxChildWindows()
        {
            InitializeComponent();
            Loaded += NewTaxChildWindows_Loaded;
        }

        void NewTaxChildWindows_Loaded(object sender, RoutedEventArgs e)
        {
            grid1.DataContext = newTax;
            enterNewTax();
        }

        private void enterNewTax()
        {

            try
            {
                newTax.TaxDescription = taxDescriptionTextBox.Text;
                newTax.TaxRate = Convert.ToDecimal( taxRateTextBox.Text)/100;
            }
            catch (Exception g)
            {
                
                
            }
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            enterNewTax();
            TaxDomainContext.MasterTaxes.Add(newTax);
            TaxDomainContext.SubmitChanges().Completed += NewTaxChildWindows_Completed;
            
        }

        void NewTaxChildWindows_Completed(object sender, EventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void masterTaxDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }
    }
}

