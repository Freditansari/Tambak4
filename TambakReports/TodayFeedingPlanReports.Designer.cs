namespace TambakReports
{
    partial class TodayFeedingPlanReports
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.pondDescriptionCaptionTextBox = new Telerik.Reporting.TextBox();
            this.ageCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.mBWCaptionTextBox = new Telerik.Reporting.TextBox();
            this.populationCaptionTextBox = new Telerik.Reporting.TextBox();
            this.using01MCaptionTextBox = new Telerik.Reporting.TextBox();
            this.using05MCaptionTextBox = new Telerik.Reporting.TextBox();
            this.using20MCaptionTextBox = new Telerik.Reporting.TextBox();
            this.using30MCaptionTextBox = new Telerik.Reporting.TextBox();
            this.usingFRCaptionTextBox = new Telerik.Reporting.TextBox();
            this.usingMaxCaptionTextBox = new Telerik.Reporting.TextBox();
            this.noPakanCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.pondDescriptionDataTextBox = new Telerik.Reporting.TextBox();
            this.ageDataTextBox = new Telerik.Reporting.TextBox();
            this.dateDataTextBox = new Telerik.Reporting.TextBox();
            this.mBWDataTextBox = new Telerik.Reporting.TextBox();
            this.populationDataTextBox = new Telerik.Reporting.TextBox();
            this.using01MDataTextBox = new Telerik.Reporting.TextBox();
            this.using05MDataTextBox = new Telerik.Reporting.TextBox();
            this.using20MDataTextBox = new Telerik.Reporting.TextBox();
            this.using30MDataTextBox = new Telerik.Reporting.TextBox();
            this.usingFRDataTextBox = new Telerik.Reporting.TextBox();
            this.usingMaxDataTextBox = new Telerik.Reporting.TextBox();
            this.noPakanDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "TambakReports.Properties.Settings.CPL";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.SelectCommand = "SELECT        PondDescription, ProductionCycleID, Age, Date, MBW, Population, Usi" +
    "ngFR, Using01M, Using05M, Using20M, Using30M, NoPakan, UsingMax\r\nFROM           " +
    " TodayFeedingPlanView";
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pondDescriptionCaptionTextBox,
            this.ageCaptionTextBox,
            this.dateCaptionTextBox,
            this.mBWCaptionTextBox,
            this.populationCaptionTextBox,
            this.using01MCaptionTextBox,
            this.using05MCaptionTextBox,
            this.using20MCaptionTextBox,
            this.using30MCaptionTextBox,
            this.usingFRCaptionTextBox,
            this.usingMaxCaptionTextBox,
            this.noPakanCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // pondDescriptionCaptionTextBox
            // 
            this.pondDescriptionCaptionTextBox.CanGrow = true;
            this.pondDescriptionCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.pondDescriptionCaptionTextBox.Name = "pondDescriptionCaptionTextBox";
            this.pondDescriptionCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.pondDescriptionCaptionTextBox.StyleName = "Caption";
            this.pondDescriptionCaptionTextBox.Value = "Pond Name";
            // 
            // ageCaptionTextBox
            // 
            this.ageCaptionTextBox.CanGrow = true;
            this.ageCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.55729168653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.ageCaptionTextBox.Name = "ageCaptionTextBox";
            this.ageCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.ageCaptionTextBox.StyleName = "Caption";
            this.ageCaptionTextBox.Value = "Age";
            // 
            // dateCaptionTextBox
            // 
            this.dateCaptionTextBox.CanGrow = true;
            this.dateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.09375D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.dateCaptionTextBox.Name = "dateCaptionTextBox";
            this.dateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.dateCaptionTextBox.StyleName = "Caption";
            this.dateCaptionTextBox.Value = "Date";
            // 
            // mBWCaptionTextBox
            // 
            this.mBWCaptionTextBox.CanGrow = true;
            this.mBWCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6302083730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.mBWCaptionTextBox.Name = "mBWCaptionTextBox";
            this.mBWCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.mBWCaptionTextBox.StyleName = "Caption";
            this.mBWCaptionTextBox.Value = "MBW";
            // 
            // populationCaptionTextBox
            // 
            this.populationCaptionTextBox.CanGrow = true;
            this.populationCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.1666667461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.populationCaptionTextBox.Name = "populationCaptionTextBox";
            this.populationCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.populationCaptionTextBox.StyleName = "Caption";
            this.populationCaptionTextBox.Value = "Population";
            // 
            // using01MCaptionTextBox
            // 
            this.using01MCaptionTextBox.CanGrow = true;
            this.using01MCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.703125D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.using01MCaptionTextBox.Name = "using01MCaptionTextBox";
            this.using01MCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.using01MCaptionTextBox.StyleName = "Caption";
            this.using01MCaptionTextBox.Value = "Using01M";
            // 
            // using05MCaptionTextBox
            // 
            this.using05MCaptionTextBox.CanGrow = true;
            this.using05MCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2395832538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.using05MCaptionTextBox.Name = "using05MCaptionTextBox";
            this.using05MCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.using05MCaptionTextBox.StyleName = "Caption";
            this.using05MCaptionTextBox.Value = "Using05M";
            // 
            // using20MCaptionTextBox
            // 
            this.using20MCaptionTextBox.CanGrow = true;
            this.using20MCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7760417461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.using20MCaptionTextBox.Name = "using20MCaptionTextBox";
            this.using20MCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.using20MCaptionTextBox.StyleName = "Caption";
            this.using20MCaptionTextBox.Value = "Using20M";
            // 
            // using30MCaptionTextBox
            // 
            this.using30MCaptionTextBox.CanGrow = true;
            this.using30MCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.3125D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.using30MCaptionTextBox.Name = "using30MCaptionTextBox";
            this.using30MCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.using30MCaptionTextBox.StyleName = "Caption";
            this.using30MCaptionTextBox.Value = "Using30M";
            // 
            // usingFRCaptionTextBox
            // 
            this.usingFRCaptionTextBox.CanGrow = true;
            this.usingFRCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.8489584922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.usingFRCaptionTextBox.Name = "usingFRCaptionTextBox";
            this.usingFRCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.usingFRCaptionTextBox.StyleName = "Caption";
            this.usingFRCaptionTextBox.Value = "Using FR";
            // 
            // usingMaxCaptionTextBox
            // 
            this.usingMaxCaptionTextBox.CanGrow = true;
            this.usingMaxCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.3854165077209473D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.usingMaxCaptionTextBox.Name = "usingMaxCaptionTextBox";
            this.usingMaxCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.usingMaxCaptionTextBox.StyleName = "Caption";
            this.usingMaxCaptionTextBox.Value = "Using Max";
            // 
            // noPakanCaptionTextBox
            // 
            this.noPakanCaptionTextBox.CanGrow = true;
            this.noPakanCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.921875D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.noPakanCaptionTextBox.Name = "noPakanCaptionTextBox";
            this.noPakanCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.noPakanCaptionTextBox.StyleName = "Caption";
            this.noPakanCaptionTextBox.Value = "No Pakan";
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
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.80823493003845215D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.4583334922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.787401556968689D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Daily Feeding Plan";
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
            this.pondDescriptionDataTextBox,
            this.ageDataTextBox,
            this.dateDataTextBox,
            this.mBWDataTextBox,
            this.populationDataTextBox,
            this.using01MDataTextBox,
            this.using05MDataTextBox,
            this.using20MDataTextBox,
            this.using30MDataTextBox,
            this.usingFRDataTextBox,
            this.usingMaxDataTextBox,
            this.noPakanDataTextBox});
            this.detail.Name = "detail";
            // 
            // pondDescriptionDataTextBox
            // 
            this.pondDescriptionDataTextBox.CanGrow = true;
            this.pondDescriptionDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.pondDescriptionDataTextBox.Name = "pondDescriptionDataTextBox";
            this.pondDescriptionDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.pondDescriptionDataTextBox.StyleName = "Data";
            this.pondDescriptionDataTextBox.Value = "= Fields.PondDescription";
            // 
            // ageDataTextBox
            // 
            this.ageDataTextBox.CanGrow = true;
            this.ageDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.55729168653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.ageDataTextBox.Name = "ageDataTextBox";
            this.ageDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.ageDataTextBox.StyleName = "Data";
            this.ageDataTextBox.Value = "= Fields.Age";
            // 
            // dateDataTextBox
            // 
            this.dateDataTextBox.CanGrow = true;
            this.dateDataTextBox.Format = "{0:d}";
            this.dateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.09375D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.dateDataTextBox.Name = "dateDataTextBox";
            this.dateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.dateDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            this.dateDataTextBox.StyleName = "Data";
            this.dateDataTextBox.Value = "= Fields.Date";
            // 
            // mBWDataTextBox
            // 
            this.mBWDataTextBox.CanGrow = true;
            this.mBWDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6302083730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.mBWDataTextBox.Name = "mBWDataTextBox";
            this.mBWDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.mBWDataTextBox.StyleName = "Data";
            this.mBWDataTextBox.Value = "= Fields.MBW";
            // 
            // populationDataTextBox
            // 
            this.populationDataTextBox.CanGrow = true;
            this.populationDataTextBox.Format = "{0:N0}";
            this.populationDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.1666667461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.populationDataTextBox.Name = "populationDataTextBox";
            this.populationDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.populationDataTextBox.StyleName = "Data";
            this.populationDataTextBox.Value = "= Fields.Population";
            // 
            // using01MDataTextBox
            // 
            this.using01MDataTextBox.CanGrow = true;
            this.using01MDataTextBox.Format = "{0:N2}";
            this.using01MDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.703125D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.using01MDataTextBox.Name = "using01MDataTextBox";
            this.using01MDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.using01MDataTextBox.StyleName = "Data";
            this.using01MDataTextBox.Value = "= Fields.Using01M";
            // 
            // using05MDataTextBox
            // 
            this.using05MDataTextBox.CanGrow = true;
            this.using05MDataTextBox.Format = "{0:N2}";
            this.using05MDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2395832538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.using05MDataTextBox.Name = "using05MDataTextBox";
            this.using05MDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.using05MDataTextBox.StyleName = "Data";
            this.using05MDataTextBox.Value = "= Fields.Using05M";
            // 
            // using20MDataTextBox
            // 
            this.using20MDataTextBox.CanGrow = true;
            this.using20MDataTextBox.Format = "{0:N2}";
            this.using20MDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7760417461395264D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.using20MDataTextBox.Name = "using20MDataTextBox";
            this.using20MDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.using20MDataTextBox.StyleName = "Data";
            this.using20MDataTextBox.Value = "= Fields.Using20M";
            // 
            // using30MDataTextBox
            // 
            this.using30MDataTextBox.CanGrow = true;
            this.using30MDataTextBox.Format = "{0:N2}";
            this.using30MDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.3125D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.using30MDataTextBox.Name = "using30MDataTextBox";
            this.using30MDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.using30MDataTextBox.StyleName = "Data";
            this.using30MDataTextBox.Value = "= Fields.Using30M";
            // 
            // usingFRDataTextBox
            // 
            this.usingFRDataTextBox.CanGrow = true;
            this.usingFRDataTextBox.Format = "{0:N2}";
            this.usingFRDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.8489584922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.usingFRDataTextBox.Name = "usingFRDataTextBox";
            this.usingFRDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.usingFRDataTextBox.StyleName = "Data";
            this.usingFRDataTextBox.Value = "= Fields.UsingFR";
            // 
            // usingMaxDataTextBox
            // 
            this.usingMaxDataTextBox.CanGrow = true;
            this.usingMaxDataTextBox.Format = "{0:N2}";
            this.usingMaxDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.3854165077209473D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.usingMaxDataTextBox.Name = "usingMaxDataTextBox";
            this.usingMaxDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.usingMaxDataTextBox.StyleName = "Data";
            this.usingMaxDataTextBox.Value = "= Fields.UsingMax";
            // 
            // noPakanDataTextBox
            // 
            this.noPakanDataTextBox.CanGrow = true;
            this.noPakanDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.921875D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.noPakanDataTextBox.Name = "noPakanDataTextBox";
            this.noPakanDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.515625D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.noPakanDataTextBox.StyleName = "Data";
            this.noPakanDataTextBox.Value = "= Fields.NoPakan";
            // 
            // TodayFeedingPlanReports
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
            this.Name = "TodayFeedingPlanReports";
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
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

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox pondDescriptionCaptionTextBox;
        private Telerik.Reporting.TextBox ageCaptionTextBox;
        private Telerik.Reporting.TextBox dateCaptionTextBox;
        private Telerik.Reporting.TextBox mBWCaptionTextBox;
        private Telerik.Reporting.TextBox populationCaptionTextBox;
        private Telerik.Reporting.TextBox using01MCaptionTextBox;
        private Telerik.Reporting.TextBox using05MCaptionTextBox;
        private Telerik.Reporting.TextBox using20MCaptionTextBox;
        private Telerik.Reporting.TextBox using30MCaptionTextBox;
        private Telerik.Reporting.TextBox usingFRCaptionTextBox;
        private Telerik.Reporting.TextBox usingMaxCaptionTextBox;
        private Telerik.Reporting.TextBox noPakanCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox pondDescriptionDataTextBox;
        private Telerik.Reporting.TextBox ageDataTextBox;
        private Telerik.Reporting.TextBox dateDataTextBox;
        private Telerik.Reporting.TextBox mBWDataTextBox;
        private Telerik.Reporting.TextBox populationDataTextBox;
        private Telerik.Reporting.TextBox using01MDataTextBox;
        private Telerik.Reporting.TextBox using05MDataTextBox;
        private Telerik.Reporting.TextBox using20MDataTextBox;
        private Telerik.Reporting.TextBox using30MDataTextBox;
        private Telerik.Reporting.TextBox usingFRDataTextBox;
        private Telerik.Reporting.TextBox usingMaxDataTextBox;
        private Telerik.Reporting.TextBox noPakanDataTextBox;

    }
}