namespace TambakReports
{
    partial class PurchaseOrderReports
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderReports));
            Telerik.Reporting.Barcodes.Code128BEncoder code128BEncoder1 = new Telerik.Reporting.Barcodes.Code128BEncoder();
            Telerik.Reporting.TypeReportSource typeReportSource1 = new Telerik.Reporting.TypeReportSource();
            Telerik.Reporting.TypeReportSource typeReportSource2 = new Telerik.Reporting.TypeReportSource();
            Telerik.Reporting.TypeReportSource typeReportSource3 = new Telerik.Reporting.TypeReportSource();
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.pOIDCaptionTextBox = new Telerik.Reporting.TextBox();
            this.poDateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.poDateDataTextBox = new Telerik.Reporting.TextBox();
            this.dueDateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dueDateDataTextBox = new Telerik.Reporting.TextBox();
            this.pOReferenceCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pOReferenceDataTextBox = new Telerik.Reporting.TextBox();
            this.shipToCaptionTextBox = new Telerik.Reporting.TextBox();
            this.vendorIDCaptionTextBox = new Telerik.Reporting.TextBox();
            this.barcode1 = new Telerik.Reporting.Barcode();
            this.FacilitySubReport = new Telerik.Reporting.SubReport();
            this.SupplierSubReport = new Telerik.Reporting.SubReport();
            this.totalPriceCaptionTextBox = new Telerik.Reporting.TextBox();
            this.totalPriceDataTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.subTotalDataTextBox = new Telerik.Reporting.TextBox();
            this.subTotalCaptionTextBox = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.discountDataTextBox = new Telerik.Reporting.TextBox();
            this.discountCaptionTextBox = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.shippingDataTextBox = new Telerik.Reporting.TextBox();
            this.shippingCaptionTextBox = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.taxRateDataTextBox = new Telerik.Reporting.TextBox();
            this.taxRateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.PODetailsSubReport = new Telerik.Reporting.SubReport();
            this.textBox7 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699D);
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "TambakReports.Properties.Settings.CPL";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@POIDParameter", System.Data.DbType.String, "= Parameters.POIDParameter.Value")});
            this.sqlDataSource1.SelectCommand = resources.GetString("sqlDataSource1.SelectCommand");
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
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.0817751884460449D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.1234416961669922D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.0817751884460449D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(3.7000002861022949D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox,
            this.pOIDCaptionTextBox,
            this.poDateCaptionTextBox,
            this.poDateDataTextBox,
            this.dueDateCaptionTextBox,
            this.dueDateDataTextBox,
            this.pOReferenceCaptionTextBox,
            this.pOReferenceDataTextBox,
            this.shipToCaptionTextBox,
            this.vendorIDCaptionTextBox,
            this.barcode1,
            this.FacilitySubReport,
            this.SupplierSubReport,
            this.textBox7});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(3.9312573790084571E-05D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.22605037689209D), Telerik.Reporting.Drawing.Unit.Inch(0.49996066093444824D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Purchase Order";
            // 
            // pOIDCaptionTextBox
            // 
            this.pOIDCaptionTextBox.CanGrow = true;
            this.pOIDCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926D), Telerik.Reporting.Drawing.Unit.Inch(0.78748017549514771D));
            this.pOIDCaptionTextBox.Name = "pOIDCaptionTextBox";
            this.pOIDCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.49996063113212585D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.pOIDCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pOIDCaptionTextBox.StyleName = "Caption";
            this.pOIDCaptionTextBox.Value = "POID:";
            // 
            // poDateCaptionTextBox
            // 
            this.poDateCaptionTextBox.CanGrow = true;
            this.poDateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926D), Telerik.Reporting.Drawing.Unit.Inch(1.3041571378707886D));
            this.poDateCaptionTextBox.Name = "poDateCaptionTextBox";
            this.poDateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0.1916862279176712D));
            this.poDateCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.poDateCaptionTextBox.StyleName = "Caption";
            this.poDateCaptionTextBox.Value = "Po Date:";
            // 
            // poDateDataTextBox
            // 
            this.poDateDataTextBox.CanGrow = true;
            this.poDateDataTextBox.Format = "{0:d}";
            this.poDateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.90000009536743164D), Telerik.Reporting.Drawing.Unit.Inch(1.304157018661499D));
            this.poDateDataTextBox.Name = "poDateDataTextBox";
            this.poDateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.90934121608734131D), Telerik.Reporting.Drawing.Unit.Inch(0.1916862279176712D));
            this.poDateDataTextBox.StyleName = "Data";
            this.poDateDataTextBox.Value = "= Fields.PoDate";
            // 
            // dueDateCaptionTextBox
            // 
            this.dueDateCaptionTextBox.CanGrow = true;
            this.dueDateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.9509295225143433D), Telerik.Reporting.Drawing.Unit.Inch(1.304157018661499D));
            this.dueDateCaptionTextBox.Name = "dueDateCaptionTextBox";
            this.dueDateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.74899196624755859D), Telerik.Reporting.Drawing.Unit.Inch(0.19168639183044434D));
            this.dueDateCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.dueDateCaptionTextBox.StyleName = "Caption";
            this.dueDateCaptionTextBox.Value = "Due Date:";
            // 
            // dueDateDataTextBox
            // 
            this.dueDateDataTextBox.CanGrow = true;
            this.dueDateDataTextBox.Format = "{0:d}";
            this.dueDateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.7000000476837158D), Telerik.Reporting.Drawing.Unit.Inch(1.3061556816101074D));
            this.dueDateDataTextBox.Name = "dueDateDataTextBox";
            this.dueDateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0372828245162964D), Telerik.Reporting.Drawing.Unit.Inch(0.19592197239398956D));
            this.dueDateDataTextBox.StyleName = "Data";
            this.dueDateDataTextBox.Value = "= Fields.DueDate";
            // 
            // pOReferenceCaptionTextBox
            // 
            this.pOReferenceCaptionTextBox.CanGrow = true;
            this.pOReferenceCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926D), Telerik.Reporting.Drawing.Unit.Inch(1.4959220886230469D));
            this.pOReferenceCaptionTextBox.Name = "pOReferenceCaptionTextBox";
            this.pOReferenceCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929D), Telerik.Reporting.Drawing.Unit.Inch(0.20407812297344208D));
            this.pOReferenceCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pOReferenceCaptionTextBox.StyleName = "Caption";
            this.pOReferenceCaptionTextBox.Value = "Reference:";
            // 
            // pOReferenceDataTextBox
            // 
            this.pOReferenceDataTextBox.CanGrow = true;
            this.pOReferenceDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.90000009536743164D), Telerik.Reporting.Drawing.Unit.Inch(1.5031558275222778D));
            this.pOReferenceDataTextBox.Name = "pOReferenceDataTextBox";
            this.pOReferenceDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.7372832298278809D), Telerik.Reporting.Drawing.Unit.Inch(0.19784362614154816D));
            this.pOReferenceDataTextBox.StyleName = "Data";
            this.pOReferenceDataTextBox.Value = "= Fields.POReference";
            // 
            // shipToCaptionTextBox
            // 
            this.shipToCaptionTextBox.CanGrow = true;
            this.shipToCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(1.8000001907348633D));
            this.shipToCaptionTextBox.Name = "shipToCaptionTextBox";
            this.shipToCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1791667938232422D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.shipToCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.shipToCaptionTextBox.StyleName = "Caption";
            this.shipToCaptionTextBox.Value = "Ship To:";
            // 
            // vendorIDCaptionTextBox
            // 
            this.vendorIDCaptionTextBox.CanGrow = true;
            this.vendorIDCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2000789642333984D), Telerik.Reporting.Drawing.Unit.Inch(1.8000000715255737D));
            this.vendorIDCaptionTextBox.Name = "vendorIDCaptionTextBox";
            this.vendorIDCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1791667938232422D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.vendorIDCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.vendorIDCaptionTextBox.StyleName = "Caption";
            this.vendorIDCaptionTextBox.Value = "Supplier:";
            // 
            // barcode1
            // 
            this.barcode1.Checksum = false;
            code128BEncoder1.ShowText = false;
            this.barcode1.Encoder = code128BEncoder1;
            this.barcode1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.699999988079071D), Telerik.Reporting.Drawing.Unit.Inch(0.78748017549514771D));
            this.barcode1.Name = "barcode1";
            this.barcode1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7999998331069946D), Telerik.Reporting.Drawing.Unit.Inch(0.40000009536743164D));
            this.barcode1.Stretch = true;
            this.barcode1.Value = "= Fields.POID";
            // 
            // FacilitySubReport
            // 
            this.FacilitySubReport.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(2.2000789642333984D));
            this.FacilitySubReport.Name = "FacilitySubReport";
            typeReportSource1.Parameters.Add(new Telerik.Reporting.Parameter("facilityidParameter", "= Fields.ShipTo"));
            typeReportSource1.TypeName = "TambakReports.FacilityReport, TambakReports, Version=1.0.0.0, Culture=neutral, Pu" +
    "blicKeyToken=null";
            this.FacilitySubReport.ReportSource = typeReportSource1;
            this.FacilitySubReport.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1791667938232422D), Telerik.Reporting.Drawing.Unit.Inch(1.3999210596084595D));
            // 
            // SupplierSubReport
            // 
            this.SupplierSubReport.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2000789642333984D), Telerik.Reporting.Drawing.Unit.Inch(2.2000787258148193D));
            this.SupplierSubReport.Name = "SupplierSubReport";
            typeReportSource2.Parameters.Add(new Telerik.Reporting.Parameter("SupplierIDParameter1", "= Fields.VendorID"));
            typeReportSource2.TypeName = "TambakReports.SuppliersReport, TambakReports, Version=1.0.0.0, Culture=neutral, P" +
    "ublicKeyToken=null";
            this.SupplierSubReport.ReportSource = typeReportSource2;
            this.SupplierSubReport.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1791667938232422D), Telerik.Reporting.Drawing.Unit.Inch(1.3999210596084595D));
            // 
            // totalPriceCaptionTextBox
            // 
            this.totalPriceCaptionTextBox.CanGrow = true;
            this.totalPriceCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.7000007629394531D), Telerik.Reporting.Drawing.Unit.Inch(0.64095622301101685D));
            this.totalPriceCaptionTextBox.Name = "totalPriceCaptionTextBox";
            this.totalPriceCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3700428009033203D), Telerik.Reporting.Drawing.Unit.Inch(0.12898103892803192D));
            this.totalPriceCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.totalPriceCaptionTextBox.StyleName = "Caption";
            this.totalPriceCaptionTextBox.Value = "Total Price:";
            // 
            // totalPriceDataTextBox
            // 
            this.totalPriceDataTextBox.CanGrow = true;
            this.totalPriceDataTextBox.Format = "{0:N2}";
            this.totalPriceDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.6999993324279785D), Telerik.Reporting.Drawing.Unit.Inch(0.64095622301101685D));
            this.totalPriceDataTextBox.Name = "totalPriceDataTextBox";
            this.totalPriceDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3700428009033203D), Telerik.Reporting.Drawing.Unit.Inch(0.12898103892803192D));
            this.totalPriceDataTextBox.Style.Font.Bold = true;
            this.totalPriceDataTextBox.StyleName = "Data";
            this.totalPriceDataTextBox.Value = "= Fields.TotalPrice";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(1.0562493801116943D);
            this.reportFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.totalPriceDataTextBox,
            this.totalPriceCaptionTextBox,
            this.subTotalDataTextBox,
            this.subTotalCaptionTextBox,
            this.textBox2,
            this.discountDataTextBox,
            this.discountCaptionTextBox,
            this.textBox3,
            this.shippingDataTextBox,
            this.shippingCaptionTextBox,
            this.textBox4,
            this.taxRateDataTextBox,
            this.taxRateCaptionTextBox,
            this.textBox1,
            this.textBox5,
            this.textBox6});
            this.reportFooter.Name = "reportFooter";
            // 
            // subTotalDataTextBox
            // 
            this.subTotalDataTextBox.CanGrow = true;
            this.subTotalDataTextBox.Format = "{0:N2}";
            this.subTotalDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.7000002861022949D), Telerik.Reporting.Drawing.Unit.Inch(0.0041563245467841625D));
            this.subTotalDataTextBox.Name = "subTotalDataTextBox";
            this.subTotalDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3700424432754517D), Telerik.Reporting.Drawing.Unit.Inch(0.15209385752677918D));
            this.subTotalDataTextBox.StyleName = "Data";
            this.subTotalDataTextBox.Value = "= Fields.SubTotal";
            // 
            // subTotalCaptionTextBox
            // 
            this.subTotalCaptionTextBox.CanGrow = true;
            this.subTotalCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.7000002861022949D), Telerik.Reporting.Drawing.Unit.Inch(3.9577484130859375E-05D));
            this.subTotalCaptionTextBox.Name = "subTotalCaptionTextBox";
            this.subTotalCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3700428009033203D), Telerik.Reporting.Drawing.Unit.Inch(0.15621033310890198D));
            this.subTotalCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.subTotalCaptionTextBox.StyleName = "Caption";
            this.subTotalCaptionTextBox.Value = "Sub Total:";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.0931878089904785D), Telerik.Reporting.Drawing.Unit.Inch(0.0041563245467841625D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5859789252281189D), Telerik.Reporting.Drawing.Unit.Inch(0.15209385752677918D));
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox2.StyleName = "Data";
            this.textBox2.Value = "= Fields.CurrencyShortCode";
            // 
            // discountDataTextBox
            // 
            this.discountDataTextBox.CanGrow = true;
            this.discountDataTextBox.Format = "{0:N2}";
            this.discountDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.7000002861022949D), Telerik.Reporting.Drawing.Unit.Inch(0.1563279926776886D));
            this.discountDataTextBox.Name = "discountDataTextBox";
            this.discountDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3700424432754517D), Telerik.Reporting.Drawing.Unit.Inch(0.17604675889015198D));
            this.discountDataTextBox.StyleName = "Data";
            this.discountDataTextBox.Value = "= Fields.Discount";
            // 
            // discountCaptionTextBox
            // 
            this.discountCaptionTextBox.CanGrow = true;
            this.discountCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.7000002861022949D), Telerik.Reporting.Drawing.Unit.Inch(0.1563279926776886D));
            this.discountCaptionTextBox.Name = "discountCaptionTextBox";
            this.discountCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3700424432754517D), Telerik.Reporting.Drawing.Unit.Inch(0.17604675889015198D));
            this.discountCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.discountCaptionTextBox.StyleName = "Caption";
            this.discountCaptionTextBox.Value = "Discount:";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = true;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.0931878089904785D), Telerik.Reporting.Drawing.Unit.Inch(0.1802808940410614D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5859789252281189D), Telerik.Reporting.Drawing.Unit.Inch(0.15209385752677918D));
            this.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox3.StyleName = "Data";
            this.textBox3.Value = "= Fields.CurrencyShortCode";
            // 
            // shippingDataTextBox
            // 
            this.shippingDataTextBox.CanGrow = true;
            this.shippingDataTextBox.Format = "{0:N2}";
            this.shippingDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.7000002861022949D), Telerik.Reporting.Drawing.Unit.Inch(0.33657011389732361D));
            this.shippingDataTextBox.Name = "shippingDataTextBox";
            this.shippingDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.370042085647583D), Telerik.Reporting.Drawing.Unit.Inch(0.15624974668025971D));
            this.shippingDataTextBox.StyleName = "Data";
            this.shippingDataTextBox.Value = "= Fields.Shipping";
            // 
            // shippingCaptionTextBox
            // 
            this.shippingCaptionTextBox.CanGrow = true;
            this.shippingCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.7000002861022949D), Telerik.Reporting.Drawing.Unit.Inch(0.33245405554771423D));
            this.shippingCaptionTextBox.Name = "shippingCaptionTextBox";
            this.shippingCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3700424432754517D), Telerik.Reporting.Drawing.Unit.Inch(0.15624974668025971D));
            this.shippingCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.shippingCaptionTextBox.StyleName = "Caption";
            this.shippingCaptionTextBox.Value = "Shipping:";
            // 
            // textBox4
            // 
            this.textBox4.CanGrow = true;
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.0931878089904785D), Telerik.Reporting.Drawing.Unit.Inch(0.34072622656822205D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5859789252281189D), Telerik.Reporting.Drawing.Unit.Inch(0.15209385752677918D));
            this.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox4.StyleName = "Data";
            this.textBox4.Value = "= Fields.CurrencyShortCode";
            // 
            // taxRateDataTextBox
            // 
            this.taxRateDataTextBox.CanGrow = true;
            this.taxRateDataTextBox.Format = "{0:P2}";
            this.taxRateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.7000002861022949D), Telerik.Reporting.Drawing.Unit.Inch(0.51189613342285156D));
            this.taxRateDataTextBox.Name = "taxRateDataTextBox";
            this.taxRateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.370042085647583D), Telerik.Reporting.Drawing.Unit.Inch(0.12898102402687073D));
            this.taxRateDataTextBox.StyleName = "Data";
            this.taxRateDataTextBox.Value = "= Fields.taxRate";
            // 
            // taxRateCaptionTextBox
            // 
            this.taxRateCaptionTextBox.CanGrow = true;
            this.taxRateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.7000002861022949D), Telerik.Reporting.Drawing.Unit.Inch(0.48878288269042969D));
            this.taxRateCaptionTextBox.Name = "taxRateCaptionTextBox";
            this.taxRateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3700428009033203D), Telerik.Reporting.Drawing.Unit.Inch(0.1520942747592926D));
            this.taxRateCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.taxRateCaptionTextBox.StyleName = "Caption";
            this.taxRateCaptionTextBox.Value = "tax Rate:";
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.0931878089904785D), Telerik.Reporting.Drawing.Unit.Inch(0.640956461429596D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.5859789252281189D), Telerik.Reporting.Drawing.Unit.Inch(0.15209385752677918D));
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox1.StyleName = "Data";
            this.textBox1.Value = "= Fields.CurrencyShortCode";
            // 
            // textBox5
            // 
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.18028068542480469D));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.3000001907348633D), Telerik.Reporting.Drawing.Unit.Inch(0.81533241271972656D));
            this.textBox5.Value = "=Fields.Note";
            // 
            // textBox6
            // 
            this.textBox6.CanGrow = true;
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.2791666984558105D), Telerik.Reporting.Drawing.Unit.Inch(0.1562497615814209D));
            this.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox6.StyleName = "Caption";
            this.textBox6.Value = "Note:";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(2.8408775329589844D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.PODetailsSubReport});
            this.detail.Name = "detail";
            // 
            // PODetailsSubReport
            // 
            this.PODetailsSubReport.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D));
            this.PODetailsSubReport.Name = "PODetailsSubReport";
            typeReportSource3.Parameters.Add(new Telerik.Reporting.Parameter("POIDParameter", "= Fields.POID"));
            typeReportSource3.TypeName = "TambakReports.PODetailsReport, TambakReports, Version=1.0.0.0, Culture=neutral, P" +
    "ublicKeyToken=null";
            this.PODetailsSubReport.ReportSource = typeReportSource3;
            this.PODetailsSubReport.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.149169921875D), Telerik.Reporting.Drawing.Unit.Inch(2.84079909324646D));
            // 
            // textBox7
            // 
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.69999980926513672D), Telerik.Reporting.Drawing.Unit.Inch(0.57488161325454712D));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.037283182144165D), Telerik.Reporting.Drawing.Unit.Inch(0.2125198096036911D));
            this.textBox7.Style.Font.Bold = true;
            this.textBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.textBox7.Value = "=Fields.POID";
            // 
            // PurchaseOrderReports
            // 
            this.DataSource = this.sqlDataSource1;
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
            this.Name = "PurchaseOrderReports";
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
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
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(8.22605037689209D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.TextBox pOIDCaptionTextBox;
        private Telerik.Reporting.TextBox poDateCaptionTextBox;
        private Telerik.Reporting.TextBox poDateDataTextBox;
        private Telerik.Reporting.TextBox dueDateCaptionTextBox;
        private Telerik.Reporting.TextBox dueDateDataTextBox;
        private Telerik.Reporting.TextBox pOReferenceCaptionTextBox;
        private Telerik.Reporting.TextBox pOReferenceDataTextBox;
        private Telerik.Reporting.TextBox shipToCaptionTextBox;
        private Telerik.Reporting.TextBox vendorIDCaptionTextBox;
        private Telerik.Reporting.TextBox totalPriceCaptionTextBox;
        private Telerik.Reporting.TextBox totalPriceDataTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.Barcode barcode1;
        private Telerik.Reporting.SubReport FacilitySubReport;
        private Telerik.Reporting.SubReport SupplierSubReport;
        private Telerik.Reporting.TextBox subTotalDataTextBox;
        private Telerik.Reporting.TextBox subTotalCaptionTextBox;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox discountDataTextBox;
        private Telerik.Reporting.TextBox discountCaptionTextBox;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox shippingDataTextBox;
        private Telerik.Reporting.TextBox shippingCaptionTextBox;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox taxRateDataTextBox;
        private Telerik.Reporting.TextBox taxRateCaptionTextBox;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.SubReport PODetailsSubReport;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox7;

    }
}