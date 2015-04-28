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
using System.IO.IsolatedStorage;
using tambak.Web;
using tambak.Web.DomainServices;
using System.ServiceModel.DomainServices.Client;
using System.Globalization;

//Todo: add validation on POheader data. 
//todo: reduce each unit price after a discount being entered (text changed)
namespace tambak.Views.Inventory
{
    public partial class NewPurchaseOrder : Page
    {
        PurchaseOrderHeaderDS PoHeaderDomainContext = new PurchaseOrderHeaderDS();
        Product selectedProduct = new Product();
        PurchaseOrderDetailsDS PODetailsDomainContext = new PurchaseOrderDetailsDS();
        PODetail newPODetail = new PODetail();
        decimal POHeaderSubTotal;
        decimal POHeaderTaxRate;
        decimal DiscountedSubtotal;
        decimal POHeaderTotal;
        PurchaseOrder newPOheader = new PurchaseOrder();
        MasterTaxDS testingtaxdomainconext = new MasterTaxDS();
        public double DiscountAmount { get; set; }
        MasterCurrencyDS currencyDomainContext = new MasterCurrencyDS();
        MasterCurrency selectedCurrency;
        string PrintPOHeaderID;

        PurchaseTaxTransactionsDS purchaseTaxDomainContext = new PurchaseTaxTransactionsDS();





        public double? PurchaseRate { get; set; }

        public double? SellRate { get; set; }

