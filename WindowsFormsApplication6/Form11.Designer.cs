namespace WindowsFormsApplication6
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.kol_documentov_vtemeDataGridView = new System.Windows.Forms.DataGridView();
            this.temaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temanameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koldocumentovvtemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sntbDataSet = new WindowsFormsApplication6.sntbDataSet();
            this.kol_vopr_docDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temaidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoprdocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prog_test_docBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kol_documentov_vtemeTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.kol_documentov_vtemeTableAdapter();
            this.kol_vopr_docTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.kol_vopr_docTableAdapter();
            this.prog_test_docTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.prog_test_docTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication6.sntbDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kol_documentov_vtemeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koldocumentovvtemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kol_vopr_docDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolvoprdocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog_test_docBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kol_documentov_vtemeDataGridView
            // 
            this.kol_documentov_vtemeDataGridView.AllowUserToAddRows = false;
            this.kol_documentov_vtemeDataGridView.AllowUserToDeleteRows = false;
            this.kol_documentov_vtemeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.kol_documentov_vtemeDataGridView.AutoGenerateColumns = false;
            this.kol_documentov_vtemeDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.kol_documentov_vtemeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kol_documentov_vtemeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.temaidDataGridViewTextBoxColumn,
            this.temanameDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn});
            this.kol_documentov_vtemeDataGridView.DataSource = this.koldocumentovvtemeBindingSource;
            this.kol_documentov_vtemeDataGridView.Location = new System.Drawing.Point(1, 0);
            this.kol_documentov_vtemeDataGridView.Name = "kol_documentov_vtemeDataGridView";
            this.kol_documentov_vtemeDataGridView.ReadOnly = true;
            this.kol_documentov_vtemeDataGridView.Size = new System.Drawing.Size(366, 172);
            this.kol_documentov_vtemeDataGridView.TabIndex = 2;
            this.kol_documentov_vtemeDataGridView.SelectionChanged += new System.EventHandler(this.kol_documentov_vtemeDataGridView_SelectionChanged);
            // 
            // temaidDataGridViewTextBoxColumn
            // 
            this.temaidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.temaidDataGridViewTextBoxColumn.DataPropertyName = "tema_id";
            this.temaidDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.temaidDataGridViewTextBoxColumn.Name = "temaidDataGridViewTextBoxColumn";
            this.temaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.temaidDataGridViewTextBoxColumn.Width = 66;
            // 
            // temanameDataGridViewTextBoxColumn
            // 
            this.temanameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.temanameDataGridViewTextBoxColumn.DataPropertyName = "tema_name";
            this.temanameDataGridViewTextBoxColumn.HeaderText = "Название темы";
            this.temanameDataGridViewTextBoxColumn.Name = "temanameDataGridViewTextBoxColumn";
            this.temanameDataGridViewTextBoxColumn.ReadOnly = true;
            this.temanameDataGridViewTextBoxColumn.Width = 103;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Количество документов в теме";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr1DataGridViewTextBoxColumn.Width = 151;
            // 
            // koldocumentovvtemeBindingSource
            // 
            this.koldocumentovvtemeBindingSource.DataMember = "kol_documentov_vteme";
            this.koldocumentovvtemeBindingSource.DataSource = this.sntbDataSet;
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
            this.kol_vopr_docDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.kol_vopr_docDataGridView.AutoGenerateColumns = false;
            this.kol_vopr_docDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.kol_vopr_docDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kol_vopr_docDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.temaidDataGridViewTextBoxColumn1});
            this.kol_vopr_docDataGridView.DataSource = this.kolvoprdocBindingSource;
            this.kol_vopr_docDataGridView.Location = new System.Drawing.Point(1, 180);
            this.kol_vopr_docDataGridView.Name = "kol_vopr_docDataGridView";
            this.kol_vopr_docDataGridView.ReadOnly = true;
            this.kol_vopr_docDataGridView.RowTemplate.Height = 30;
            this.kol_vopr_docDataGridView.Size = new System.Drawing.Size(771, 264);
            this.kol_vopr_docDataGridView.TabIndex = 3;
            this.kol_vopr_docDataGridView.SelectionChanged += new System.EventHandler(this.kol_vopr_docDataGridView_SelectionChanged);
            this.kol_vopr_docDataGridView.Click += new System.EventHandler(this.kol_vopr_docDataGridView_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 66;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название документа";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 127;
            // 
            // temaidDataGridViewTextBoxColumn1
            // 
            this.temaidDataGridViewTextBoxColumn1.DataPropertyName = "tema_id";
            this.temaidDataGridViewTextBoxColumn1.HeaderText = "tema_id";
            this.temaidDataGridViewTextBoxColumn1.Name = "temaidDataGridViewTextBoxColumn1";
            this.temaidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.temaidDataGridViewTextBoxColumn1.Visible = false;
            // 
            // kolvoprdocBindingSource
            // 
            this.kolvoprdocBindingSource.DataMember = "kol_vopr_doc";
            this.kolvoprdocBindingSource.DataSource = this.sntbDataSet;
            // 
            // prog_test_docBindingSource
            // 
            this.prog_test_docBindingSource.DataMember = "prog_test_doc";
            this.prog_test_docBindingSource.DataSource = this.sntbDataSet;
            // 
            // kol_documentov_vtemeTableAdapter
            // 
            this.kol_documentov_vtemeTableAdapter.ClearBeforeFill = true;
            // 
            // kol_vopr_docTableAdapter
            // 
            this.kol_vopr_docTableAdapter.ClearBeforeFill = true;
            // 
            // prog_test_docTableAdapter
            // 
            this.prog_test_docTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.prog_test_docTableAdapter = this.prog_test_docTableAdapter;
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(686, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kol_vopr_docDataGridView);
            this.Controls.Add(this.kol_documentov_vtemeDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form11";
            this.Text = "Задайте количество вопросов";
            this.Activated += new System.EventHandler(this.Form11_Activated);
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kol_documentov_vtemeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koldocumentovvtemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kol_vopr_docDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolvoprdocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prog_test_docBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView kol_documentov_vtemeDataGridView;
        private sntbDataSet sntbDataSet;
        private System.Windows.Forms.BindingSource koldocumentovvtemeBindingSource;
        private sntbDataSetTableAdapters.kol_documentov_vtemeTableAdapter kol_documentov_vtemeTableAdapter;
        private System.Windows.Forms.DataGridView kol_vopr_docDataGridView;
        private System.Windows.Forms.BindingSource kolvoprdocBindingSource;
        private sntbDataSetTableAdapters.kol_vopr_docTableAdapter kol_vopr_docTableAdapter;
        private System.Windows.Forms.BindingSource prog_test_docBindingSource;
        private sntbDataSetTableAdapters.prog_test_docTableAdapter prog_test_docTableAdapter;
        private sntbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn temaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temanameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temaidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button1;
    }
}