namespace TambakReports
{
    partial class HarvestReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.Group group2 = new Telerik.Reporting.Group();
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.productionCycleIDCaptionTextBox = new Telerik.Reporting.TextBox();
            this.ageCaptionTextBox = new Telerik.Reporting.TextBox();
            this.harvestDateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.harvestedPopulationCaptionTextBox = new Telerik.Reporting.TextBox();
            this.isFinalHarvestCaptionTextBox = new Telerik.Reporting.TextBox();
            this.numberOfFryCaptionTextBox = new Telerik.Reporting.TextBox();
            this.sizeCaptionTextBox = new Telerik.Reporting.TextBox();
            this.weightCaptionTextBox = new Telerik.Reporting.TextBox();
            this.productionCycleIDGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.productionCycleIDGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.harvestedPopulationSumFunctionTextBox = new Telerik.Reporting.TextBox();
            this.numberOfFrySumFunctionTextBox = new Telerik.Reporting.TextBox();
            this.sizeSumFunctionTextBox = new Telerik.Reporting.TextBox();
            this.weightSumFunctionTextBox = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.ageDataTextBox = new Telerik.Reporting.TextBox();
            this.harvestDateDataTextBox = new Telerik.Reporting.TextBox();
            this.harvestedPopulationDataTextBox = new Telerik.Reporting.TextBox();
            this.isFinalHarvestDataTextBox = new Telerik.Reporting.TextBox();
            this.numberOfFryDataTextBox = new Telerik.Reporting.TextBox();
            this.sizeDataTextBox = new Telerik.Reporting.TextBox();
            this.weightDataTextBox = new Telerik.Reporting.TextBox();
            this.isFinalHarvestCountFunctionTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "TambakReports.Properties.Settings.CPL";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@ProductionCycleIDParameter", System.Data.DbType.Int32, "= Parameters.ProductionCycleIDParameter.Value")});
            this.sqlDataSource1.SelectCommand = "SELECT        ProductionCycleID, HarvestDate, Size, Weight, isFinalHarvest, Harve" +
    "stedPopulation, NumberOfFry, Age\r\nFROM            Harvest\r\nwhere ProductionCycle" +
    "ID = @ProductionCycleIDParameter";
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.productionCycleIDCaptionTextBox,
            this.ageCaptionTextBox,
            this.harvestDateCaptionTextBox,
            this.harvestedPopulationCaptionTextBox,
            this.isFinalHarvestCaptionTextBox,
            this.numberOfFryCaptionTextBox,
            this.sizeCaptionTextBox,
            this.weightCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // productionCycleIDCaptionTextBox
            // 
            this.productionCycleIDCaptionTextBox.CanGrow = true;
            this.productionCycleIDCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.productionCycleIDCaptionTextBox.Name = "productionCycleIDCaptionTextBox";
            this.productionCycleIDCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.productionCycleIDCaptionTextBox.StyleName = "Caption";
            this.productionCycleIDCaptionTextBox.Value = "Production Cycle ID";
            // 
            // ageCaptionTextBox
            // 
            this.ageCaptionTextBox.CanGrow = true;
            this.ageCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.82552081346511841D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.ageCaptionTextBox.Name = "ageCaptionTextBox";
            this.ageCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.ageCaptionTextBox.StyleName = "Caption";
            this.ageCaptionTextBox.Value = "Age";
            // 
            // harvestDateCaptionTextBox
            // 
            this.harvestDateCaptionTextBox.CanGrow = true;
            this.harvestDateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6302083730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.harvestDateCaptionTextBox.Name = "harvestDateCaptionTextBox";
            this.harvestDateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.harvestDateCaptionTextBox.StyleName = "Caption";
            this.harvestDateCaptionTextBox.Value = "Harvest Date";
            // 
            // harvestedPopulationCaptionTextBox
            // 
            this.harvestedPopulationCaptionTextBox.CanGrow = true;
            this.harvestedPopulationCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.4348957538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.harvestedPopulationCaptionTextBox.Name = "harvestedPopulationCaptionTextBox";
            this.harvestedPopulationCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.harvestedPopulationCaptionTextBox.StyleName = "Caption";
            this.harvestedPopulationCaptionTextBox.Value = "Harvested Population";
            // 
            // isFinalHarvestCaptionTextBox
            // 
            this.isFinalHarvestCaptionTextBox.CanGrow = true;
            this.isFinalHarvestCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2395832538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.isFinalHarvestCaptionTextBox.Name = "isFinalHarvestCaptionTextBox";
            this.isFinalHarvestCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.isFinalHarvestCaptionTextBox.StyleName = "Caption";
            this.isFinalHarvestCaptionTextBox.Value = "is Final Harvest";
            // 
            // numberOfFryCaptionTextBox
            // 
            this.numberOfFryCaptionTextBox.CanGrow = true;
            this.numberOfFryCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0442709922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.numberOfFryCaptionTextBox.Name = "numberOfFryCaptionTextBox";
            this.numberOfFryCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.numberOfFryCaptionTextBox.StyleName = "Caption";
            this.numberOfFryCaptionTextBox.Value = "Number Of Fry";
            // 
            // sizeCaptionTextBox
            // 
            this.sizeCaptionTextBox.CanGrow = true;
            this.sizeCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.8489584922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.sizeCaptionTextBox.Name = "sizeCaptionTextBox";
            this.sizeCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.sizeCaptionTextBox.StyleName = "Caption";
            this.sizeCaptionTextBox.Value = "Size";
            // 
            // weightCaptionTextBox
            // 
            this.weightCaptionTextBox.CanGrow = true;
            this.weightCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.6536459922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.weightCaptionTextBox.Name = "weightCaptionTextBox";
            this.weightCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.weightCaptionTextBox.StyleName = "Caption";
            this.weightCaptionTextBox.Value = "Weight";
            // 
            // productionCycleIDGroupHeaderSection
            // 
            this.productionCycleIDGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607D);
            this.productionCycleIDGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox2});
            this.productionCycleIDGroupHeaderSection.Name = "productionCycleIDGroupHeaderSection";
            // 
            // productionCycleIDGroupFooterSection
            // 
            this.productionCycleIDGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607D);
            this.productionCycleIDGroupFooterSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox3,
            this.harvestedPopulationSumFunctionTextBox,
            this.isFinalHarvestCountFunctionTextBox,
            this.numberOfFrySumFunctionTextBox,
            this.sizeSumFunctionTextBox,
            this.weightSumFunctionTextBox});
            this.productionCycleIDGroupFooterSection.Name = "productionCycleIDGroupFooterSection";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.textBox2.StyleName = "Data";
            this.textBox2.Value = "= Fields.ProductionCycleID";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = true;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.textBox3.StyleName = "Caption";
            this.textBox3.Value = "Sub-total:";
            // 
            // harvestedPopulationSumFunctionTextBox
            // 
            this.harvestedPopulationSumFunctionTextBox.CanGrow = true;
            this.harvestedPopulationSumFunctionTextBox.Format = "{0:N0}";
            this.harvestedPopulationSumFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.4348957538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.harvestedPopulationSumFunctionTextBox.Name = "harvestedPopulationSumFunctionTextBox";
            this.harvestedPopulationSumFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.harvestedPopulationSumFunctionTextBox.StyleName = "Data";
            this.harvestedPopulationSumFunctionTextBox.Value = "= Sum(Fields.HarvestedPopulation)";
            // 
            // numberOfFrySumFunctionTextBox
            // 
            this.numberOfFrySumFunctionTextBox.CanGrow = true;
            this.numberOfFrySumFunctionTextBox.Format = "{0:N0}";
            this.numberOfFrySumFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0442709922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.numberOfFrySumFunctionTextBox.Name = "numberOfFrySumFunctionTextBox";
            this.numberOfFrySumFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.numberOfFrySumFunctionTextBox.StyleName = "Data";
            this.numberOfFrySumFunctionTextBox.Value = "= Sum(Fields.NumberOfFry)";
            // 
            // sizeSumFunctionTextBox
            // 
            this.sizeSumFunctionTextBox.CanGrow = true;
            this.sizeSumFunctionTextBox.Format = "{0:N0}";
            this.sizeSumFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.8489584922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.sizeSumFunctionTextBox.Name = "sizeSumFunctionTextBox";
            this.sizeSumFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.sizeSumFunctionTextBox.StyleName = "Data";
            this.sizeSumFunctionTextBox.Value = "= Sum(Fields.Size)";
            // 
            // weightSumFunctionTextBox
            // 
            this.weightSumFunctionTextBox.CanGrow = true;
            this.weightSumFunctionTextBox.Format = "{0:N0}";
            this.weightSumFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.6536459922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.weightSumFunctionTextBox.Name = "weightSumFunctionTextBox";
            this.weightSumFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.weightSumFunctionTextBox.StyleName = "Data";
            this.weightSumFunctionTextBox.Value = "= Sum(Fields.Weight)";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.44166669249534607D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.ageDataTextBox,
            this.harvestDateDataTextBox,
            this.harvestedPopulationDataTextBox,
            this.isFinalHarvestDataTextBox,
            this.numberOfFryDataTextBox,
            this.sizeDataTextBox,
            this.weightDataTextBox});
            this.detail.Name = "detail";
            // 
            // ageDataTextBox
            // 
            this.ageDataTextBox.CanGrow = true;
            this.ageDataTextBox.Format = "{0:N0}";
            this.ageDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.82552081346511841D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.ageDataTextBox.Name = "ageDataTextBox";
            this.ageDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.ageDataTextBox.StyleName = "Data";
            this.ageDataTextBox.Value = "= Fields.Age";
            // 
            // harvestDateDataTextBox
            // 
            this.harvestDateDataTextBox.CanGrow = true;
            this.harvestDateDataTextBox.Format = "{0:d}";
            this.harvestDateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6302083730697632D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.harvestDateDataTextBox.Name = "harvestDateDataTextBox";
            this.harvestDateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.harvestDateDataTextBox.StyleName = "Data";
            this.harvestDateDataTextBox.Value = "= Fields.HarvestDate";
            // 
            // harvestedPopulationDataTextBox
            // 
            this.harvestedPopulationDataTextBox.CanGrow = true;
            this.harvestedPopulationDataTextBox.Format = "{0:N0}";
            this.harvestedPopulationDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.4348957538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.harvestedPopulationDataTextBox.Name = "harvestedPopulationDataTextBox";
            this.harvestedPopulationDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.harvestedPopulationDataTextBox.StyleName = "Data";
            this.harvestedPopulationDataTextBox.Value = "= Fields.HarvestedPopulation";
            // 
            // isFinalHarvestDataTextBox
            // 
            this.isFinalHarvestDataTextBox.CanGrow = true;
            this.isFinalHarvestDataTextBox.Format = "{0:N0}";
            this.isFinalHarvestDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2395832538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.isFinalHarvestDataTextBox.Name = "isFinalHarvestDataTextBox";
            this.isFinalHarvestDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.isFinalHarvestDataTextBox.StyleName = "Data";
            this.isFinalHarvestDataTextBox.Value = "= Fields.isFinalHarvest";
            // 
            // numberOfFryDataTextBox
            // 
            this.numberOfFryDataTextBox.CanGrow = true;
            this.numberOfFryDataTextBox.Format = "{0:N0}";
            this.numberOfFryDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.0442709922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.numberOfFryDataTextBox.Name = "numberOfFryDataTextBox";
            this.numberOfFryDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.numberOfFryDataTextBox.StyleName = "Data";
            this.numberOfFryDataTextBox.Value = "= Fields.NumberOfFry";
            // 
            // sizeDataTextBox
            // 
            this.sizeDataTextBox.CanGrow = true;
            this.sizeDataTextBox.Format = "{0:N0}";
            this.sizeDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.8489584922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.sizeDataTextBox.Name = "sizeDataTextBox";
            this.sizeDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.sizeDataTextBox.StyleName = "Data";
            this.sizeDataTextBox.Value = "= Fields.Size";
            // 
            // weightDataTextBox
            // 
            this.weightDataTextBox.CanGrow = true;
            this.weightDataTextBox.Format = "{0:N0}";
            this.weightDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.6536459922790527D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.weightDataTextBox.Name = "weightDataTextBox";
            this.weightDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.weightDataTextBox.StyleName = "Data";
            this.weightDataTextBox.Value = "= Fields.Weight";
            // 
            // isFinalHarvestCountFunctionTextBox
            // 
            this.isFinalHarvestCountFunctionTextBox.CanGrow = true;
            this.isFinalHarvestCountFunctionTextBox.Format = "{0:N0}";
            this.isFinalHarvestCountFunctionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2395832538604736D), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505D));
            this.isFinalHarvestCountFunctionTextBox.Name = "isFinalHarvestCountFunctionTextBox";
            this.isFinalHarvestCountFunctionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.78385418653488159D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.isFinalHarvestCountFunctionTextBox.StyleName = "Data";
            this.isFinalHarvestCountFunctionTextBox.Value = "= Count(Fields.isFinalHarvest)";
            // 
            // HarvestReport
            // 
            this.DataSource = this.sqlDataSource1;
            group1.GroupFooter = this.labelsGroupFooterSection;
            group1.GroupHeader = this.labelsGroupHeaderSection;
            group1.Name = "labelsGroup";
            group2.GroupFooter = this.productionCycleIDGroupFooterSection;
            group2.GroupHeader = this.productionCycleIDGroupHeaderSection;
            group2.Groupings.Add(new Telerik.Reporting.Grouping("= Fields.ProductionCycleID"));
            group2.Name = "productionCycleIDGroup";
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1,
            group2});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeaderSection,
            this.labelsGroupFooterSection,
            this.productionCycleIDGroupHeaderSection,
            this.productionCycleIDGroupFooterSection,
            this.detail});
            this.Name = "HarvestReport";
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            reportParameter1.Name = "ProductionCycleIDParameter";
            reportParameter1.Text = "ProductionCycleIDParameter";
            reportParameter1.Type = Telerik.Reporting.ReportParameterType.Integer;
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

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox productionCycleIDCaptionTextBox;
        private Telerik.Reporting.TextBox ageCaptionTextBox;
        private Telerik.Reporting.TextBox harvestDateCaptionTextBox;
        private Telerik.Reporting.TextBox harvestedPopulationCaptionTextBox;
        private Telerik.Reporting.TextBox isFinalHarvestCaptionTextBox;
        private Telerik.Reporting.TextBox numberOfFryCaptionTextBox;
        private Telerik.Reporting.TextBox sizeCaptionTextBox;
        private Telerik.Reporting.TextBox weightCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.GroupHeaderSection productionCycleIDGroupHeaderSection;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.GroupFooterSection productionCycleIDGroupFooterSection;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox harvestedPopulationSumFunctionTextBox;
        private Telerik.Reporting.TextBox numberOfFrySumFunctionTextBox;
        private Telerik.Reporting.TextBox sizeSumFunctionTextBox;
        private Telerik.Reporting.TextBox weightSumFunctionTextBox;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox ageDataTextBox;
        private Telerik.Reporting.TextBox harvestDateDataTextBox;
        private Telerik.Reporting.TextBox harvestedPopulationDataTextBox;
        private Telerik.Reporting.TextBox isFinalHarvestDataTextBox;
        private Telerik.Reporting.TextBox numberOfFryDataTextBox;
        private Telerik.Reporting.TextBox sizeDataTextBox;
        private Telerik.Reporting.TextBox weightDataTextBox;
        private Telerik.Reporting.TextBox isFinalHarvestCountFunctionTextBox;

    }
}