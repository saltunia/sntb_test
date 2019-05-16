namespace WindowsFormsApplication6
{
    partial class redac_vopr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(redac_vopr));
            this.kol_documentov_vtemeDataGridView = new System.Windows.Forms.DataGridView();
            this.temaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temanameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kol_documentov_vtemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sntbDataSet = new WindowsFormsApplication6.sntbDataSet();
            this.kol_vopr_docDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoprdocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vopr_docBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kol_documentov_vtemeTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.kol_documentov_vtemeTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication6.sntbDataSetTableAdapters.TableAdapterManager();
            this.kol_vopr_docTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.kol_vopr_docTableAdapter();
            this.vopr_docTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.vopr_docTableAdapter();
            this.sntbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vopr_docDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glavapunktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sequenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vopridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.truthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.otvetyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otvetyTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.otvetyTableAdapter();
            this.glava_punktTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.glava_punktTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kol_documentov_vtemeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kol_documentov_vtemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kol_vopr_docDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolvoprdocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vopr_docBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vopr_docDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glavapunktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otvetyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kol_documentov_vtemeDataGridView
            // 
            this.kol_documentov_vtemeDataGridView.AllowUserToAddRows = false;
            this.kol_documentov_vtemeDataGridView.AllowUserToDeleteRows = false;
            this.kol_documentov_vtemeDataGridView.AutoGenerateColumns = false;
            this.kol_documentov_vtemeDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.kol_documentov_vtemeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kol_documentov_vtemeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.temaidDataGridViewTextBoxColumn,
            this.temanameDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn1});
            this.kol_documentov_vtemeDataGridView.DataSource = this.kol_documentov_vtemeBindingSource;
            this.kol_documentov_vtemeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.kol_documentov_vtemeDataGridView.Name = "kol_documentov_vtemeDataGridView";
            this.kol_documentov_vtemeDataGridView.ReadOnly = true;
            this.kol_documentov_vtemeDataGridView.Size = new System.Drawing.Size(406, 182);
            this.kol_documentov_vtemeDataGridView.TabIndex = 1;
            this.kol_documentov_vtemeDataGridView.SelectionChanged += new System.EventHandler(this.kol_documentov_vtemeDataGridView_SelectionChanged);
            // 
            // temaidDataGridViewTextBoxColumn
            // 
            this.temaidDataGridViewTextBoxColumn.DataPropertyName = "tema_id";
            this.temaidDataGridViewTextBoxColumn.HeaderText = "Номер темы";
            this.temaidDataGridViewTextBoxColumn.Name = "temaidDataGridViewTextBoxColumn";
            this.temaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // temanameDataGridViewTextBoxColumn
            // 
            this.temanameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.temanameDataGridViewTextBoxColumn.DataPropertyName = "tema_name";
            this.temanameDataGridViewTextBoxColumn.HeaderText = "Название темы";
            this.temanameDataGridViewTextBoxColumn.Name = "temanameDataGridViewTextBoxColumn";
            this.temanameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expr1DataGridViewTextBoxColumn1
            // 
            this.expr1DataGridViewTextBoxColumn1.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn1.HeaderText = "Количество документов в теме";
            this.expr1DataGridViewTextBoxColumn1.Name = "expr1DataGridViewTextBoxColumn1";
            this.expr1DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kol_documentov_vtemeBindingSource
            // 
            this.kol_documentov_vtemeBindingSource.DataMember = "kol_documentov_vteme";
            this.kol_documentov_vtemeBindingSource.DataSource = this.sntbDataSet;
            // 
            // sntbDataSet
            // 
            this.sntbDataSet.DataSetName = "sntbDataSet";
            this.sntbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kol_vopr_docDataGridView
            // 
            this.kol_vopr_docDataGridView.AllowUserToAddRows = false;
            this.kol_vopr_docDataGridView.AllowUserToDeleteRows = false;
            this.kol_vopr_docDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kol_vopr_docDataGridView.AutoGenerateColumns = false;
            this.kol_vopr_docDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.kol_vopr_docDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kol_vopr_docDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.kol_vopr_docDataGridView.DataSource = this.kolvoprdocBindingSource;
            this.kol_vopr_docDataGridView.Location = new System.Drawing.Point(412, 0);
            this.kol_vopr_docDataGridView.Name = "kol_vopr_docDataGridView";
            this.kol_vopr_docDataGridView.ReadOnly = true;
            this.kol_vopr_docDataGridView.RowTemplate.Height = 30;
            this.kol_vopr_docDataGridView.Size = new System.Drawing.Size(554, 182);
            this.kol_vopr_docDataGridView.TabIndex = 2;
            this.kol_vopr_docDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kol_vopr_docDataGridView_CellContentClick);
            this.kol_vopr_docDataGridView.SelectionChanged += new System.EventHandler(this.kol_vopr_docDataGridView_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер документа";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название документа";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 126;
            // 
            // kolvoprdocBindingSource
            // 
            this.kolvoprdocBindingSource.DataMember = "kol_vopr_doc";
            this.kolvoprdocBindingSource.DataSource = this.sntbDataSet;
            // 
            // vopr_docBindingSource
            // 
            this.vopr_docBindingSource.DataMember = "vopr_doc";
            this.vopr_docBindingSource.DataSource = this.sntbDataSet;
            // 
            // kol_documentov_vtemeTableAdapter
            // 
            this.kol_documentov_vtemeTableAdapter.ClearBeforeFill = true;
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
            // kol_vopr_docTableAdapter
            // 
            this.kol_vopr_docTableAdapter.ClearBeforeFill = true;
            // 
            // vopr_docTableAdapter
            // 
            this.vopr_docTableAdapter.ClearBeforeFill = true;
            // 
            // sntbDataSetBindingSource
            // 
            this.sntbDataSetBindingSource.DataSource = this.sntbDataSet;
            this.sntbDataSetBindingSource.Position = 0;
            // 
            // vopr_docDataGridView
            // 
            this.vopr_docDataGridView.AllowUserToAddRows = false;
            this.vopr_docDataGridView.AllowUserToDeleteRows = false;
            this.vopr_docDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.vopr_docDataGridView.AutoGenerateColumns = false;
            this.vopr_docDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.vopr_docDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vopr_docDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.vopr_docDataGridView.DataSource = this.vopr_docBindingSource;
            this.vopr_docDataGridView.Location = new System.Drawing.Point(0, 188);
            this.vopr_docDataGridView.Name = "vopr_docDataGridView";
            this.vopr_docDataGridView.ReadOnly = true;
            this.vopr_docDataGridView.RowHeadersWidth = 31;
            this.vopr_docDataGridView.RowTemplate.Height = 40;
            this.vopr_docDataGridView.Size = new System.Drawing.Size(1161, 170);
            this.vopr_docDataGridView.TabIndex = 3;
            this.vopr_docDataGridView.SelectionChanged += new System.EventHandler(this.vopr_docDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Номер вопроса";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 98;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "text";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.HeaderText = "Текст вопроса";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "picture";
            this.dataGridViewTextBoxColumn6.HeaderText = "picture";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn7.HeaderText = "type";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "difficulty";
            this.dataGridViewTextBoxColumn8.HeaderText = "difficulty";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "punkt_id";
            this.dataGridViewTextBoxColumn9.HeaderText = "Название пункта";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "doc_id";
            this.dataGridViewTextBoxColumn10.HeaderText = "doc_id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // glavapunktBindingSource
            // 
            this.glavapunktBindingSource.DataMember = "glava_punkt";
            this.glavapunktBindingSource.DataSource = this.sntbDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sequenceDataGridViewTextBoxColumn,
            this.vopridDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.truthDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.otvetyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 364);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 80;
            this.dataGridView1.Size = new System.Drawing.Size(1161, 293);
            this.dataGridView1.TabIndex = 4;
            // 
            // sequenceDataGridViewTextBoxColumn
            // 
            this.sequenceDataGridViewTextBoxColumn.DataPropertyName = "sequence";
            this.sequenceDataGridViewTextBoxColumn.HeaderText = "Нумерация";
            this.sequenceDataGridViewTextBoxColumn.Name = "sequenceDataGridViewTextBoxColumn";
            this.sequenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vopridDataGridViewTextBoxColumn
            // 
            this.vopridDataGridViewTextBoxColumn.DataPropertyName = "vopr_id";
            this.vopridDataGridViewTextBoxColumn.HeaderText = "Вопр_ин";
            this.vopridDataGridViewTextBoxColumn.Name = "vopridDataGridViewTextBoxColumn";
            this.vopridDataGridViewTextBoxColumn.ReadOnly = true;
            this.vopridDataGridViewTextBoxColumn.Visible = false;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.textDataGridViewTextBoxColumn.DataPropertyName = "text";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.textDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.textDataGridViewTextBoxColumn.HeaderText = "Текст ответа";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // truthDataGridViewTextBoxColumn
            // 
            this.truthDataGridViewTextBoxColumn.DataPropertyName = "truth";
            this.truthDataGridViewTextBoxColumn.HeaderText = "Правильно";
            this.truthDataGridViewTextBoxColumn.Name = "truthDataGridViewTextBoxColumn";
            this.truthDataGridViewTextBoxColumn.ReadOnly = true;
            this.truthDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.truthDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // otvetyBindingSource
            // 
            this.otvetyBindingSource.DataMember = "otvety";
            this.otvetyBindingSource.DataSource = this.sntbDataSet;
            // 
            // otvetyTableAdapter
            // 
            this.otvetyTableAdapter.ClearBeforeFill = true;
            // 
            // glava_punktTableAdapter
            // 
            this.glava_punktTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(972, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить новый вопрос";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // redac_vopr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 669);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.vopr_docDataGridView);
            this.Controls.Add(this.kol_vopr_docDataGridView);
            this.Controls.Add(this.kol_documentov_vtemeDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "redac_vopr";
            this.Text = "Редактор вопросов";
            this.Activated += new System.EventHandler(this.redac_vopr_Activated);
            this.Load += new System.EventHandler(this.redac_vopr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kol_documentov_vtemeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kol_documentov_vtemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kol_vopr_docDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolvoprdocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vopr_docBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vopr_docDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glavapunktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otvetyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private sntbDataSet sntbDataSet;
        private System.Windows.Forms.BindingSource kol_documentov_vtemeBindingSource;
        private sntbDataSetTableAdapters.kol_documentov_vtemeTableAdapter kol_documentov_vtemeTableAdapter;
        private sntbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView kol_documentov_vtemeDataGridView;
        private System.Windows.Forms.DataGridView kol_vopr_docDataGridView;
        private System.Windows.Forms.BindingSource kolvoprdocBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
      //  private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private sntbDataSetTableAdapters.kol_vopr_docTableAdapter kol_vopr_docTableAdapter;
        private System.Windows.Forms.BindingSource vopr_docBindingSource;
        private sntbDataSetTableAdapters.vopr_docTableAdapter vopr_docTableAdapter;
        private System.Windows.Forms.BindingSource sntbDataSetBindingSource;
        private System.Windows.Forms.DataGridView vopr_docDataGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource otvetyBindingSource;
        private sntbDataSetTableAdapters.otvetyTableAdapter otvetyTableAdapter;
        private System.Windows.Forms.BindingSource glavapunktBindingSource;
        private sntbDataSetTableAdapters.glava_punktTableAdapter glava_punktTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn temaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temanameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vopridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn truthDataGridViewTextBoxColumn;
    }
}