namespace TambakReports
{
    partial class CurrentWaterParameterReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentWaterParameterReport));
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.logDateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pondDescriptionCaptionTextBox = new Telerik.Reporting.TextBox();
            this.productionCycleIDCaptionTextBox = new Telerik.Reporting.TextBox();
            this.minDOCaptionTextBox = new Telerik.Reporting.TextBox();
            this.maxDOCaptionTextBox = new Telerik.Reporting.TextBox();
            this.rangeDOCaptionTextBox = new Telerik.Reporting.TextBox();
            this.minPHCaptionTextBox = new Telerik.Reporting.TextBox();
            this.maxPHCaptionTextBox = new Telerik.Reporting.TextBox();
            this.rangePHCaptionTextBox = new Telerik.Reporting.TextBox();
            this.maxTempCaptionTextBox = new Telerik.Reporting.TextBox();
            this.minTempCaptionTextBox = new Telerik.Reporting.TextBox();
            this.temperatureRangeCaptionTextBox = new Telerik.Reporting.TextBox();
            this.totalOrganicMaterialCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.logDateDataTextBox = new Telerik.Reporting.TextBox();
            this.pondDescriptionDataTextBox = new Telerik.Reporting.TextBox();
            this.productionCycleIDDataTextBox = new Telerik.Reporting.TextBox();
            this.minDODataTextBox = new Telerik.Reporting.TextBox();
            this.maxDODataTextBox = new Telerik.Reporting.TextBox();
            this.rangeDODataTextBox = new Telerik.Reporting.TextBox();
            this.minPHDataTextBox = new Telerik.Reporting.TextBox();
            this.maxPHDataTextBox = new Telerik.Reporting.TextBox();
            this.rangePHDataTextBox = new Telerik.Reporting.TextBox();
            this.maxTempDataTextBox = new Telerik.Reporting.TextBox();
            this.minTempDataTextBox = new Telerik.Reporting.TextBox();
            this.temperatureRangeDataTextBox = new Telerik.Reporting.TextBox();
            this.totalOrganicMaterialDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "TambakReports.Properties.Settings.CPL";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.SelectCommand = resources.GetString("sqlDataSource1.SelectCommand");
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.logDateCaptionTextBox,
            this.pondDescriptionCaptionTextBox,
            this.productionCycleIDCaptionTextBox,
            this.minDOCaptionTextBox,
            this.maxDOCaptionTextBox,
            this.rangeDOCaptionTextBox,
            this.minPHCaptionTextBox,
            this.maxPHCaptionTextBox,
            this.rangePHCaptionTextBox,
            this.maxTempCaptionTextBox,
            this.minTempCaptionTextBox,
            this.temperatureRangeCaptionTextBox,
            this.totalOrganicMaterialCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // logDateCaptionTextBox
            // 
            this.logDateCaptionTextBox.CanGrow = true;
            this.logDateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.logDateCaptionTextBox.Name = "logDateCaptionTextBox";
            this.logDateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.logDateCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.logDateCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.logDateCaptionTextBox.StyleName = "Caption";
            this.logDateCaptionTextBox.Value = "Date";
            // 
            // pondDescriptionCaptionTextBox
            // 
            this.pondDescriptionCaptionTextBox.CanGrow = true;
            this.pondDescriptionCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.51602566242218018D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.pondDescriptionCaptionTextBox.Name = "pondDescriptionCaptionTextBox";
            this.pondDescriptionCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.pondDescriptionCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.pondDescriptionCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.pondDescriptionCaptionTextBox.StyleName = "Caption";
            this.pondDescriptionCaptionTextBox.Value = "Pond";
            // 
            // productionCycleIDCaptionTextBox
            // 
            this.productionCycleIDCaptionTextBox.CanGrow = true;
            this.productionCycleIDCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0112179517745972D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.productionCycleIDCaptionTextBox.Name = "productionCycleIDCaptionTextBox";
            this.productionCycleIDCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.productionCycleIDCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.productionCycleIDCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.productionCycleIDCaptionTextBox.StyleName = "Caption";
            this.productionCycleIDCaptionTextBox.Value = "Cycle";
            // 
            // minDOCaptionTextBox
            // 
            this.minDOCaptionTextBox.CanGrow = true;
            this.minDOCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5064102411270142D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.minDOCaptionTextBox.Name = "minDOCaptionTextBox";
            this.minDOCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.minDOCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.minDOCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.minDOCaptionTextBox.StyleName = "Caption";
            this.minDOCaptionTextBox.Value = "Min DO";
            // 
            // maxDOCaptionTextBox
            // 
            this.maxDOCaptionTextBox.CanGrow = true;
            this.maxDOCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.0016026496887207D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.maxDOCaptionTextBox.Name = "maxDOCaptionTextBox";
            this.maxDOCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.maxDOCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.maxDOCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.maxDOCaptionTextBox.StyleName = "Caption";
            this.maxDOCaptionTextBox.Value = "Max DO";
            // 
            // rangeDOCaptionTextBox
            // 
            this.rangeDOCaptionTextBox.CanGrow = true;
            this.rangeDOCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.4967949390411377D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.rangeDOCaptionTextBox.Name = "rangeDOCaptionTextBox";
            this.rangeDOCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.rangeDOCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.rangeDOCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.rangeDOCaptionTextBox.StyleName = "Caption";
            this.rangeDOCaptionTextBox.Value = "Range DO";
            // 
            // minPHCaptionTextBox
            // 
            this.minPHCaptionTextBox.CanGrow = true;
            this.minPHCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.9919872283935547D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.minPHCaptionTextBox.Name = "minPHCaptionTextBox";
            this.minPHCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.minPHCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.minPHCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.minPHCaptionTextBox.StyleName = "Caption";
            this.minPHCaptionTextBox.Value = "Min PH";
            // 
            // maxPHCaptionTextBox
            // 
            this.maxPHCaptionTextBox.CanGrow = true;
            this.maxPHCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.4871795177459717D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.maxPHCaptionTextBox.Name = "maxPHCaptionTextBox";
            this.maxPHCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.maxPHCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.maxPHCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.maxPHCaptionTextBox.StyleName = "Caption";
            this.maxPHCaptionTextBox.Value = "Max PH";
            // 
            // rangePHCaptionTextBox
            // 
            this.rangePHCaptionTextBox.CanGrow = true;
            this.rangePHCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9823718070983887D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.rangePHCaptionTextBox.Name = "rangePHCaptionTextBox";
            this.rangePHCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.rangePHCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.rangePHCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.rangePHCaptionTextBox.StyleName = "Caption";
            this.rangePHCaptionTextBox.Value = "Range PH";
            // 
            // maxTempCaptionTextBox
            // 
            this.maxTempCaptionTextBox.CanGrow = true;
            this.maxTempCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.4775643348693848D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.maxTempCaptionTextBox.Name = "maxTempCaptionTextBox";
            this.maxTempCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.maxTempCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.maxTempCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.maxTempCaptionTextBox.StyleName = "Caption";
            this.maxTempCaptionTextBox.Value = "Max Temp";
            // 
            // minTempCaptionTextBox
            // 
            this.minTempCaptionTextBox.CanGrow = true;
            this.minTempCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9727563858032227D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.minTempCaptionTextBox.Name = "minTempCaptionTextBox";
            this.minTempCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.minTempCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.minTempCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.minTempCaptionTextBox.StyleName = "Caption";
            this.minTempCaptionTextBox.Value = "Min Temp";
            // 
            // temperatureRangeCaptionTextBox
            // 
            this.temperatureRangeCaptionTextBox.CanGrow = true;
            this.temperatureRangeCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.4679489135742188D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.temperatureRangeCaptionTextBox.Name = "temperatureRangeCaptionTextBox";
            this.temperatureRangeCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.temperatureRangeCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.temperatureRangeCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.temperatureRangeCaptionTextBox.StyleName = "Caption";
            this.temperatureRangeCaptionTextBox.Value = "Temp Range";
            // 
            // totalOrganicMaterialCaptionTextBox
            // 
            this.totalOrganicMaterialCaptionTextBox.CanGrow = true;
            this.totalOrganicMaterialCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.9631409645080566D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.totalOrganicMaterialCaptionTextBox.Name = "totalOrganicMaterialCaptionTextBox";
            this.totalOrganicMaterialCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.totalOrganicMaterialCaptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.totalOrganicMaterialCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.totalOrganicMaterialCaptionTextBox.StyleName = "Caption";
            this.totalOrganicMaterialCaptionTextBox.Value = "TOM";
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
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.4583334922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "Water Parameter";
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
            this.logDateDataTextBox,
            this.pondDescriptionDataTextBox,
            this.productionCycleIDDataTextBox,
            this.minDODataTextBox,
            this.maxDODataTextBox,
            this.rangeDODataTextBox,
            this.minPHDataTextBox,
            this.maxPHDataTextBox,
            this.rangePHDataTextBox,
            this.maxTempDataTextBox,
            this.minTempDataTextBox,
            this.temperatureRangeDataTextBox,
            this.totalOrganicMaterialDataTextBox});
            this.detail.Name = "detail";
            // 
            // logDateDataTextBox
            // 
            this.logDateDataTextBox.CanGrow = true;
            this.logDateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.logDateDataTextBox.Name = "logDateDataTextBox";
            this.logDateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.logDateDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.logDateDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.logDateDataTextBox.StyleName = "Data";
            this.logDateDataTextBox.Value = "= Fields.LogDate";
            // 
            // pondDescriptionDataTextBox
            // 
            this.pondDescriptionDataTextBox.CanGrow = true;
            this.pondDescriptionDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.51602566242218018D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.pondDescriptionDataTextBox.Name = "pondDescriptionDataTextBox";
            this.pondDescriptionDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.pondDescriptionDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.pondDescriptionDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.pondDescriptionDataTextBox.StyleName = "Data";
            this.pondDescriptionDataTextBox.Value = "= Fields.PondDescription";
            // 
            // productionCycleIDDataTextBox
            // 
            this.productionCycleIDDataTextBox.CanGrow = true;
            this.productionCycleIDDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0112179517745972D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.productionCycleIDDataTextBox.Name = "productionCycleIDDataTextBox";
            this.productionCycleIDDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.productionCycleIDDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.productionCycleIDDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.productionCycleIDDataTextBox.StyleName = "Data";
            this.productionCycleIDDataTextBox.Value = "= Fields.ProductionCycleID";
            // 
            // minDODataTextBox
            // 
            this.minDODataTextBox.CanGrow = true;
            this.minDODataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5064102411270142D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.minDODataTextBox.Name = "minDODataTextBox";
            this.minDODataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.minDODataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.minDODataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.minDODataTextBox.StyleName = "Data";
            this.minDODataTextBox.Value = "= Fields.MinDO";
            // 
            // maxDODataTextBox
            // 
            this.maxDODataTextBox.CanGrow = true;
            this.maxDODataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.0016026496887207D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.maxDODataTextBox.Name = "maxDODataTextBox";
            this.maxDODataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.maxDODataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.maxDODataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.maxDODataTextBox.StyleName = "Data";
            this.maxDODataTextBox.Value = "= Fields.MaxDO";
            // 
            // rangeDODataTextBox
            // 
            this.rangeDODataTextBox.CanGrow = true;
            this.rangeDODataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.4967949390411377D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.rangeDODataTextBox.Name = "rangeDODataTextBox";
            this.rangeDODataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.rangeDODataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.rangeDODataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.rangeDODataTextBox.StyleName = "Data";
            this.rangeDODataTextBox.Value = "= Fields.RangeDO";
            // 
            // minPHDataTextBox
            // 
            this.minPHDataTextBox.CanGrow = true;
            this.minPHDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.9919872283935547D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.minPHDataTextBox.Name = "minPHDataTextBox";
            this.minPHDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.minPHDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.minPHDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.minPHDataTextBox.StyleName = "Data";
            this.minPHDataTextBox.Value = "= Fields.MinPH";
            // 
            // maxPHDataTextBox
            // 
            this.maxPHDataTextBox.CanGrow = true;
            this.maxPHDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.4871795177459717D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.maxPHDataTextBox.Name = "maxPHDataTextBox";
            this.maxPHDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.maxPHDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.maxPHDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.maxPHDataTextBox.StyleName = "Data";
            this.maxPHDataTextBox.Value = "= Fields.MaxPH";
            // 
            // rangePHDataTextBox
            // 
            this.rangePHDataTextBox.CanGrow = true;
            this.rangePHDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9823718070983887D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.rangePHDataTextBox.Name = "rangePHDataTextBox";
            this.rangePHDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.rangePHDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.rangePHDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.rangePHDataTextBox.StyleName = "Data";
            this.rangePHDataTextBox.Value = "= Fields.RangePH";
            // 
            // maxTempDataTextBox
            // 
            this.maxTempDataTextBox.CanGrow = true;
            this.maxTempDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.4775643348693848D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.maxTempDataTextBox.Name = "maxTempDataTextBox";
            this.maxTempDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.maxTempDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.maxTempDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.maxTempDataTextBox.StyleName = "Data";
            this.maxTempDataTextBox.Value = "= Fields.MaxTemp";
            // 
            // minTempDataTextBox
            // 
            this.minTempDataTextBox.CanGrow = true;
            this.minTempDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.9727563858032227D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.minTempDataTextBox.Name = "minTempDataTextBox";
            this.minTempDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.minTempDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.minTempDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.minTempDataTextBox.StyleName = "Data";
            this.minTempDataTextBox.Value = "= Fields.MinTemp";
            // 
            // temperatureRangeDataTextBox
            // 
            this.temperatureRangeDataTextBox.CanGrow = true;
            this.temperatureRangeDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.4679489135742188D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.temperatureRangeDataTextBox.Name = "temperatureRangeDataTextBox";
            this.temperatureRangeDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.temperatureRangeDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.temperatureRangeDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.temperatureRangeDataTextBox.StyleName = "Data";
            this.temperatureRangeDataTextBox.Value = "= Fields.TemperatureRange";
            // 
            // totalOrganicMaterialDataTextBox
            // 
            this.totalOrganicMaterialDataTextBox.CanGrow = true;
            this.totalOrganicMaterialDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.9631409645080566D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.totalOrganicMaterialDataTextBox.Name = "totalOrganicMaterialDataTextBox";
            this.totalOrganicMaterialDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.47435897588729858D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.totalOrganicMaterialDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.totalOrganicMaterialDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.totalOrganicMaterialDataTextBox.StyleName = "Data";
            this.totalOrganicMaterialDataTextBox.Value = "= Fields.TotalOrganicMaterial";
            // 
            // CurrentWaterParameterReport
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
            this.Name = "CurrentWaterParameterReport";
            this.PageSettings.Landscape = true;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
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
        private Telerik.Reporting.TextBox logDateCaptionTextBox;
        private Telerik.Reporting.TextBox pondDescriptionCaptionTextBox;
        private Telerik.Reporting.TextBox productionCycleIDCaptionTextBox;
        private Telerik.Reporting.TextBox minDOCaptionTextBox;
        private Telerik.Reporting.TextBox maxDOCaptionTextBox;
        private Telerik.Reporting.TextBox rangeDOCaptionTextBox;
        private Telerik.Reporting.TextBox minPHCaptionTextBox;
        private Telerik.Reporting.TextBox maxPHCaptionTextBox;
        private Telerik.Reporting.TextBox rangePHCaptionTextBox;
        private Telerik.Reporting.TextBox maxTempCaptionTextBox;
        private Telerik.Reporting.TextBox minTempCaptionTextBox;
        private Telerik.Reporting.TextBox temperatureRangeCaptionTextBox;
        private Telerik.Reporting.TextBox totalOrganicMaterialCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox logDateDataTextBox;
        private Telerik.Reporting.TextBox pondDescriptionDataTextBox;
        private Telerik.Reporting.TextBox productionCycleIDDataTextBox;
        private Telerik.Reporting.TextBox minDODataTextBox;
        private Telerik.Reporting.TextBox maxDODataTextBox;
        private Telerik.Reporting.TextBox rangeDODataTextBox;
        private Telerik.Reporting.TextBox minPHDataTextBox;
        private Telerik.Reporting.TextBox maxPHDataTextBox;
        private Telerik.Reporting.TextBox rangePHDataTextBox;
        private Telerik.Reporting.TextBox maxTempDataTextBox;
        private Telerik.Reporting.TextBox minTempDataTextBox;
        private Telerik.Reporting.TextBox temperatureRangeDataTextBox;
        private Telerik.Reporting.TextBox totalOrganicMaterialDataTextBox;

    }
}