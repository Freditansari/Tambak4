namespace TambakReports
{
    partial class MaxFoodReports
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
            this.productionCycleIDCaptionTextBox = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.targetSR20CaptionTextBox = new Telerik.Reporting.TextBox();
            this.targetSR30CaptionTextBox = new Telerik.Reporting.TextBox();
            this.targetSR50CaptionTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.productionCycleIDSumFunctionTextBox = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.targetSR20SumFunctionTextBox = new Telerik.Reporting.TextBox();
            this.targetSR30SumFunctionTextBox = new Telerik.Reporting.TextBox();
            this.targetSR50SumFunctionTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.pondDescriptionDataTextBox = new Telerik.Reporting.TextBox();
            this.productionCycleIDDataTextBox = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.targetSR20DataTextBox = new Telerik.Reporting.TextBox();
            this.targetSR30DataTextBox = new Telerik.Reporting.TextBox();
            this.targetSR50DataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "TambakReports.Properties.Settings.CPL";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.SelectCommand = "SELECT        MaxFoodDiminishingSRView.*\r\nFROM            MaxFoodDiminishingSRVie" +
    "w";
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pondDescriptionCaptionTextBox,
            this.productionCycleIDCaptionTextBox,
            this.textBox1,
            this.targetSR20CaptionTextBox,
            this.targetSR30CaptionTextBox,
            this.targetSR50CaptionTextBox});
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
            this.pondDescriptionCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.46875D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.pondDescriptionCaptionTextBox.StyleName = "Caption";
            this.pondDescriptionCaptionTextBox.Value = "Pond Description";
            // 
            // productionCycleIDCaptionTextBox
            // 
            this.productionCycleIDCaptionTextBox.CanGrow = true;
            this.productionCycleIDCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5104166269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.productionCycleIDCaptionTextBox.Name = "productionCycleIDCaptionTextBox";
            this.productionCycleIDCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.46875D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.productionCycleIDCaptionTextBox.StyleName = "Caption";
            this.productionCycleIDCaptionTextBox.Value = "Production Cycle ID";
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.46875D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox1.StyleName = "Caption";
            this.textBox1.Value = "Current Age";
            // 
            // targetSR20CaptionTextBox
            // 
            this.targetSR20CaptionTextBox.CanGrow = true;
            this.targetSR20CaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.4895834922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.targetSR20CaptionTextBox.Name = "targetSR20CaptionTextBox";
            this.targetSR20CaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.46875D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.targetSR20CaptionTextBox.StyleName = "Caption";
            this.targetSR20CaptionTextBox.Value = "Target SR20";
            // 
            // targetSR30CaptionTextBox
            // 
            this.targetSR30CaptionTextBox.CanGrow = true;
            this.targetSR30CaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.9791665077209473D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.targetSR30CaptionTextBox.Name = "targetSR30CaptionTextBox";
            this.targetSR30CaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.46875D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.targetSR30CaptionTextBox.StyleName = "Caption";
            this.targetSR30CaptionTextBox.Value = "Target SR30";
            // 
            // targetSR50CaptionTextBox
            // 
            this.targetSR50CaptionTextBox.CanGrow = true;
            this.targetSR50CaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.46875D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.targetSR50CaptionTextBox.Name = "targetSR50CaptionTextBox";
            this.targetSR50CaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.46875D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.targetSR50CaptionTextBox.StyleName = "Caption";
            this.targetSR50CaptionTextBox.Value = "Target SR50";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.reportFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox2,
            this.productionCycleIDSumFunctionTextBox,
            this.textBox3,
            this.targetSR20SumFunctionTextBox,
            this.targetSR30SumFunctionTextBox,
            this.targetSR50SumFunctionTextBox});
            this.reportFooter.Name = "reportFooter";
            this.reportFooter.Style.Visible = true;
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.46875D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox2.StyleName = "Caption";
            this.textBox2.Value = "Grand total:";
            // 
            // productionCycleIDSumFunctionTextBox
            // 
            this.productionCycleIDSumFunctionTextBox.CanGrow = true;
            this.productionCycleIDSumFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5104166269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.productionCycleIDSumFunctionTextBox.Name = "productionCycleIDSumFunctionTextBox";
            this.productionCycleIDSumFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.46875D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.productionCycleIDSumFunctionTextBox.StyleName = "Data";
            this.productionCycleIDSumFunctionTextBox.Value = "= Sum(Fields.ProductionCycleID)";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = true;
            this.textBox3.Format = "{0:N1}";
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.46875D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox3.StyleName = "Data";
            this.textBox3.Value = "= Sum(Fields.[Current Age])";
            // 
            // targetSR20SumFunctionTextBox
            // 
            this.targetSR20SumFunctionTextBox.CanGrow = true;
            this.targetSR20SumFunctionTextBox.Format = "{0:N1}";
            this.targetSR20SumFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.4895834922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.targetSR20SumFunctionTextBox.Name = "targetSR20SumFunctionTextBox";
            this.targetSR20SumFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.46875D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.targetSR20SumFunctionTextBox.StyleName = "Data";
            this.targetSR20SumFunctionTextBox.Value = "= Sum(Fields.TargetSR20)";
            // 
            // targetSR30SumFunctionTextBox
            // 
            this.targetSR30SumFunctionTextBox.CanGrow = true;
            this.targetSR30SumFunctionTextBox.Format = "{0:N1}";
            this.targetSR30SumFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.9791665077209473D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.targetSR30SumFunctionTextBox.Name = "targetSR30SumFunctionTextBox";
            this.targetSR30SumFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.46875D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.targetSR30SumFunctionTextBox.StyleName = "Data";
            this.targetSR30SumFunctionTextBox.Value = "= Sum(Fields.TargetSR30)";
            // 
            // targetSR50SumFunctionTextBox
            // 
            this.targetSR50SumFunctionTextBox.CanGrow = true;
            this.targetSR50SumFunctionTextBox.Format = "{0:N1}";
            this.targetSR50SumFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.46875D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.targetSR50SumFunctionTextBox.Name = "targetSR50SumFunctionTextBox";
            this.targetSR50SumFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.46875D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.targetSR50SumFunctionTextBox.StyleName = "Data";
            this.targetSR50SumFunctionTextBox.Value = "= Sum(Fields.TargetSR50)";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.currentTimeTextBox,
            this.pageInfoTextBox});
            this.pageFooter.Name = "pageFooter";
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.4479165077209473D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.4895834922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.4479165077209473D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
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
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.9583330154418945D), Telerik.Reporting.Drawing.Unit.Inch(0.787401556968689D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Maximum daily feed";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pondDescriptionDataTextBox,
            this.productionCycleIDDataTextBox,
            this.textBox4,
            this.targetSR20DataTextBox,
            this.targetSR30DataTextBox,
            this.targetSR50DataTextBox});
            this.detail.Name = "detail";
            // 
            // pondDescriptionDataTextBox
            // 
            this.pondDescriptionDataTextBox.CanGrow = true;
            this.pondDescriptionDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.pondDescriptionDataTextBox.Name = "pondDescriptionDataTextBox";
            this.pondDescriptionDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.46875D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.pondDescriptionDataTextBox.StyleName = "Data";
            this.pondDescriptionDataTextBox.Value = "= Fields.PondDescription";
            // 
            // productionCycleIDDataTextBox
            // 
            this.productionCycleIDDataTextBox.CanGrow = true;
            this.productionCycleIDDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5104166269302368D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.productionCycleIDDataTextBox.Name = "productionCycleIDDataTextBox";
            this.productionCycleIDDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.46875D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.productionCycleIDDataTextBox.StyleName = "Data";
            this.productionCycleIDDataTextBox.Value = "= Fields.ProductionCycleID";
            // 
            // textBox4
            // 
            this.textBox4.CanGrow = true;
            this.textBox4.Format = "{0:N1}";
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.46875D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.textBox4.StyleName = "Data";
            this.textBox4.Value = "= Fields.[Current Age]";
            // 
            // targetSR20DataTextBox
            // 
            this.targetSR20DataTextBox.CanGrow = true;
            this.targetSR20DataTextBox.Format = "{0:N1}";
            this.targetSR20DataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.4895834922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.targetSR20DataTextBox.Name = "targetSR20DataTextBox";
            this.targetSR20DataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.46875D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.targetSR20DataTextBox.StyleName = "Data";
            this.targetSR20DataTextBox.Value = "= Fields.TargetSR20";
            // 
            // targetSR30DataTextBox
            // 
            this.targetSR30DataTextBox.CanGrow = true;
            this.targetSR30DataTextBox.Format = "{0:N1}";
            this.targetSR30DataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.9791665077209473D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.targetSR30DataTextBox.Name = "targetSR30DataTextBox";
            this.targetSR30DataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.46875D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.targetSR30DataTextBox.StyleName = "Data";
            this.targetSR30DataTextBox.Value = "= Fields.TargetSR30";
            // 
            // targetSR50DataTextBox
            // 
            this.targetSR50DataTextBox.CanGrow = true;
            this.targetSR50DataTextBox.Format = "{0:N1}";
            this.targetSR50DataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.46875D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.targetSR50DataTextBox.Name = "targetSR50DataTextBox";
            this.targetSR50DataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.46875D), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224D));
            this.targetSR50DataTextBox.StyleName = "Data";
            this.targetSR50DataTextBox.Value = "= Fields.TargetSR50";
            // 
            // MaxFoodReports
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
            this.reportFooter,
            this.pageFooter,
            this.reportHeader,
            this.detail});
            this.Name = "MaxFoodReports";
            this.PageSettings.Landscape = true;
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
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(8.9583330154418945D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox pondDescriptionCaptionTextBox;
        private Telerik.Reporting.TextBox productionCycleIDCaptionTextBox;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox targetSR20CaptionTextBox;
        private Telerik.Reporting.TextBox targetSR30CaptionTextBox;
        private Telerik.Reporting.TextBox targetSR50CaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox productionCycleIDSumFunctionTextBox;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox targetSR20SumFunctionTextBox;
        private Telerik.Reporting.TextBox targetSR30SumFunctionTextBox;
        private Telerik.Reporting.TextBox targetSR50SumFunctionTextBox;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox pondDescriptionDataTextBox;
        private Telerik.Reporting.TextBox productionCycleIDDataTextBox;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox targetSR20DataTextBox;
        private Telerik.Reporting.TextBox targetSR30DataTextBox;
        private Telerik.Reporting.TextBox targetSR50DataTextBox;

    }
}