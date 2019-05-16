namespace WindowsFormsApplication6
{
    partial class Form15
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form15));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sntbDataSet = new WindowsFormsApplication6.sntbDataSet();
            this.sntbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.protokolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.protokolBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.protokolBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.protokolTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.protokolTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication6.sntbDataSetTableAdapters.TableAdapterManager();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.reportTableAdapter();
            this.reportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colprot_id = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coluser_id = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colname = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldolj_name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colpredpr_name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colrez_t = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colosenka = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coltest_id = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colnote = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.coltest_name = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldate_test_nach = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldate_test_okon = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coltime_test = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colvopr_v_teste = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coltruth_vopr_kol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.protokolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.protokolBindingNavigator)).BeginInit();
            this.protokolBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataMember = "report";
            this.reportBindingSource.DataSource = this.sntbDataSet;
            // 
            // sntbDataSet
            // 
            this.sntbDataSet.DataSetName = "sntbDataSet";
            this.sntbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sntbDataSetBindingSource
            // 
            this.sntbDataSetBindingSource.DataSource = this.sntbDataSet;
            this.sntbDataSetBindingSource.Position = 0;
            // 
            // protokolBindingSource
            // 
            this.protokolBindingSource.DataMember = "protokol";
            this.protokolBindingSource.DataSource = this.sntbDataSet;
            this.protokolBindingSource.CurrentChanged += new System.EventHandler(this.protokolBindingSource_CurrentChanged);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // protokolBindingNavigator
            // 
            this.protokolBindingNavigator.AddNewItem = null;
            this.protokolBindingNavigator.BindingSource = this.protokolBindingSource;
            this.protokolBindingNavigator.CountItem = null;
            this.protokolBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.protokolBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.bindingNavigatorSeparator2,
            this.protokolBindingNavigatorSaveItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton2});
            this.protokolBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.protokolBindingNavigator.MoveFirstItem = null;
            this.protokolBindingNavigator.MoveLastItem = null;
            this.protokolBindingNavigator.MoveNextItem = null;
            this.protokolBindingNavigator.MovePreviousItem = null;
            this.protokolBindingNavigator.Name = "protokolBindingNavigator";
            this.protokolBindingNavigator.PositionItem = null;
            this.protokolBindingNavigator.Size = new System.Drawing.Size(804, 25);
            this.protokolBindingNavigator.TabIndex = 0;
            this.protokolBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // protokolBindingNavigatorSaveItem
            // 
            this.protokolBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.protokolBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("protokolBindingNavigatorSaveItem.Image")));
            this.protokolBindingNavigatorSaveItem.Name = "protokolBindingNavigatorSaveItem";
            this.protokolBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.protokolBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.protokolBindingNavigatorSaveItem.Click += new System.EventHandler(this.protokolBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::WindowsFormsApplication6.Properties.Resources.imagesCAZ8LDAS;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // protokolTableAdapter
            // 
            this.protokolTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.answersTableAdapter = null;
            this.tableAdapterManager.authorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.biblio_docTableAdapter = null;
            this.tableAdapterManager.biblio_lecTableAdapter = null;
            this.tableAdapterManager.bil_testTableAdapter = null;
            this.tableAdapterManager.bil_voprTableAdapter = null;
            this.tableAdapterManager.bilTableAdapter = null;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.course_materialsTableAdapter = null;
            this.tableAdapterManager.courses_usersTableAdapter = null;
            this.tableAdapterManager.coursesTableAdapter = null;
            this.tableAdapterManager.doc_authorTableAdapter = null;
            this.tableAdapterManager.doc_categTableAdapter = null;
            this.tableAdapterManager.doc_glavaTableAdapter = null;
            this.tableAdapterManager.doc_razrTableAdapter = null;
            this.tableAdapterManager.doc_sdanTableAdapter = null;
            this.tableAdapterManager.doc_soglTableAdapter = null;
            this.tableAdapterManager.doc_temaTableAdapter = null;
            this.tableAdapterManager.doc_utvTableAdapter = null;
            this.tableAdapterManager.doljnostTableAdapter = null;
            this.tableAdapterManager.ed_groupsTableAdapter = null;
            this.tableAdapterManager.glava_punktTableAdapter = null;
            this.tableAdapterManager.grafik_sdachiTableAdapter = null;
            this.tableAdapterManager.izdatTableAdapter = null;
            this.tableAdapterManager.lecture_testsTableAdapter = null;
            this.tableAdapterManager.lecturesTableAdapter = null;
            this.tableAdapterManager.logsTableAdapter = null;
            this.tableAdapterManager.newtable1TableAdapter = null;
            this.tableAdapterManager.newtableTableAdapter = null;
            this.tableAdapterManager.NewTestTableAdapter = null;
            this.tableAdapterManager.osenkaTableAdapter = null;
            this.tableAdapterManager.otvetyTableAdapter = null;
            this.tableAdapterManager.predprTableAdapter = null;
            this.tableAdapterManager.prog_test_docTableAdapter = null;
            this.tableAdapterManager.prog_testTableAdapter = null;
            this.tableAdapterManager.progTableAdapter = null;
            this.tableAdapterManager.promtest_infoTableAdapter = null;
            this.tableAdapterManager.protokolTableAdapter = this.protokolTableAdapter;
            this.tableAdapterManager.questionsTableAdapter = null;
            this.tableAdapterManager.razrabTableAdapter = null;
            this.tableAdapterManager.shifrTableAdapter = null;
            this.tableAdapterManager.status_ed_groupsTableAdapter = null;
            this.tableAdapterManager.systemTableAdapter = null;
            this.tableAdapterManager.Table_1TableAdapter = null;
            this.tableAdapterManager.temaTableAdapter = null;
            this.tableAdapterManager.tematica_ed_groupsTableAdapter = null;
            this.tableAdapterManager.tematica_temaTableAdapter = null;
            this.tableAdapterManager.testsTableAdapter = null;
            this.tableAdapterManager.tip_voprTableAdapter = null;
            this.tableAdapterManager.truthTableAdapter = null;
            this.tableAdapterManager.ttableTableAdapter = null;
            this.tableAdapterManager.type_docTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication6.sntbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_NeActivTableAdapter = null;
            this.tableAdapterManager.user_progTableAdapter = null;
            this.tableAdapterManager.users_groupsTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.utverdTableAdapter = null;
            this.tableAdapterManager.vopr_docTableAdapter = null;
            this.tableAdapterManager.vopr_progTableAdapter = null;
            this.tableAdapterManager.vopr_protTableAdapter = null;
            this.tableAdapterManager.vopr_punktTableAdapter = null;
            this.tableAdapterManager.vopr_temaTableAdapter = null;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet";
            reportDataSource2.Value = this.reportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication6.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(798, 305);
            this.reportViewer1.TabIndex = 8;
            // 
            // reportTableAdapter
            // 
            this.reportTableAdapter.ClearBeforeFill = true;
            // 
            // reportBindingSource1
            // 
            this.reportBindingSource1.DataSource = this.sntbDataSet;
            this.reportBindingSource1.Position = 0;
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.AutoGenerateColumns = false;
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noteDataGridViewTextBoxColumn});
            this.reportDataGridView.DataSource = this.reportBindingSource;
            this.reportDataGridView.Location = new System.Drawing.Point(53, 684);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.Size = new System.Drawing.Size(300, 220);
            this.reportDataGridView.TabIndex = 9;
            this.reportDataGridView.Visible = false;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(1, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 311);
            this.panel1.TabIndex = 12;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.protokolBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 28);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(804, 233);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colprot_id,
            this.coluser_id,
            this.colname,
            this.coldolj_name,
            this.colpredpr_name,
            this.coltest_id,
            this.coltest_name,
            this.coldate_test_nach,
            this.coldate_test_okon,
            this.coltime_test,
            this.colvopr_v_teste,
            this.coltruth_vopr_kol,
            this.colrez_t,
            this.colosenka,
            this.colnote});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsBehavior.Editable = false;
            this.advBandedGridView1.OptionsBehavior.ReadOnly = true;
            this.advBandedGridView1.OptionsView.ShowAutoFilterRow = true;
            this.advBandedGridView1.OptionsView.ShowFooter = true;
            this.advBandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Информация о сотруднике";
            this.gridBand1.Columns.Add(this.colprot_id);
            this.gridBand1.Columns.Add(this.coluser_id);
            this.gridBand1.Columns.Add(this.colname);
            this.gridBand1.Columns.Add(this.coldolj_name);
            this.gridBand1.Columns.Add(this.colpredpr_name);
            this.gridBand1.Columns.Add(this.colrez_t);
            this.gridBand1.Columns.Add(this.colosenka);
            this.gridBand1.Columns.Add(this.coltest_id);
            this.gridBand1.Columns.Add(this.colnote);
            this.gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 682;
            // 
            // colprot_id
            // 
            this.colprot_id.FieldName = "prot_id";
            this.colprot_id.Name = "colprot_id";
            this.colprot_id.OptionsColumn.ReadOnly = true;
            // 
            // coluser_id
            // 
            this.coluser_id.FieldName = "user_id";
            this.coluser_id.Name = "coluser_id";
            this.coluser_id.OptionsColumn.ReadOnly = true;
            // 
            // colname
            // 
            this.colname.Caption = "Ф.И.О.";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.OptionsColumn.ReadOnly = true;
            this.colname.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colname.Visible = true;
            this.colname.Width = 177;
            // 
            // coldolj_name
            // 
            this.coldolj_name.Caption = "Должность";
            this.coldolj_name.FieldName = "dolj_name";
            this.coldolj_name.Name = "coldolj_name";
            this.coldolj_name.OptionsColumn.ReadOnly = true;
            this.coldolj_name.Visible = true;
            this.coldolj_name.Width = 165;
            // 
            // colpredpr_name
            // 
            this.colpredpr_name.Caption = "Подразделение";
            this.colpredpr_name.FieldName = "predpr_name";
            this.colpredpr_name.Name = "colpredpr_name";
            this.colpredpr_name.OptionsColumn.ReadOnly = true;
            this.colpredpr_name.Visible = true;
            this.colpredpr_name.Width = 169;
            // 
            // colrez_t
            // 
            this.colrez_t.Caption = "Результат";
            this.colrez_t.FieldName = "rez_t";
            this.colrez_t.Name = "colrez_t";
            this.colrez_t.OptionsColumn.ReadOnly = true;
            this.colrez_t.Visible = true;
            this.colrez_t.Width = 96;
            // 
            // colosenka
            // 
            this.colosenka.Caption = "Оценка";
            this.colosenka.FieldName = "osenka";
            this.colosenka.Name = "colosenka";
            this.colosenka.Visible = true;
            // 
            // coltest_id
            // 
            this.coltest_id.FieldName = "test_id";
            this.coltest_id.Name = "coltest_id";
            this.coltest_id.OptionsColumn.ReadOnly = true;
            // 
            // colnote
            // 
            this.colnote.FieldName = "note";
            this.colnote.Name = "colnote";
            this.colnote.OptionsColumn.ReadOnly = true;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Результаты тестирования";
            this.gridBand2.Columns.Add(this.coltest_name);
            this.gridBand2.Columns.Add(this.coldate_test_nach);
            this.gridBand2.Columns.Add(this.coldate_test_okon);
            this.gridBand2.Columns.Add(this.coltime_test);
            this.gridBand2.Columns.Add(this.colvopr_v_teste);
            this.gridBand2.Columns.Add(this.coltruth_vopr_kol);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 757;
            // 
            // coltest_name
            // 
            this.coltest_name.Caption = "Название теста";
            this.coltest_name.FieldName = "test_name";
            this.coltest_name.Name = "coltest_name";
            this.coltest_name.OptionsColumn.ReadOnly = true;
            this.coltest_name.Visible = true;
            this.coltest_name.Width = 171;
            // 
            // coldate_test_nach
            // 
            this.coldate_test_nach.Caption = "Начало тестирования";
            this.coldate_test_nach.FieldName = "date_test_nach";
            this.coldate_test_nach.Name = "coldate_test_nach";
            this.coldate_test_nach.OptionsColumn.ReadOnly = true;
            this.coldate_test_nach.Visible = true;
            this.coldate_test_nach.Width = 142;
            // 
            // coldate_test_okon
            // 
            this.coldate_test_okon.Caption = "Окончание тестирования";
            this.coldate_test_okon.FieldName = "date_test_okon";
            this.coldate_test_okon.Name = "coldate_test_okon";
            this.coldate_test_okon.OptionsColumn.ReadOnly = true;
            this.coldate_test_okon.Visible = true;
            this.coldate_test_okon.Width = 163;
            // 
            // coltime_test
            // 
            this.coltime_test.Caption = "Время";
            this.coltime_test.FieldName = "time_test";
            this.coltime_test.Name = "coltime_test";
            this.coltime_test.OptionsColumn.ReadOnly = true;
            this.coltime_test.Visible = true;
            this.coltime_test.Width = 68;
            // 
            // colvopr_v_teste
            // 
            this.colvopr_v_teste.Caption = "Кол.вопросов в тесте";
            this.colvopr_v_teste.FieldName = "vopr_v_teste";
            this.colvopr_v_teste.Name = "colvopr_v_teste";
            this.colvopr_v_teste.OptionsColumn.ReadOnly = true;
            this.colvopr_v_teste.Visible = true;
            this.colvopr_v_teste.Width = 103;
            // 
            // coltruth_vopr_kol
            // 
            this.coltruth_vopr_kol.Caption = "Кол-во прав.ответов";
            this.coltruth_vopr_kol.FieldName = "truth_vopr_kol";
            this.coltruth_vopr_kol.Name = "coltruth_vopr_kol";
            this.coltruth_vopr_kol.OptionsColumn.ReadOnly = true;
            this.coltruth_vopr_kol.Visible = true;
            this.coltruth_vopr_kol.Width = 110;
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 590);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.protokolBindingNavigator);
            this.Controls.Add(this.reportDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Stardust";
            this.Name = "Form15";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Протокол";
            this.Load += new System.EventHandler(this.Form15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.protokolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.protokolBindingNavigator)).EndInit();
            this.protokolBindingNavigator.ResumeLayout(false);
            this.protokolBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sntbDataSet sntbDataSet;
        private System.Windows.Forms.BindingSource protokolBindingSource;
        private sntbDataSetTableAdapters.protokolTableAdapter protokolTableAdapter;
        private sntbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton protokolBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator protokolBindingNavigator;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private sntbDataSetTableAdapters.reportTableAdapter reportTableAdapter;
        private System.Windows.Forms.BindingSource reportBindingSource1;
        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.BindingSource sntbDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colprot_id;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coluser_id;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colname;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldolj_name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colpredpr_name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colrez_t;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coltest_id;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colnote;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coltest_name;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldate_test_nach;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldate_test_okon;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coltime_test;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colvopr_v_teste;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coltruth_vopr_kol;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colosenka;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}