        public double? middleRate { get; set; }
        List<MasterTax> SelectedList = new List<MasterTax>();
        //private IsolatedStorageSettings appSettings =IsolatedStorageSettings.ApplicationSettings;
        public NewPurchaseOrder()
        {
        
         
            try
            {
                if (WebContext.Current.User.IsInRole("Accounting") || WebContext.Current.User.IsInRole("Super Admin"))
                {
                    InitializeComponent();
                    Loaded += NewPurchaseOrder_Loaded;

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

        void NewPurchaseOrder_Loaded(object sender, RoutedEventArgs e)
        {
         


            pOIDTextBox.Text = Guid.NewGuid().ToString("N");
            
			IsolatedStorageSettings appSettings = IsolatedStorageSettings.ApplicationSettings;
            
            try
            {
                appSettings.Add("selectedPOID", pOIDTextBox.Text);
            }
            catch (Exception g)
            {
                appSettings.Remove("selectedPOID");
                appSettings.Add("selectedPOID", pOIDTextBox.Text);
            }

            grid1.DataContext = newPOheader;
           newPurchaseOrderHeader();
           this.POReportViewer.RenderBegin += POReportViewer_RenderBegin;
          
        }

     

    


        private void newPurchaseOrderHeader()
        {
            otherFeeTextBox.Text = "0";
            subTotalTextBox.Text = "0";
            taxRateTextBox.Text = "0";
            shippingTextBox.Text = "0";
            discountTextBox.Text = "0";
            totalPriceTextBox.Text = "0";
            shipToTextBox.Text = "";
            vendorIDTextBox.Text = "";
            newPOheader.POID = pOIDTextBox.Text;

            grid1.DataContext = newPOheader;
        



        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void purchaseOrderDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void pODetailDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void pODetailsViewDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void productDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void TabControl_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void FindProductButton_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void selectVendorButton_Click(object sender, RoutedEventArgs e)
        {
            
            SelectVendorChildWindow cw = new SelectVendorChildWindow();
            cw.Show();
            cw.Closed += cw_Closed;
        }

        void cw_Closed(object sender, EventArgs e)
        {
            try
            {
                IsolatedStorageSettings appSettings = IsolatedStorageSettings.ApplicationSettings;
                vendorIDTextBox.Text = appSettings["SelectedVendorID"].ToString();
                appSettings.Remove("SelectedVendorID");
            }
            catch (Exception g)
            {
            }
        }

        private void supplierDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void selectFacilityButton_Click(object sender, RoutedEventArgs e)
        {
            Popups.SelectFacilityChildWindow selectFacilityCW = new Popups.SelectFacilityChildWindow();
            selectFacilityCW.Show();
            selectFacilityCW.Closed += selectFacilityCW_Closed;


        }

        void selectFacilityCW_Closed(object sender, EventArgs e)
        {
            try
            {

                //todo get in app.xaml
                //IsolatedStorageSettings appSettings = IsolatedStorageSettings.ApplicationSettings;
                //shipToTextBox.Text = appSettings["SelectedFacilityID"].ToString();
                //appSettings.Remove("SelectedFacilityID");
                shipToTextBox.Text = App.SelectedFacilityID.ToString() ;
            }
            catch (Exception g)
            {
            } 
        }

        private void productRadGridView_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {

            selectedProduct = this.productRadGridView.SelectedItem as Product;
          
                productIDTextBox.Text = selectedProduct.ProductID.ToString();
                descriptionTextBox.Text = selectedProduct.ProductName;
                qtyTextBox.Text = "1";
                try
                {
                    if (selectedProduct.PurchasePrice == null)
                    {
                        unitPriceTextBox.Text = "0";

                    }
                    else
                    {
                        unitPriceTextBox.Text = selectedProduct.PurchasePrice.ToString();
                    }
                }
                catch (Exception g)
                {
                    unitPriceTextBox.Text = "0";
                }
        }

        private void unitPriceTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            try
            {
                totalTextBox.Text = Convert.ToString(Convert.ToDecimal(qtyTextBox.Text) * Convert.ToDecimal(unitPriceTextBox.Text));
            }
            catch (Exception g)
            {
            }
        }

        private void qtyTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            try
            {
                totalTextBox.Text = Convert.ToString(Convert.ToDecimal(qtyTextBox.Text) * Convert.ToDecimal(unitPriceTextBox.Text));
            }
            catch (Exception g)
            {
            }
        }

        private void selectTaxButton_Click(object sender, RoutedEventArgs e)
        {
            Popups.SelectTaxChildWindow taxCW = new Popups.SelectTaxChildWindow();
            taxCW.Show();
            taxCW.Closed += taxCW_Closed;
        }

        void taxCW_Closed(object sender, EventArgs e)
        {

            try
            {
                SelectedList = App.globalSelectedTax;
                POHeaderTaxRate = Convert.ToDecimal( (from b in SelectedList select b.TaxRate).Sum());
                taxRateTextBox.Text = POHeaderTaxRate.ToString();
                calculateTotalPrice();

                if (SelectedList == null)
                {
                    SavePurchaseOrderButton.IsEnabled = false;
                }
                else
                {
                    SavePurchaseOrderButton.IsEnabled = true;
                }
                
            }
            catch (Exception g)
            {
                taxRateTextBox.Text = "0";
            }
          
			
            
        }

        private void addProductButton_Click(object sender, RoutedEventArgs e)
        {
            addPODetail();
        }

        private void addPODetail()
        {
            newPODetail = new PODetail();
            newPODetail.POID = pOIDTextBox.Text;
            newPODetail.ProductID = Convert.ToInt32( productIDTextBox.Text);
            newPODetail.Description = descriptionTextBox.Text;
            newPODetail.qty = Convert.ToDecimal(qtyTextBox.Text);
            newPODetail.UnitPrice =Convert.ToDecimal( unitPriceTextBox.Text);
            newPODetail.Total = Convert.ToDecimal( totalTextBox.Text);

            PODetailsDomainContext.PODetails.Add(newPODetail);

            

            displayPoDetailDataGrid();
        }

        private void CalculateSubtotal()
        {
            POHeaderSubTotal = Convert.ToDecimal( (from b in PODetailsDomainContext.PODetails select b.Total).Sum());

            subTotalTextBox.Text = Convert.ToDouble( POHeaderSubTotal).ToString("C", App.cultInfo);
            calculateTotalPrice();
        }

        private void displayPoDetailDataGrid()
        {
            pODetailDataGrid.ItemsSource = PODetailsDomainContext.PODetails;
            CalculateSubtotal();
        }

        private void pODetailDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedPODetail = this.pODetailDataGrid.SelectedItem as PODetail;
        }





        public PODetail SelectedPODetail { get; set; }

        private void RemoveProductButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PODetailsDomainContext.PODetails.Remove(SelectedPODetail);
                displayPoDetailDataGrid();
            }
            catch (Exception g)
            {
            }


        }

