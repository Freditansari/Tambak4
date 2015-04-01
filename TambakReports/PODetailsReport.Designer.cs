namespace TambakReports
{
    partial class PODetailsReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.PODetailsDataSource = new Telerik.Reporting.SqlDataSource();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.productNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.qtyCaptionTextBox = new Telerik.Reporting.TextBox();
            this.uomCaptionTextBox = new Telerik.Reporting.TextBox();
            this.currencyCaptionTextBox = new Telerik.Reporting.TextBox();
            this.unitPriceCaptionTextBox = new Telerik.Reporting.TextBox();
            this.totalCaptionTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.productNameDataTextBox = new Telerik.Reporting.TextBox();
            this.qtyDataTextBox = new Telerik.Reporting.TextBox();
            this.uomDataTextBox = new Telerik.Reporting.TextBox();
            this.currencyDataTextBox = new Telerik.Reporting.TextBox();
            this.unitPriceDataTextBox = new Telerik.Reporting.TextBox();
            this.totalDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // PODetailsDataSource
            // 
            this.PODetailsDataSource.ConnectionString = "TambakReports.Properties.Settings.CPL";
            this.PODetailsDataSource.Name = "PODetailsDataSource";
            this.PODetailsDataSource.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@POIDParameter", System.Data.DbType.String, "= Parameters.POIDParameter.Value")});
            this.PODetailsDataSource.SelectCommand = "SELECT        ProductName, qty, Uom, Currency, UnitPrice, Total\r\nFROM            " +
    "PODetailsView\r\nWHERE        (POID = @POIDParameter)";
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.productNameCaptionTextBox,
            this.qtyCaptionTextBox,
            this.uomCaptionTextBox,
            this.currencyCaptionTextBox,
            this.unitPriceCaptionTextBox,
            this.totalCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // productNameCaptionTextBox
            // 
            this.productNameCaptionTextBox.CanGrow = true;
            this.productNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.productNameCaptionTextBox.Name = "productNameCaptionTextBox";
            this.productNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4500000476837158D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.productNameCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.productNameCaptionTextBox.StyleName = "Caption";
            this.productNameCaptionTextBox.Value = "Product Name";
            // 
            // qtyCaptionTextBox
            // 
            this.qtyCaptionTextBox.CanGrow = true;
            this.qtyCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.qtyCaptionTextBox.Name = "qtyCaptionTextBox";
            this.qtyCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.64583331346511841D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.qtyCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.qtyCaptionTextBox.StyleName = "Caption";
            this.qtyCaptionTextBox.Value = "qty";
            // 
            // uomCaptionTextBox
            // 
            this.uomCaptionTextBox.CanGrow = true;
            this.uomCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.1666667461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.uomCaptionTextBox.Name = "uomCaptionTextBox";
            this.uomCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.uomCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.uomCaptionTextBox.StyleName = "Caption";
            this.uomCaptionTextBox.Value = "Uom";
            // 
            // currencyCaptionTextBox
            // 
            this.currencyCaptionTextBox.CanGrow = true;
            this.currencyCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2395832538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.currencyCaptionTextBox.Name = "currencyCaptionTextBox";
            this.currencyCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.currencyCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.currencyCaptionTextBox.StyleName = "Caption";
            this.currencyCaptionTextBox.Value = "Currency";
            // 
            // unitPriceCaptionTextBox
            // 
            this.unitPriceCaptionTextBox.CanGrow = true;
            this.unitPriceCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.3125D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.unitPriceCaptionTextBox.Name = "unitPriceCaptionTextBox";
            this.unitPriceCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.unitPriceCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.unitPriceCaptionTextBox.StyleName = "Caption";
            this.unitPriceCaptionTextBox.Value = "Unit Price";
            // 
            // totalCaptionTextBox
            // 
            this.totalCaptionTextBox.CanGrow = true;
            this.totalCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.3854165077209473D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.totalCaptionTextBox.Name = "totalCaptionTextBox";
            this.totalCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.totalCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.totalCaptionTextBox.StyleName = "Caption";
            this.totalCaptionTextBox.Value = "Total";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.reportFooter.Name = "reportFooter";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.productNameDataTextBox,
            this.qtyDataTextBox,
            this.uomDataTextBox,
            this.currencyDataTextBox,
            this.unitPriceDataTextBox,
            this.totalDataTextBox});
            this.detail.Name = "detail";
            // 
            // productNameDataTextBox
            // 
            this.productNameDataTextBox.CanGrow = true;
            this.productNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.productNameDataTextBox.Name = "productNameDataTextBox";
            this.productNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4500000476837158D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.productNameDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.productNameDataTextBox.StyleName = "Data";
            this.productNameDataTextBox.Value = "= Fields.ProductName";
            // 
            // qtyDataTextBox
            // 
            this.qtyDataTextBox.CanGrow = true;
            this.qtyDataTextBox.Format = "{0:N2}";
            this.qtyDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.qtyDataTextBox.Name = "qtyDataTextBox";
            this.qtyDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.64583331346511841D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.qtyDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.qtyDataTextBox.StyleName = "Data";
            this.qtyDataTextBox.Value = "= Fields.qty";
            // 
            // uomDataTextBox
            // 
            this.uomDataTextBox.CanGrow = true;
            this.uomDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.1666667461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.uomDataTextBox.Name = "uomDataTextBox";
            this.uomDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.uomDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.uomDataTextBox.StyleName = "Data";
            this.uomDataTextBox.Value = "= Fields.Uom";
            // 
            // currencyDataTextBox
            // 
            this.currencyDataTextBox.CanGrow = true;
            this.currencyDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2395832538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.currencyDataTextBox.Name = "currencyDataTextBox";
            this.currencyDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.currencyDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.currencyDataTextBox.StyleName = "Data";
            this.currencyDataTextBox.Value = "= Fields.Currency";
            // 
            // unitPriceDataTextBox
            // 
            this.unitPriceDataTextBox.CanGrow = true;
            this.unitPriceDataTextBox.Format = "{0:N2}";
            this.unitPriceDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.3125D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.unitPriceDataTextBox.Name = "unitPriceDataTextBox";
            this.unitPriceDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.unitPriceDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.unitPriceDataTextBox.StyleName = "Data";
            this.unitPriceDataTextBox.Value = "= Fields.UnitPrice";
            // 
            // totalDataTextBox
            // 
            this.totalDataTextBox.CanGrow = true;
            this.totalDataTextBox.Format = "{0:N2}";
            this.totalDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.3854165077209473D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.totalDataTextBox.Name = "totalDataTextBox";
            this.totalDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.totalDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.totalDataTextBox.StyleName = "Data";
            this.totalDataTextBox.Value = "= Fields.Total";
            // 
            // PODetailsReport
            // 
            this.DataSource = this.PODetailsDataSource;
            group1.GroupFooter = this.labelsGroupFooterSection;
            group1.GroupHeader = this.labelsGroupHeaderSection;
            group1.Name = "labelsGroup";
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeaderSection,
            this.labelsGroupFooterSection,
            this.reportFooter,
            this.detail});
            this.Name = "PODetailsReport";
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            reportParameter1.Name = "POIDParameter";
            reportParameter1.Text = "POIDParameter";
            reportParameter1.Visible = true;
            this.ReportParameters.Add(reportParameter1);
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule2.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            styleRule2.Style.Font.Name = "Tahoma";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")});
            styleRule3.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(112)))));
            styleRule3.Style.Color = System.Drawing.Color.White;
            styleRule3.Style.Font.Name = "Tahoma";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")});
            styleRule4.Style.Color = System.Drawing.Color.Black;
            styleRule4.Style.Font.Name = "Tahoma";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule5.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule5.Style.Color = System.Drawing.Color.Black;
            styleRule5.Style.Font.Name = "Tahoma";
            styleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            styleRule5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4,
            styleRule5});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(6.4375D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource PODetailsDataSource;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox productNameCaptionTextBox;
        private Telerik.Reporting.TextBox qtyCaptionTextBox;
        private Telerik.Reporting.TextBox uomCaptionTextBox;
        private Telerik.Reporting.TextBox currencyCaptionTextBox;
        private Telerik.Reporting.TextBox unitPriceCaptionTextBox;
        private Telerik.Reporting.TextBox totalCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox productNameDataTextBox;
        private Telerik.Reporting.TextBox qtyDataTextBox;
        private Telerik.Reporting.TextBox uomDataTextBox;
        private Telerik.Reporting.TextBox currencyDataTextBox;
        private Telerik.Reporting.TextBox unitPriceDataTextBox;
        private Telerik.Reporting.TextBox totalDataTextBox;

    }
}