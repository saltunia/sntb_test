namespace WindowsFormsApplication6
{
    partial class red_testov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(red_testov));
            this.sntbDataSet = new WindowsFormsApplication6.sntbDataSet();
            this.selectTestfromProgDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectTestfromProgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new WindowsFormsApplication6.sntbDataSetTableAdapters.TableAdapterManager();
            this.selectTestfromProgTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.SelectTestfromProgTableAdapter();
            this.queriesTableAdapter1 = new WindowsFormsApplication6.sntbDataSetTableAdapters.QueriesTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.progBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.progTableAdapter();
            this.progDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTestfromProgDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTestfromProgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sntbDataSet
            // 
            this.sntbDataSet.DataSetName = "sntbDataSet";
            this.sntbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectTestfromProgDataGridView
            // 
            this.selectTestfromProgDataGridView.AllowUserToAddRows = false;
            this.selectTestfromProgDataGridView.AllowUserToDeleteRows = false;
            this.selectTestfromProgDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectTestfromProgDataGridView.AutoGenerateColumns = false;
            this.selectTestfromProgDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.selectTestfromProgDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectTestfromProgDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.selectTestfromProgDataGridView.DataSource = this.selectTestfromProgBindingSource;
            this.selectTestfromProgDataGridView.Location = new System.Drawing.Point(-1, 240);
            this.selectTestfromProgDataGridView.Name = "selectTestfromProgDataGridView";
            this.selectTestfromProgDataGridView.ReadOnly = true;
            this.selectTestfromProgDataGridView.Size = new System.Drawing.Size(613, 161);
            this.selectTestfromProgDataGridView.TabIndex = 2;
            this.selectTestfromProgDataGridView.SelectionChanged += new System.EventHandler(this.selectTestfromProgDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "№";
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "test_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "test_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Название теста";
            this.dataGridViewTextBoxColumn3.HeaderText = "Название теста";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 104;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Время на тест (мин.)";
            this.dataGridViewTextBoxColumn4.HeaderText = "Время на тест (мин.)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 99;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Дата создания";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата создания";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "вопросов";
            this.dataGridViewTextBoxColumn6.HeaderText = "вопросов";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Редакция";
            this.dataGridViewTextBoxColumn7.HeaderText = "Редакция";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 81;
            // 
            // selectTestfromProgBindingSource
            // 
            this.selectTestfromProgBindingSource.DataMember = "SelectTestfromProg";
            this.selectTestfromProgBindingSource.DataSource = this.sntbDataSet;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(111, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Новый тест";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(229, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Удалить тест";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // selectTestfromProgTableAdapter
            // 
            this.selectTestfromProgTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(12, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // progBindingSource
            // 
            this.progBindingSource.DataMember = "prog";
            this.progBindingSource.DataSource = this.sntbDataSet;
            // 
            // progTableAdapter
            // 
            this.progTableAdapter.ClearBeforeFill = true;
            // 
            // progDataGridView
            // 
            this.progDataGridView.AllowUserToAddRows = false;
            this.progDataGridView.AllowUserToDeleteRows = false;
            this.progDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progDataGridView.AutoGenerateColumns = false;
            this.progDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.progDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.progDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.progDataGridView.DataSource = this.progBindingSource;
            this.progDataGridView.Location = new System.Drawing.Point(0, 0);
            this.progDataGridView.Name = "progDataGridView";
            this.progDataGridView.ReadOnly = true;
            this.progDataGridView.Size = new System.Drawing.Size(514, 225);
            this.progDataGridView.TabIndex = 5;
            this.progDataGridView.SelectionChanged += new System.EventHandler(this.progDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "prog_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "Номер программы";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "prog_name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Название программы";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 132;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "create_date";
            this.dataGridViewTextBoxColumn10.HeaderText = "Дата создания";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "modify_date";
            this.dataGridViewTextBoxColumn11.HeaderText = "modify_date";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "no_doc_test";
            this.dataGridViewTextBoxColumn12.HeaderText = "no_doc_test";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // red_testov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 497);
            this.Controls.Add(this.progDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectTestfromProgDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "red_testov";
            this.Text = "Редактор тестов";
            this.Load += new System.EventHandler(this.red_testov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTestfromProgDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTestfromProgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private sntbDataSet sntbDataSet;
        private sntbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource selectTestfromProgBindingSource;
        private sntbDataSetTableAdapters.SelectTestfromProgTableAdapter selectTestfromProgTableAdapter;
        private System.Windows.Forms.DataGridView selectTestfromProgDataGridView;
        private sntbDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource progBindingSource;
        private sntbDataSetTableAdapters.progTableAdapter progTableAdapter;
        private System.Windows.Forms.DataGridView progDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}