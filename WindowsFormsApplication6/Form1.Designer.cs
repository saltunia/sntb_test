namespace WindowsFormsApplication6
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sntbDataSet = new WindowsFormsApplication6.sntbDataSet();
            this.usersTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.usersTableAdapter();
            this.doljnostTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.doljnostTableAdapter();
            this.predprTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.predprTableAdapter();
            this.predprBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doljnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableAdapterManager = new WindowsFormsApplication6.sntbDataSetTableAdapters.TableAdapterManager();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coluser_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_reg_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpredpr_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldoljn_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton17 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton18 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit5 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit6 = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predprBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doljnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit5.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit6.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit6.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sntbDataSet
            // 
            this.sntbDataSet.DataSetName = "sntbDataSet";
            this.sntbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // doljnostTableAdapter
            // 
            this.doljnostTableAdapter.ClearBeforeFill = true;
            // 
            // predprTableAdapter
            // 
            this.predprTableAdapter.ClearBeforeFill = true;
            // 
            // predprBindingSource
            // 
            this.predprBindingSource.DataMember = "predpr";
            this.predprBindingSource.DataSource = this.sntbDataSet;
            // 
            // doljnostBindingSource
            // 
            this.doljnostBindingSource.DataMember = "doljnost";
            this.doljnostBindingSource.DataSource = this.sntbDataSet;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.sntbDataSet;
            this.usersBindingSource.CurrentChanged += new System.EventHandler(this.usersBindingSource_CurrentChanged);
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
            this.tableAdapterManager.Connection = null;
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
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("predpr_name", "Название")});
            this.repositoryItemLookUpEdit1.DataSource = this.predprBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "predpr_name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "predpr_id";
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("doljn_name", "Название")});
            this.repositoryItemLookUpEdit2.DataSource = this.doljnostBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "doljn_name";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.ValueMember = "doljn_id";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coluser_id,
            this.coluser_reg_date,
            this.colname,
            this.colpredpr_id,
            this.coldoljn_id,
            this.colpass,
            this.colemail,
            this.colinfo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // coluser_id
            // 
            this.coluser_id.FieldName = "user_id";
            this.coluser_id.Name = "coluser_id";
            this.coluser_id.OptionsColumn.ReadOnly = true;
            // 
            // coluser_reg_date
            // 
            this.coluser_reg_date.Caption = "Дата регистрации";
            this.coluser_reg_date.FieldName = "user_reg_date";
            this.coluser_reg_date.Name = "coluser_reg_date";
            this.coluser_reg_date.Visible = true;
            this.coluser_reg_date.VisibleIndex = 4;
            this.coluser_reg_date.Width = 143;
            // 
            // colname
            // 
            this.colname.Caption = "Ф.И.О.";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 189;
            // 
            // colpredpr_id
            // 
            this.colpredpr_id.Caption = "Подразделение";
            this.colpredpr_id.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colpredpr_id.FieldName = "predpr_id";
            this.colpredpr_id.Name = "colpredpr_id";
            this.colpredpr_id.Visible = true;
            this.colpredpr_id.VisibleIndex = 1;
            this.colpredpr_id.Width = 139;
            // 
            // coldoljn_id
            // 
            this.coldoljn_id.Caption = "Должность";
            this.coldoljn_id.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.coldoljn_id.FieldName = "doljn_id";
            this.coldoljn_id.Name = "coldoljn_id";
            this.coldoljn_id.Visible = true;
            this.coldoljn_id.VisibleIndex = 2;
            this.coldoljn_id.Width = 139;
            // 
            // colpass
            // 
            this.colpass.Caption = "Пароль";
            this.colpass.FieldName = "pass";
            this.colpass.Name = "colpass";
            this.colpass.Visible = true;
            this.colpass.VisibleIndex = 3;
            this.colpass.Width = 139;
            // 
            // colemail
            // 
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            // 
            // colinfo
            // 
            this.colinfo.FieldName = "info";
            this.colinfo.Name = "colinfo";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.usersBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(-2, 67);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2});
            this.gridControl1.Size = new System.Drawing.Size(767, 358);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Location = new System.Drawing.Point(12, 431);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(115, 28);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Регистрация ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton2.Location = new System.Drawing.Point(133, 431);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(122, 28);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "Назначить программу";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton3.Location = new System.Drawing.Point(261, 431);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(106, 28);
            this.simpleButton3.TabIndex = 9;
            this.simpleButton3.Text = "Удалить";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton17
            // 
            this.simpleButton17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton17.Location = new System.Drawing.Point(686, 38);
            this.simpleButton17.Name = "simpleButton17";
            this.simpleButton17.Size = new System.Drawing.Size(75, 23);
            this.simpleButton17.TabIndex = 40;
            this.simpleButton17.Text = "Сброс";
            this.simpleButton17.Click += new System.EventHandler(this.simpleButton17_Click);
            // 
            // simpleButton18
            // 
            this.simpleButton18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton18.Location = new System.Drawing.Point(686, 9);
            this.simpleButton18.Name = "simpleButton18";
            this.simpleButton18.Size = new System.Drawing.Size(75, 23);
            this.simpleButton18.TabIndex = 39;
            this.simpleButton18.Text = "Поиск";
            this.simpleButton18.Click += new System.EventHandler(this.simpleButton18_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(510, 42);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(16, 13);
            this.labelControl5.TabIndex = 38;
            this.labelControl5.Text = "по:";
            // 
            // dateEdit5
            // 
            this.dateEdit5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEdit5.EditValue = null;
            this.dateEdit5.Location = new System.Drawing.Point(532, 39);
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
            this.dateEdit5.TabIndex = 37;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Location = new System.Drawing.Point(517, 15);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(9, 13);
            this.labelControl6.TabIndex = 36;
            this.labelControl6.Text = "c:";
            // 
            // dateEdit6
            // 
            this.dateEdit6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEdit6.EditValue = null;
            this.dateEdit6.Location = new System.Drawing.Point(532, 12);
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
            this.dateEdit6.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(766, 468);
            this.Controls.Add(this.simpleButton17);
            this.Controls.Add(this.simpleButton18);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.dateEdit5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.dateEdit6);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Stardust";
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predprBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doljnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit5.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit6.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit6.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sntbDataSet sntbDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private sntbDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private sntbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private sntbDataSetTableAdapters.predprTableAdapter predprTableAdapter;
        private System.Windows.Forms.BindingSource predprBindingSource;
        private sntbDataSetTableAdapters.doljnostTableAdapter doljnostTableAdapter;
        private System.Windows.Forms.BindingSource doljnostBindingSource;
        private System.Windows.Forms.ToolTip toolTip1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_id;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_reg_date;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colpredpr_id;
        private DevExpress.XtraGrid.Columns.GridColumn coldoljn_id;
        private DevExpress.XtraGrid.Columns.GridColumn colpass;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colinfo;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton17;
        private DevExpress.XtraEditors.SimpleButton simpleButton18;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dateEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dateEdit6;
    }
}

