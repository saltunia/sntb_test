namespace WindowsFormsApplication6
{
    partial class grafik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(grafik));
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.predprBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sntbDataSet = new WindowsFormsApplication6.sntbDataSet();
            this.grafik_sdachiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grafik_sdachiTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.grafik_sdachiTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication6.sntbDataSetTableAdapters.TableAdapterManager();
            this.grafik_sdachiGridControl = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colid_res = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colfio = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldolj = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colgr_po_tb = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colptb = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colpte = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colppb = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.predprTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.predprTableAdapter();
            this.simpleButton17 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton18 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit5 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit6 = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predprBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik_sdachiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik_sdachiGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit5.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit6.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("predpr_name", "Подразделение")});
            this.repositoryItemLookUpEdit1.DataSource = this.predprBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "predpr_name";
            this.repositoryItemLookUpEdit1.LookAndFeel.SkinName = "Stardust";
            this.repositoryItemLookUpEdit1.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "predpr_id";
            // 
            // predprBindingSource
            // 
            this.predprBindingSource.DataMember = "predpr";
            this.predprBindingSource.DataSource = this.sntbDataSet;
            // 
            // sntbDataSet
            // 
            this.sntbDataSet.DataSetName = "sntbDataSet";
            this.sntbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grafik_sdachiBindingSource
            // 
            this.grafik_sdachiBindingSource.DataMember = "grafik_sdachi";
            this.grafik_sdachiBindingSource.DataSource = this.sntbDataSet;
            this.grafik_sdachiBindingSource.CurrentItemChanged += new System.EventHandler(this.grafik_sdachiBindingSource_CurrentItemChanged);
            // 
            // grafik_sdachiTableAdapter
            // 
            this.grafik_sdachiTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.grafik_sdachiTableAdapter = this.grafik_sdachiTableAdapter;
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
            this.tableAdapterManager.protokolTableAdapter = null;
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
            // grafik_sdachiGridControl
            // 
            this.grafik_sdachiGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grafik_sdachiGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.grafik_sdachiGridControl.DataSource = this.grafik_sdachiBindingSource;
            this.grafik_sdachiGridControl.Location = new System.Drawing.Point(3, 91);
            this.grafik_sdachiGridControl.MainView = this.bandedGridView1;
            this.grafik_sdachiGridControl.Name = "grafik_sdachiGridControl";
            this.grafik_sdachiGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit2});
            this.grafik_sdachiGridControl.Size = new System.Drawing.Size(843, 391);
            this.grafik_sdachiGridControl.TabIndex = 1;
            this.grafik_sdachiGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colfio,
            this.coldolj,
            this.colgr_po_tb,
            this.colptb,
            this.colpte,
            this.colppb,
            this.colid_res});
            this.bandedGridView1.GridControl = this.grafik_sdachiGridControl;
            this.bandedGridView1.GroupCount = 1;
            this.bandedGridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "fio", this.colfio, "")});
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.bandedGridView1.OptionsView.ShowAutoFilterRow = true;
            this.bandedGridView1.OptionsView.ShowFooter = true;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            this.bandedGridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colid_res, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.bandedGridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.bandedGridView1_RowUpdated);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Данные сотрудника";
            this.gridBand1.Columns.Add(this.colid_res);
            this.gridBand1.Columns.Add(this.colfio);
            this.gridBand1.Columns.Add(this.coldolj);
            this.gridBand1.Columns.Add(this.colgr_po_tb);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 530;
            // 
            // colid_res
            // 
            this.colid_res.Caption = "Подразделение";
            this.colid_res.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colid_res.FieldName = "id_res";
            this.colid_res.Name = "colid_res";
            this.colid_res.OptionsFilter.AllowFilter = false;
            this.colid_res.Visible = true;
            this.colid_res.Width = 93;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("predpr_name", "Подразделение")});
            this.repositoryItemLookUpEdit2.DataSource = this.predprBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "predpr_name";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.ValueMember = "predpr_id";
            // 
            // colfio
            // 
            this.colfio.Caption = "ФИО";
            this.colfio.FieldName = "fio";
            this.colfio.Name = "colfio";
            this.colfio.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colfio.Visible = true;
            this.colfio.Width = 144;
            // 
            // coldolj
            // 
            this.coldolj.Caption = "Должность";
            this.coldolj.FieldName = "dolj";
            this.coldolj.Name = "coldolj";
            this.coldolj.Visible = true;
            this.coldolj.Width = 144;
            // 
            // colgr_po_tb
            // 
            this.colgr_po_tb.Caption = "Группа по ТБ";
            this.colgr_po_tb.FieldName = "gr_po_tb";
            this.colgr_po_tb.Name = "colgr_po_tb";
            this.colgr_po_tb.Visible = true;
            this.colgr_po_tb.Width = 149;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Сроки сдачи экзаменов";
            this.gridBand2.Columns.Add(this.colptb);
            this.gridBand2.Columns.Add(this.colpte);
            this.gridBand2.Columns.Add(this.colppb);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 294;
            // 
            // colptb
            // 
            this.colptb.Caption = "ПТБ";
            this.colptb.FieldName = "ptb";
            this.colptb.Name = "colptb";
            this.colptb.Visible = true;
            this.colptb.Width = 105;
            // 
            // colpte
            // 
            this.colpte.Caption = "ПТЭ";
            this.colpte.FieldName = "pte";
            this.colpte.Name = "colpte";
            this.colpte.Visible = true;
            this.colpte.Width = 113;
            // 
            // colppb
            // 
            this.colppb.Caption = "ППБ";
            this.colppb.FieldName = "ppb";
            this.colppb.Name = "colppb";
            this.colppb.Visible = true;
            this.colppb.Width = 76;
            // 
            // predprTableAdapter
            // 
            this.predprTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton17
            // 
            this.simpleButton17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton17.Location = new System.Drawing.Point(769, 34);
            this.simpleButton17.Name = "simpleButton17";
            this.simpleButton17.Size = new System.Drawing.Size(75, 23);
            this.simpleButton17.TabIndex = 46;
            this.simpleButton17.Text = "Сброс";
            this.simpleButton17.Click += new System.EventHandler(this.simpleButton17_Click);
            // 
            // simpleButton18
            // 
            this.simpleButton18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton18.Location = new System.Drawing.Point(769, 5);
            this.simpleButton18.Name = "simpleButton18";
            this.simpleButton18.Size = new System.Drawing.Size(75, 23);
            this.simpleButton18.TabIndex = 45;
            this.simpleButton18.Text = "Поиск";
            this.simpleButton18.Click += new System.EventHandler(this.simpleButton18_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(593, 38);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(16, 13);
            this.labelControl5.TabIndex = 44;
            this.labelControl5.Text = "по:";
            // 
            // dateEdit5
            // 
            this.dateEdit5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEdit5.EditValue = null;
            this.dateEdit5.Location = new System.Drawing.Point(615, 35);
            this.dateEdit5.Name = "dateEdit5";
            this.dateEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit5.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit5.Properties.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.dateEdit5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEdit5.Properties.EditFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.dateEdit5.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEdit5.Properties.Mask.EditMask = "dd.MM.yyyy HH:mm:ss";
            this.dateEdit5.Size = new System.Drawing.Size(147, 20);
            this.dateEdit5.TabIndex = 43;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Location = new System.Drawing.Point(600, 11);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(9, 13);
            this.labelControl6.TabIndex = 42;
            this.labelControl6.Text = "c:";
            // 
            // dateEdit6
            // 
            this.dateEdit6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEdit6.EditValue = null;
            this.dateEdit6.Location = new System.Drawing.Point(615, 8);
            this.dateEdit6.Name = "dateEdit6";
            this.dateEdit6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit6.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit6.Properties.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.dateEdit6.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEdit6.Properties.EditFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.dateEdit6.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEdit6.Properties.Mask.EditMask = "dd.MM.yyyy HH:mm:ss";
            this.dateEdit6.Size = new System.Drawing.Size(147, 20);
            this.dateEdit6.TabIndex = 41;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(771, 63);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 47;
            this.simpleButton1.Text = "Все";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(615, 59);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(31, 26);
            this.pictureEdit1.TabIndex = 48;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Location = new System.Drawing.Point(690, 63);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 49;
            this.simpleButton2.Text = "Просрочка";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton3.Location = new System.Drawing.Point(3, 488);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 50;
            this.simpleButton3.Text = "Добавить";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton4.Location = new System.Drawing.Point(84, 488);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 51;
            this.simpleButton4.Text = "Удалить";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // grafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 519);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton17);
            this.Controls.Add(this.simpleButton18);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.dateEdit5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.dateEdit6);
            this.Controls.Add(this.grafik_sdachiGridControl);
            this.Name = "grafik";
            this.Text = "График сдачи экзаменов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.grafik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predprBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik_sdachiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik_sdachiGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit5.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit6.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sntbDataSet sntbDataSet;
        private System.Windows.Forms.BindingSource grafik_sdachiBindingSource;
        private sntbDataSetTableAdapters.grafik_sdachiTableAdapter grafik_sdachiTableAdapter;
        private sntbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl grafik_sdachiGridControl;
        private System.Windows.Forms.BindingSource predprBindingSource;
        private sntbDataSetTableAdapters.predprTableAdapter predprTableAdapter;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colfio;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldolj;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colgr_po_tb;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colptb;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colpte;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colppb;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colid_res;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraEditors.SimpleButton simpleButton17;
        private DevExpress.XtraEditors.SimpleButton simpleButton18;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dateEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dateEdit6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}