namespace WindowsFormsApplication6
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.sntbDataSet = new WindowsFormsApplication6.sntbDataSet();
            this.progBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.progTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication6.sntbDataSetTableAdapters.TableAdapterManager();
            this.queriesTableAdapter1 = new WindowsFormsApplication6.sntbDataSetTableAdapters.QueriesTableAdapter();
            this.user_progBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_progTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.user_progTableAdapter();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.usersTableAdapter();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sntbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prog_userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prog_userTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.Prog_userTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colprog_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprog_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreate_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmodify_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colno_doc_test = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltests_count = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprog_name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprog_id1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_progBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog_userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // sntbDataSet
            // 
            this.sntbDataSet.DataSetName = "sntbDataSet";
            this.sntbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // progBindingSource
            // 
            this.progBindingSource.DataMember = "prog";
            this.progBindingSource.DataSource = this.sntbDataSet;
            this.progBindingSource.CurrentChanged += new System.EventHandler(this.progBindingSource_CurrentChanged);
            // 
            // progTableAdapter
            // 
            this.progTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.progTableAdapter = this.progTableAdapter;
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
            // user_progBindingSource
            // 
            this.user_progBindingSource.DataMember = "user_prog";
            this.user_progBindingSource.DataSource = this.sntbDataSet;
            // 
            // user_progTableAdapter
            // 
            this.user_progTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.sntbDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.sntbDataSet;
            // 
            // sntbDataSetBindingSource
            // 
            this.sntbDataSetBindingSource.DataSource = this.sntbDataSet;
            this.sntbDataSetBindingSource.Position = 0;
            // 
            // prog_userBindingSource
            // 
            this.prog_userBindingSource.DataMember = "Prog_user";
            this.prog_userBindingSource.DataSource = this.sntbDataSet;
            this.prog_userBindingSource.CurrentChanged += new System.EventHandler(this.prog_userBindingSource_CurrentChanged);
            // 
            // prog_userTableAdapter
            // 
            this.prog_userTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.progBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(1, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(487, 200);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colprog_id,
            this.colprog_name,
            this.colcreate_date,
            this.colmodify_date,
            this.colno_doc_test});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colprog_id
            // 
            this.colprog_id.FieldName = "prog_id";
            this.colprog_id.Name = "colprog_id";
            this.colprog_id.OptionsColumn.ReadOnly = true;
            // 
            // colprog_name
            // 
            this.colprog_name.Caption = "Название";
            this.colprog_name.FieldName = "prog_name";
            this.colprog_name.Name = "colprog_name";
            this.colprog_name.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colprog_name.Visible = true;
            this.colprog_name.VisibleIndex = 0;
            this.colprog_name.Width = 341;
            // 
            // colcreate_date
            // 
            this.colcreate_date.Caption = "Дата создания";
            this.colcreate_date.FieldName = "create_date";
            this.colcreate_date.Name = "colcreate_date";
            this.colcreate_date.Visible = true;
            this.colcreate_date.VisibleIndex = 1;
            this.colcreate_date.Width = 128;
            // 
            // colmodify_date
            // 
            this.colmodify_date.FieldName = "modify_date";
            this.colmodify_date.Name = "colmodify_date";
            // 
            // colno_doc_test
            // 
            this.colno_doc_test.FieldName = "no_doc_test";
            this.colno_doc_test.Name = "colno_doc_test";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(351, 214);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(129, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Назначить программу";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.DataSource = this.prog_userBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(1, 252);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(487, 293);
            this.gridControl2.TabIndex = 6;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltests_count,
            this.colname,
            this.colprog_name1,
            this.coluser_id,
            this.colprog_id1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // coltests_count
            // 
            this.coltests_count.FieldName = "tests_count";
            this.coltests_count.Name = "coltests_count";
            this.coltests_count.OptionsColumn.ReadOnly = true;
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
            this.colname.VisibleIndex = 0;
            // 
            // colprog_name1
            // 
            this.colprog_name1.Caption = "Название программы";
            this.colprog_name1.FieldName = "prog_name";
            this.colprog_name1.Name = "colprog_name1";
            this.colprog_name1.OptionsColumn.ReadOnly = true;
            this.colprog_name1.Visible = true;
            this.colprog_name1.VisibleIndex = 1;
            // 
            // coluser_id
            // 
            this.coluser_id.FieldName = "user_id";
            this.coluser_id.Name = "coluser_id";
            this.coluser_id.OptionsColumn.ReadOnly = true;
            // 
            // colprog_id1
            // 
            this.colprog_id1.FieldName = "prog_id";
            this.colprog_id1.Name = "colprog_id1";
            this.colprog_id1.OptionsColumn.ReadOnly = true;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(351, 554);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(129, 23);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Отменить назначение";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 586);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Stardust";
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите программу для назначения пользователю";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_progBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog_userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private sntbDataSet sntbDataSet;
        private System.Windows.Forms.BindingSource progBindingSource;
        private sntbDataSetTableAdapters.progTableAdapter progTableAdapter;
        private sntbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private sntbDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.BindingSource user_progBindingSource;
        private sntbDataSetTableAdapters.user_progTableAdapter user_progTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private sntbDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.BindingSource sntbDataSetBindingSource;
        private System.Windows.Forms.BindingSource prog_userBindingSource;
        private sntbDataSetTableAdapters.Prog_userTableAdapter prog_userTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colprog_id;
        private DevExpress.XtraGrid.Columns.GridColumn colprog_name;
        private DevExpress.XtraGrid.Columns.GridColumn colcreate_date;
        private DevExpress.XtraGrid.Columns.GridColumn colmodify_date;
        private DevExpress.XtraGrid.Columns.GridColumn colno_doc_test;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn coltests_count;
        private DevExpress.XtraGrid.Columns.GridColumn colprog_name1;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_id;
        private DevExpress.XtraGrid.Columns.GridColumn colprog_id1;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}