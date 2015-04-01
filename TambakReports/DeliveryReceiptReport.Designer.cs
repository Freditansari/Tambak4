namespace TambakReports
{
    partial class DeliveryReceiptReport
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
            this.DeliveryReceiptDataSource = new Telerik.Reporting.SqlDataSource();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.productNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.qtyReceivedCaptionTextBox = new Telerik.Reporting.TextBox();
            this.uomCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.deliveryBatchCaptionTextBox = new Telerik.Reporting.TextBox();
            this.deliveryBatchDataTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.productNameDataTextBox = new Telerik.Reporting.TextBox();
            this.qtyReceivedDataTextBox = new Telerik.Reporting.TextBox();
            this.uomDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // DeliveryReceiptDataSource
            // 
            this.DeliveryReceiptDataSource.ConnectionString = "TambakReports.Properties.Settings.CPL";
            this.DeliveryReceiptDataSource.Name = "DeliveryReceiptDataSource";
            this.DeliveryReceiptDataSource.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@DeliveryBatchParameter", System.Data.DbType.String, "= Parameters.DeliveryBatchParameter.Value")});
            this.DeliveryReceiptDataSource.SelectCommand = "SELECT        ProductName, [Ordered Qty], qtyReceived, Uom, DeliveryBatch\r\nFROM  " +
    "          DeliveryReceiptView\r\nWHERE        (DeliveryBatch = @DeliveryBatchParam" +
    "eter)";
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.productNameCaptionTextBox,
            this.qtyReceivedCaptionTextBox,
            this.uomCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5885416269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.textBox1.StyleName = "Caption";
            this.textBox1.Value = "Ordered Qty";
            // 
            // productNameCaptionTextBox
            // 
            this.productNameCaptionTextBox.CanGrow = true;
            this.productNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6302083730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.productNameCaptionTextBox.Name = "productNameCaptionTextBox";
            this.productNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5885416269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.productNameCaptionTextBox.StyleName = "Caption";
            this.productNameCaptionTextBox.Value = "Product Name";
            // 
            // qtyReceivedCaptionTextBox
            // 
            this.qtyReceivedCaptionTextBox.CanGrow = true;
            this.qtyReceivedCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2395832538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.qtyReceivedCaptionTextBox.Name = "qtyReceivedCaptionTextBox";
            this.qtyReceivedCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5885416269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.qtyReceivedCaptionTextBox.StyleName = "Caption";
            this.qtyReceivedCaptionTextBox.Value = "qty Received";
            // 
            // uomCaptionTextBox
            // 
            this.uomCaptionTextBox.CanGrow = true;
            this.uomCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.8489584922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.uomCaptionTextBox.Name = "uomCaptionTextBox";
            this.uomCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5885416269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.uomCaptionTextBox.StyleName = "Caption";
            this.uomCaptionTextBox.Value = "Uom";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607D);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.currentTimeTextBox,
            this.pageInfoTextBox});
            this.pageFooter.Name = "pageFooter";
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2395832538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(1.2290682792663574D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox,
            this.deliveryBatchCaptionTextBox,
            this.deliveryBatchDataTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.4583334922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.787401556968689D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Delivery Receipt";
            // 
            // deliveryBatchCaptionTextBox
            // 
            this.deliveryBatchCaptionTextBox.CanGrow = true;
            this.deliveryBatchCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.80823493003845215D));
            this.deliveryBatchCaptionTextBox.Name = "deliveryBatchCaptionTextBox";
            this.deliveryBatchCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.deliveryBatchCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.deliveryBatchCaptionTextBox.StyleName = "Caption";
            this.deliveryBatchCaptionTextBox.Value = "Delivery Batch:";
            // 
            // deliveryBatchDataTextBox
            // 
            this.deliveryBatchDataTextBox.CanGrow = true;
            this.deliveryBatchDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2395832538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.80823493003845215D));
            this.deliveryBatchDataTextBox.Name = "deliveryBatchDataTextBox";
            this.deliveryBatchDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.deliveryBatchDataTextBox.StyleName = "Data";
            this.deliveryBatchDataTextBox.Value = "= Fields.DeliveryBatch";
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
            this.textBox2,
            this.productNameDataTextBox,
            this.qtyReceivedDataTextBox,
            this.uomDataTextBox});
            this.detail.Name = "detail";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5885416269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.textBox2.StyleName = "Data";
            this.textBox2.Value = "= Fields.[Ordered Qty]";
            // 
            // productNameDataTextBox
            // 
            this.productNameDataTextBox.CanGrow = true;
            this.productNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6302083730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.productNameDataTextBox.Name = "productNameDataTextBox";
            this.productNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5885416269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.productNameDataTextBox.StyleName = "Data";
            this.productNameDataTextBox.Value = "= Fields.ProductName";
            // 
            // qtyReceivedDataTextBox
            // 
            this.qtyReceivedDataTextBox.CanGrow = true;
            this.qtyReceivedDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2395832538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.qtyReceivedDataTextBox.Name = "qtyReceivedDataTextBox";
            this.qtyReceivedDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5885416269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.qtyReceivedDataTextBox.StyleName = "Data";
            this.qtyReceivedDataTextBox.Value = "= Fields.qtyReceived";
            // 
            // uomDataTextBox
            // 
            this.uomDataTextBox.CanGrow = true;
            this.uomDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.8489584922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.uomDataTextBox.Name = "uomDataTextBox";
            this.uomDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5885416269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.uomDataTextBox.StyleName = "Data";
            this.uomDataTextBox.Value = "= Fields.Uom";
            // 
            // DeliveryReceiptReport
            // 
            this.DataSource = this.DeliveryReceiptDataSource;
            group1.GroupFooter = this.labelsGroupFooterSection;
            group1.GroupHeader = this.labelsGroupHeaderSection;
            group1.Name = "labelsGroup";
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeaderSection,
            this.labelsGroupFooterSection,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
            this.Name = "DeliveryReceiptReport";
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            reportParameter1.Name = "DeliveryBatchParameter";
            reportParameter1.Text = "DeliveryBatchParameter";
            reportParameter1.Visible = true;
            this.ReportParameters.Add(reportParameter1);
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule2.Style.Color = System.Drawing.Color.Black;
            styleRule2.Style.Font.Bold = true;
            styleRule2.Style.Font.Italic = false;
            styleRule2.Style.Font.Name = "Tahoma";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            styleRule2.Style.Font.Strikeout = false;
            styleRule2.Style.Font.Underline = false;
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")});
            styleRule3.Style.Color = System.Drawing.Color.Black;
            styleRule3.Style.Font.Name = "Tahoma";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")});
            styleRule4.Style.Font.Name = "Tahoma";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule5.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule5.Style.Font.Name = "Tahoma";
            styleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            styleRule5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4,
            styleRule5});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(6.4583334922790527D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource DeliveryReceiptDataSource;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox productNameCaptionTextBox;
        private Telerik.Reporting.TextBox qtyReceivedCaptionTextBox;
        private Telerik.Reporting.TextBox uomCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.TextBox deliveryBatchCaptionTextBox;
        private Telerik.Reporting.TextBox deliveryBatchDataTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox productNameDataTextBox;
        private Telerik.Reporting.TextBox qtyReceivedDataTextBox;
        private Telerik.Reporting.TextBox uomDataTextBox;

    }
}