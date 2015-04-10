namespace TambakReports
{
    partial class ProductLabelReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.Barcodes.Code128Encoder code128Encoder1 = new Telerik.Reporting.Barcodes.Code128Encoder();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.Inventory = new Telerik.Reporting.SqlDataSource();
            this.detail = new Telerik.Reporting.DetailSection();
            this.productNameDataTextBox = new Telerik.Reporting.TextBox();
            this.barcode1 = new Telerik.Reporting.Barcode();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Inventory
            // 
            this.Inventory.ConnectionString = "TambakReports.Properties.Settings.CPL";
            this.Inventory.Name = "Inventory";
            this.Inventory.SelectCommand = "SELECT        SKU, ProductName\r\nFROM            Products\r\nWHERE        (Category " +
    "<> 7)";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(2.7000000476837158D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.productNameDataTextBox,
            this.barcode1});
            this.detail.Name = "detail";
            // 
            // productNameDataTextBox
            // 
            this.productNameDataTextBox.CanGrow = false;
            this.productNameDataTextBox.CanShrink = false;
            this.productNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(3.9339065551757812E-05D));
            this.productNameDataTextBox.Name = "productNameDataTextBox";
            this.productNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.5246939659118652D), Telerik.Reporting.Drawing.Unit.Inch(0.19996063411235809D));
            this.productNameDataTextBox.Value = "= Fields.ProductName";
            // 
            // barcode1
            // 
            this.barcode1.Encoder = code128Encoder1;
            this.barcode1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D), Telerik.Reporting.Drawing.Unit.Inch(0.20007865130901337D));
            this.barcode1.Name = "barcode1";
            this.barcode1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.5038604736328125D), Telerik.Reporting.Drawing.Unit.Inch(0.65502136945724487D));
            this.barcode1.Stretch = true;
            this.barcode1.Value = "= Fields.SKU";
            // 
            // ProductLabelReport
            // 
            this.DataSource = this.Inventory;
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail});
            this.Name = "ProductLabelReport";
            this.PageSettings.ColumnCount = 2;
            this.PageSettings.ColumnSpacing = Telerik.Reporting.Drawing.Unit.Inch(0.0786999985575676D);
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.3937000036239624D), Telerik.Reporting.Drawing.Unit.Mm(19.992927551269531D), Telerik.Reporting.Drawing.Unit.Inch(0.98430001735687256D), Telerik.Reporting.Drawing.Unit.Mm(31.984176635742188D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(3.5246937274932861D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource Inventory;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox productNameDataTextBox;
        private Telerik.Reporting.Barcode barcode1;

    }
}