        private void shippingTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void subTotalTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            calculateTotalPrice();
        }

        private void calculateTotalPrice()
        {
            try
            {
                DiscountedSubtotal= POHeaderSubTotal - Convert.ToDecimal(discountTextBox.Text);
                decimal calculatedTax = DiscountedSubtotal* POHeaderTaxRate;
                POHeaderTotal = DiscountedSubtotal + calculatedTax;
                totalPriceTextBox.Text = POHeaderTotal.ToString("C", App.cultInfo);

            }
            catch (Exception g)
            {
                

            }
        }

        private void discountTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
            calculateTotalPrice();
        }

        private void SavePurchaseOrderButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                
                addPoHeader();
            }
            catch (Exception g)
            {
            }
          
        }

        private void calculateDiscount()
        {
            DiscountAmount = Convert.ToDouble( discountTextBox.Text);
            if (DiscountAmount > 0)
            {
                
                Double discountRate = DiscountAmount / Convert.ToDouble(POHeaderSubTotal);

                foreach (PODetail b in PODetailsDomainContext.PODetails)
                {
                    b.UnitPrice = Convert.ToDecimal((Convert.ToDouble(b.UnitPrice) * (1 - discountRate))*(1+Convert.ToDouble( POHeaderTaxRate)));
                    b.Total = Convert.ToDecimal((Convert.ToDouble(b.Total) * (1 - discountRate)) * (1 + Convert.ToDouble(POHeaderTaxRate)));
                }

                
               
            }
            else
            {
                
            }
        }

        private void addPoHeader()
        {
            try
            {
                newPOheader.POID = pOIDTextBox.Text;
                newPOheader.ShipTo = Convert.ToInt32(shipToTextBox.Text);
                newPOheader.DueDate = dueDateDatePicker.SelectedDate;
                if (poDateDatePicker.SelectedDate == null)
                {
                    newPOheader.PoDate = DateTime.Now;
                }
                else
                {
                    newPOheader.PoDate = poDateDatePicker.SelectedDate;
                }
              
                newPOheader.POReference = pOReferenceTextBox.Text;
                newPOheader.Status = statusTextBox.Text;
                newPOheader.UserName = WebContext.Current.User.ToString();
                newPOheader.VendorID = Convert.ToInt32(vendorIDTextBox.Text);
                newPOheader.SubTotal = POHeaderSubTotal;
                newPOheader.Shipping = Convert.ToDecimal(shippingTextBox.Text);
                newPOheader.taxRate = Convert.ToDecimal(taxRateTextBox.Text);
                newPOheader.OtherFee = Convert.ToDecimal(otherFeeTextBox.Text);
                newPOheader.Discount = Convert.ToDecimal(discountTextBox.Text);
                newPOheader.TotalPrice = POHeaderTotal;
                newPOheader.Note = noteTextBox.Text;
                newPOheader.CurrencyShortCode = selectedCurrency.CurrencyShortName;
                newPOheader.CurrencyRate = middleRate;
                newPOheader.isComplete = false;

                PoHeaderDomainContext.PurchaseOrders.Add(newPOheader);
                PoHeaderDomainContext.SubmitChanges().Completed += NewPurchaseOrder_Completed;
            }
            catch (Exception g)
            {
            }

        }

        void NewPurchaseOrder_Completed(object sender, EventArgs e)
        {
            calculateDiscount();
            PODetailsDomainContext.SubmitChanges().Completed += poDetailsSubmitChanges_completed;

            
        }

        private void addPurchaseTaxTransactions()
        {
            
			IsolatedStorageSettings appSettings = IsolatedStorageSettings.ApplicationSettings;
            try
            {
               
                List<MasterTax> SelectedListMasterTax = (List<MasterTax>)appSettings["ListSelectedTax"];

                foreach (MasterTax selectedMasterTax in SelectedListMasterTax)
                {
                    PurchaseTaxTransaction newPurchaseTaxTransaction = new PurchaseTaxTransaction();
                    newPurchaseTaxTransaction.MasterTaxID = selectedMasterTax.TaxID;
                    newPurchaseTaxTransaction.POHeaderID = pOIDTextBox.Text;

                    purchaseTaxDomainContext.PurchaseTaxTransactions.Add(newPurchaseTaxTransaction);
                   
                }
                purchaseTaxDomainContext.SubmitChanges();


            }
            catch (Exception g)
            {
                MessageBox.Show("Please Select Tax before proceeding  \n"+ g.Message);
            }
        }

        private void poDetailsSubmitChanges_completed(object sender, EventArgs e)
        {
            addPurchaseTaxTransactions();
            PrintPOHeaderID = pOIDTextBox.Text;
            setupReportViewer();
            cleanupallTextBoxes();
            //todo set focus to report viewer 
           
        }
      

        private void setupReportViewer()
        {
            PrintPOTabItem.Focus();
            this.POReportViewer.ReportServerUri = new Uri("../ReportService.svc", UriKind.RelativeOrAbsolute);
            
        }

        void POReportViewer_RenderBegin(object sender, Telerik.ReportViewer.Silverlight.RenderBeginEventArgs args)
        {
            args.ParameterValues["POIDParameter"] = PrintPOHeaderID;
            
         
        }

        private void cleanupallTextBoxes()
        {
            newPODetail = new PODetail();
            newPOheader = new PurchaseOrder();
            PODetailsDomainContext = new PurchaseOrderDetailsDS();
           

            grid1.DataContext = newPOheader;
            grid5.DataContext = newPODetail;
            pODetailDataGrid.ItemsSource = PODetailsDomainContext.PODetails;
            pOIDTextBox.Text = Guid.NewGuid().ToString("N");
            newPurchaseOrderHeader();
            poDateDatePicker.SelectedDate = null;
            dueDateDatePicker.SelectedDate = null;
            cleanAllVariables();

            


        }

        private void cleanAllVariables()
        {
            PoHeaderDomainContext = new PurchaseOrderHeaderDS();
            selectedProduct = new Product();
            PODetailsDomainContext = new PurchaseOrderDetailsDS();
            newPODetail = new PODetail();
            POHeaderSubTotal=0;
            POHeaderTaxRate=0;
            DiscountedSubtotal=0;
            POHeaderTotal=0;
            newPOheader = new PurchaseOrder();
            testingtaxdomainconext = new MasterTaxDS();
            DiscountAmount = 0; 

            SelectedList = new List<MasterTax>();
        }

        private void taxRateTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void masterCurrencyDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void currencyShortNameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedCurrency = this.currencyShortNameComboBox.SelectedItem as MasterCurrency;
            App.cultInfo = new CultureInfo(selectedCurrency.CurrencyCulture.ToString());
            getExchangeRate();
        }

        private void getExchangeRate()
        {
            CurrencyRateDS CurrencyRateDomainContext = new CurrencyRateDS();

			EntityQuery<CurrencyRate> bb = from b in CurrencyRateDomainContext.GetCurrencyRatesQuery() where b.CurrencyShortCode == selectedCurrency.CurrencyShortName select b;
            LoadOperation<CurrencyRate> res = CurrencyRateDomainContext.Load(bb, new Action<LoadOperation<CurrencyRate>>(getExchangeRate_completed), true);

            
			
        }

        private void getExchangeRate_completed(LoadOperation<CurrencyRate> obj)
        {
            try
            {
                CurrencyRate bc = obj.Entities.LastOrDefault();
                PurchaseRate = bc.PurchaseRate;
                SellRate = bc.SellRate;
                middleRate = bc.MiddleRate;
                
            }
            catch (Exception g)
            {
                PurchaseRate = 1;
                SellRate = 1;
                middleRate = 1;
            }

        }

   

        private void currencyShortNameComboBox_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void pOIDTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

     
    }
}
