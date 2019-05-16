namespace WindowsFormsApplication6
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            this.doc_glavaTableAdapter1 = new WindowsFormsApplication6.sntbDataSetTableAdapters.doc_glavaTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sntbDataSet = new WindowsFormsApplication6.sntbDataSet();
            this.poiskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poiskTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.poiskTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication6.sntbDataSetTableAdapters.TableAdapterManager();
            this.poiskDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.poisk1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poisk1TableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.poisk1TableAdapter();
            this.poisk1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poiskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poiskDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poisk1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poisk1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // doc_glavaTableAdapter1
            // 
            this.doc_glavaTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(23, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(682, 32);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Поиск вопроса";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sntbDataSet
            // 
            this.sntbDataSet.DataSetName = "sntbDataSet";
            this.sntbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poiskBindingSource
            // 
            this.poiskBindingSource.DataMember = "poisk";
            this.poiskBindingSource.DataSource = this.sntbDataSet;
            // 
            // poiskTableAdapter
            // 
            this.poiskTableAdapter.ClearBeforeFill = true;
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
            // poiskDataGridView
            // 
            this.poiskDataGridView.AllowUserToAddRows = false;
            this.poiskDataGridView.AllowUserToDeleteRows = false;
            this.poiskDataGridView.AutoGenerateColumns = false;
            this.poiskDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.poiskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poiskDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.poiskDataGridView.DataSource = this.poiskBindingSource;
            this.poiskDataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.poiskDataGridView.Location = new System.Drawing.Point(23, 105);
            this.poiskDataGridView.Name = "poiskDataGridView";
            this.poiskDataGridView.ReadOnly = true;
            this.poiskDataGridView.Size = new System.Drawing.Size(1016, 173);
            this.poiskDataGridView.TabIndex = 4;
            this.poiskDataGridView.SelectionChanged += new System.EventHandler(this.poiskDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "text";
            this.dataGridViewTextBoxColumn2.HeaderText = "Текст вопроса";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 96;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_tema";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id темы ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Поиск ответов";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // poisk1BindingSource
            // 
            this.poisk1BindingSource.DataMember = "poisk1";
            this.poisk1BindingSource.DataSource = this.sntbDataSet;
            // 
            // poisk1TableAdapter
            // 
            this.poisk1TableAdapter.ClearBeforeFill = true;
            // 
            // poisk1DataGridView
            // 
            this.poisk1DataGridView.AllowUserToAddRows = false;
            this.poisk1DataGridView.AllowUserToDeleteRows = false;
            this.poisk1DataGridView.AutoGenerateColumns = false;
            this.poisk1DataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.poisk1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poisk1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.poisk1DataGridView.DataSource = this.poisk1BindingSource;
            this.poisk1DataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.poisk1DataGridView.Location = new System.Drawing.Point(23, 313);
            this.poisk1DataGridView.Name = "poisk1DataGridView";
            this.poisk1DataGridView.ReadOnly = true;
            this.poisk1DataGridView.Size = new System.Drawing.Size(1016, 249);
            this.poisk1DataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "vopr_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "id вопроса";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "text";
            this.dataGridViewTextBoxColumn5.HeaderText = "Текст ответа";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "truth";
            this.dataGridViewTextBoxColumn6.HeaderText = "1-прав,0-непр";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 574);
            this.Controls.Add(this.poisk1DataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.poiskDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form16";
            this.Text = "Поиск";
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poiskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poiskDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poisk1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poisk1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sntbDataSetTableAdapters.doc_glavaTableAdapter doc_glavaTableAdapter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private sntbDataSet sntbDataSet;
        private System.Windows.Forms.BindingSource poiskBindingSource;
        private sntbDataSetTableAdapters.poiskTableAdapter poiskTableAdapter;
        private sntbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView poiskDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource poisk1BindingSource;
        private sntbDataSetTableAdapters.poisk1TableAdapter poisk1TableAdapter;
        private System.Windows.Forms.DataGridView poisk1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}