namespace WindowsFormsApplication6
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.sntbDataSet = new WindowsFormsApplication6.sntbDataSet();
            this.tema_count_voprBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tema_count_voprTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.tema_count_voprTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication6.sntbDataSetTableAdapters.TableAdapterManager();
            this.tema_count_voprDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tema_count_voprBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tema_count_voprDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sntbDataSet
            // 
            this.sntbDataSet.DataSetName = "sntbDataSet";
            this.sntbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tema_count_voprBindingSource
            // 
            this.tema_count_voprBindingSource.DataMember = "tema_count_vopr";
            this.tema_count_voprBindingSource.DataSource = this.sntbDataSet;
            // 
            // tema_count_voprTableAdapter
            // 
            this.tema_count_voprTableAdapter.ClearBeforeFill = true;
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
            // tema_count_voprDataGridView
            // 
            this.tema_count_voprDataGridView.AllowUserToAddRows = false;
            this.tema_count_voprDataGridView.AllowUserToDeleteRows = false;
            this.tema_count_voprDataGridView.AutoGenerateColumns = false;
            this.tema_count_voprDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tema_count_voprDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tema_count_voprDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tema_count_voprDataGridView.DataSource = this.tema_count_voprBindingSource;
            this.tema_count_voprDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.tema_count_voprDataGridView.Location = new System.Drawing.Point(-2, -2);
            this.tema_count_voprDataGridView.Name = "tema_count_voprDataGridView";
            this.tema_count_voprDataGridView.ReadOnly = true;
            this.tema_count_voprDataGridView.Size = new System.Drawing.Size(631, 555);
            this.tema_count_voprDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tema_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tema_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название темы";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 103;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "count";
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество вопросов";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 276);
            this.Controls.Add(this.tema_count_voprDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр количества вопросов по темам";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tema_count_voprBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tema_count_voprDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private sntbDataSet sntbDataSet;
        private System.Windows.Forms.BindingSource tema_count_voprBindingSource;
        private sntbDataSetTableAdapters.tema_count_voprTableAdapter tema_count_voprTableAdapter;
        private sntbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tema_count_voprDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}