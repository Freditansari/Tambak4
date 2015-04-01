namespace TambakReports
{
    partial class FacilityReport
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
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.Inventory = new Telerik.Reporting.SqlDataSource();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.facilityNameDataTextBox = new Telerik.Reporting.TextBox();
            this.addressDataTextBox = new Telerik.Reporting.TextBox();
            this.address2DataTextBox = new Telerik.Reporting.TextBox();
            this.cityDataTextBox = new Telerik.Reporting.TextBox();
            this.stateDataTextBox = new Telerik.Reporting.TextBox();
            this.countryDataTextBox = new Telerik.Reporting.TextBox();
            this.zipCodeDataTextBox = new Telerik.Reporting.TextBox();
            this.contactPersonDataTextBox = new Telerik.Reporting.TextBox();
            this.phoneNumberDataTextBox = new Telerik.Reporting.TextBox();
            this.emailDataTextBox = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // Inventory
            // 
            this.Inventory.ConnectionString = "TambakReports.Properties.Settings.CPL";
            this.Inventory.Name = "Inventory";
            this.Inventory.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@facilityidParameter", System.Data.DbType.String, "= Parameters.facilityidParameter.Value")});
            this.Inventory.SelectCommand = "SELECT        FacilityName, Address, Address2, City, State, Country, ZipCode, Con" +
    "tactPerson, PhoneNumber, Email\r\nFROM            Facilities\r\nWHERE        (Facili" +
    "tyId = @facilityidParameter)";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(4.3000001907348633D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.facilityNameDataTextBox,
            this.addressDataTextBox,
            this.address2DataTextBox,
            this.cityDataTextBox,
            this.stateDataTextBox,
            this.countryDataTextBox,
            this.zipCodeDataTextBox,
            this.contactPersonDataTextBox,
            this.phoneNumberDataTextBox,
            this.emailDataTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // facilityNameDataTextBox
            // 
            this.facilityNameDataTextBox.CanGrow = true;
            this.facilityNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9339065551757812E-05D), Telerik.Reporting.Drawing.Unit.Inch(3.9339065551757812E-05D));
            this.facilityNameDataTextBox.Name = "facilityNameDataTextBox";
            this.facilityNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9312106370925903D), Telerik.Reporting.Drawing.Unit.Inch(0.29996070265769958D));
            this.facilityNameDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.facilityNameDataTextBox.StyleName = "Data";
            this.facilityNameDataTextBox.Value = "= Fields.FacilityName";
            // 
            // addressDataTextBox
            // 
            this.addressDataTextBox.CanGrow = true;
            this.addressDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D), Telerik.Reporting.Drawing.Unit.Inch(0.30007871985435486D));
            this.addressDataTextBox.Name = "addressDataTextBox";
            this.addressDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9312105178833008D), Telerik.Reporting.Drawing.Unit.Inch(0.29992127418518066D));
            this.addressDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.addressDataTextBox.StyleName = "Data";
            this.addressDataTextBox.Value = "= Fields.Address";
            // 
            // address2DataTextBox
            // 
            this.address2DataTextBox.CanGrow = true;
            this.address2DataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D), Telerik.Reporting.Drawing.Unit.Inch(0.60007864236831665D));
            this.address2DataTextBox.Name = "address2DataTextBox";
            this.address2DataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9312106370925903D), Telerik.Reporting.Drawing.Unit.Inch(0.2999214231967926D));
            this.address2DataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.address2DataTextBox.StyleName = "Data";
            this.address2DataTextBox.Value = "= Fields.Address2";
            // 
            // cityDataTextBox
            // 
            this.cityDataTextBox.CanGrow = true;
            this.cityDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D), Telerik.Reporting.Drawing.Unit.Inch(0.90007895231246948D));
            this.cityDataTextBox.Name = "cityDataTextBox";
            this.cityDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9312105178833008D), Telerik.Reporting.Drawing.Unit.Inch(0.19992105662822723D));
            this.cityDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.cityDataTextBox.StyleName = "Data";
            this.cityDataTextBox.Value = "= Fields.City";
            // 
            // stateDataTextBox
            // 
            this.stateDataTextBox.CanGrow = true;
            this.stateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D), Telerik.Reporting.Drawing.Unit.Inch(1.1000789403915405D));
            this.stateDataTextBox.Name = "stateDataTextBox";
            this.stateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9312106370925903D), Telerik.Reporting.Drawing.Unit.Inch(0.29992127418518066D));
            this.stateDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.stateDataTextBox.StyleName = "Data";
            this.stateDataTextBox.Value = "= Fields.State";
            // 
            // countryDataTextBox
            // 
            this.countryDataTextBox.CanGrow = true;
            this.countryDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D), Telerik.Reporting.Drawing.Unit.Inch(1.4000791311264038D));
            this.countryDataTextBox.Name = "countryDataTextBox";
            this.countryDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0999606847763062D), Telerik.Reporting.Drawing.Unit.Inch(0.19992105662822723D));
            this.countryDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.countryDataTextBox.StyleName = "Data";
            this.countryDataTextBox.Value = "= Fields.Country";
            // 
            // zipCodeDataTextBox
            // 
            this.zipCodeDataTextBox.CanGrow = true;
            this.zipCodeDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1000789403915405D), Telerik.Reporting.Drawing.Unit.Inch(1.4000791311264038D));
            this.zipCodeDataTextBox.Name = "zipCodeDataTextBox";
            this.zipCodeDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.83117109537124634D), Telerik.Reporting.Drawing.Unit.Inch(0.19992105662822723D));
            this.zipCodeDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.zipCodeDataTextBox.StyleName = "Data";
            this.zipCodeDataTextBox.Value = "= Fields.ZipCode";
            // 
            // contactPersonDataTextBox
            // 
            this.contactPersonDataTextBox.CanGrow = true;
            this.contactPersonDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.1000001430511475D), Telerik.Reporting.Drawing.Unit.Inch(3.9339065551757812E-05D));
            this.contactPersonDataTextBox.Name = "contactPersonDataTextBox";
            this.contactPersonDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1000001430511475D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.contactPersonDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.contactPersonDataTextBox.StyleName = "Data";
            this.contactPersonDataTextBox.Value = "= Fields.ContactPerson";
            // 
            // phoneNumberDataTextBox
            // 
            this.phoneNumberDataTextBox.CanGrow = true;
            this.phoneNumberDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.1000001430511475D), Telerik.Reporting.Drawing.Unit.Inch(0.40011802315711975D));
            this.phoneNumberDataTextBox.Name = "phoneNumberDataTextBox";
            this.phoneNumberDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1000001430511475D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.phoneNumberDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.phoneNumberDataTextBox.StyleName = "Data";
            this.phoneNumberDataTextBox.Value = "= Fields.PhoneNumber";
            // 
            // emailDataTextBox
            // 
            this.emailDataTextBox.CanGrow = true;
            this.emailDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.1000001430511475D), Telerik.Reporting.Drawing.Unit.Inch(0.80019670724868774D));
            this.emailDataTextBox.Name = "emailDataTextBox";
            this.emailDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1000001430511475D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.emailDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.emailDataTextBox.StyleName = "Data";
            this.emailDataTextBox.Value = "= Fields.Email";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.detail.Name = "detail";
            // 
            // FacilityReport
            // 
            this.DataSource = this.Inventory;
            group1.GroupFooter = this.labelsGroupFooterSection;
            group1.GroupHeader = this.labelsGroupHeaderSection;
            group1.Name = "labelsGroup";
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeaderSection,
            this.labelsGroupFooterSection,
            this.reportHeader,
            this.detail});
            this.Name = "FacilityReport";
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            reportParameter1.Name = "facilityidParameter";
            reportParameter1.Text = "facilityidParameter";
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
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(10.668000221252441D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource Inventory;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox facilityNameDataTextBox;
        private Telerik.Reporting.TextBox addressDataTextBox;
        private Telerik.Reporting.TextBox address2DataTextBox;
        private Telerik.Reporting.TextBox cityDataTextBox;
        private Telerik.Reporting.TextBox stateDataTextBox;
        private Telerik.Reporting.TextBox countryDataTextBox;
        private Telerik.Reporting.TextBox zipCodeDataTextBox;
        private Telerik.Reporting.TextBox contactPersonDataTextBox;
        private Telerik.Reporting.TextBox phoneNumberDataTextBox;
        private Telerik.Reporting.TextBox emailDataTextBox;
        private Telerik.Reporting.DetailSection detail;

    }
}