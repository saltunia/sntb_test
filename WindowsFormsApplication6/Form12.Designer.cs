namespace WindowsFormsApplication6
{
    partial class Form12
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
            System.Windows.Forms.Label incorrectLabel;
            System.Windows.Forms.Label correctLabel;
            System.Windows.Forms.Label udovlLabel;
            System.Windows.Forms.Label horLabel;
            System.Windows.Forms.Label otlLabel;
            System.Windows.Forms.Label ocenca_typeLabel;
            System.Windows.Forms.Label test_timeLabel;
            System.Windows.Forms.Label nameLabel;
            this.sntbDataSet = new WindowsFormsApplication6.sntbDataSet();
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.osenkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.osenkaTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.osenkaTableAdapter();
            this.testsTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.testsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication6.sntbDataSetTableAdapters.TableAdapterManager();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.osenkaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.incorrectTextBox = new System.Windows.Forms.TextBox();
            this.correctTextBox = new System.Windows.Forms.TextBox();
            this.udovlTextBox = new System.Windows.Forms.TextBox();
            this.horTextBox = new System.Windows.Forms.TextBox();
            this.otlTextBox = new System.Windows.Forms.TextBox();
            this.test_timeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.queriesTableAdapter1 = new WindowsFormsApplication6.sntbDataSetTableAdapters.QueriesTableAdapter();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.TestTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            incorrectLabel = new System.Windows.Forms.Label();
            correctLabel = new System.Windows.Forms.Label();
            udovlLabel = new System.Windows.Forms.Label();
            horLabel = new System.Windows.Forms.Label();
            otlLabel = new System.Windows.Forms.Label();
            ocenca_typeLabel = new System.Windows.Forms.Label();
            test_timeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osenkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osenkaBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // incorrectLabel
            // 
            incorrectLabel.AutoSize = true;
            incorrectLabel.Location = new System.Drawing.Point(165, 61);
            incorrectLabel.Name = "incorrectLabel";
            incorrectLabel.Size = new System.Drawing.Size(63, 13);
            incorrectLabel.TabIndex = 21;
            incorrectLabel.Text = "за ошибку:";
            // 
            // correctLabel
            // 
            correctLabel.AutoSize = true;
            correctLabel.Location = new System.Drawing.Point(13, 61);
            correctLabel.Name = "correctLabel";
            correctLabel.Size = new System.Drawing.Size(87, 13);
            correctLabel.TabIndex = 19;
            correctLabel.Text = "за правильный:";
            // 
            // udovlLabel
            // 
            udovlLabel.AutoSize = true;
            udovlLabel.Location = new System.Drawing.Point(177, 24);
            udovlLabel.Name = "udovlLabel";
            udovlLabel.Size = new System.Drawing.Size(42, 13);
            udovlLabel.TabIndex = 17;
            udovlLabel.Text = "удовл:";
            // 
            // horLabel
            // 
            horLabel.AutoSize = true;
            horLabel.Location = new System.Drawing.Point(95, 24);
            horLabel.Name = "horLabel";
            horLabel.Size = new System.Drawing.Size(29, 13);
            horLabel.TabIndex = 15;
            horLabel.Text = "хор:";
            // 
            // otlLabel
            // 
            otlLabel.AutoSize = true;
            otlLabel.Location = new System.Drawing.Point(13, 24);
            otlLabel.Name = "otlLabel";
            otlLabel.Size = new System.Drawing.Size(29, 13);
            otlLabel.TabIndex = 13;
            otlLabel.Text = "отл:";
            // 
            // ocenca_typeLabel
            // 
            ocenca_typeLabel.AutoSize = true;
            ocenca_typeLabel.Enabled = false;
            ocenca_typeLabel.Location = new System.Drawing.Point(286, 50);
            ocenca_typeLabel.Name = "ocenca_typeLabel";
            ocenca_typeLabel.Size = new System.Drawing.Size(100, 13);
            ocenca_typeLabel.TabIndex = 11;
            ocenca_typeLabel.Text = "Тип оценки теста:";
            // 
            // test_timeLabel
            // 
            test_timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            test_timeLabel.AutoSize = true;
            test_timeLabel.Location = new System.Drawing.Point(12, 198);
            test_timeLabel.Name = "test_timeLabel";
            test_timeLabel.Size = new System.Drawing.Size(177, 13);
            test_timeLabel.TabIndex = 7;
            test_timeLabel.Text = "Время тестирования (в минутах):";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(87, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Название теста";
            // 
            // sntbDataSet
            // 
            this.sntbDataSet.DataSetName = "sntbDataSet";
            this.sntbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testsBindingSource
            // 
            this.testsBindingSource.DataMember = "tests";
            this.testsBindingSource.DataSource = this.sntbDataSet;
            // 
            // osenkaBindingSource
            // 
            this.osenkaBindingSource.DataMember = "osenka";
            this.osenkaBindingSource.DataSource = this.sntbDataSet;
            // 
            // osenkaTableAdapter
            // 
            this.osenkaTableAdapter.ClearBeforeFill = true;
            // 
            // testsTableAdapter
            // 
            this.testsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.osenkaTableAdapter = this.osenkaTableAdapter;
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
            this.tableAdapterManager.testsTableAdapter = this.testsTableAdapter;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(365, 279);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.testsBindingSource, "ocenca_type", true));
            this.comboBox1.DataSource = this.osenkaBindingSource1;
            this.comboBox1.DisplayMember = "nazvanie";
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(302, 279);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Tag = "3";
            this.comboBox1.ValueMember = "id";
            this.comboBox1.Visible = false;
            // 
            // osenkaBindingSource1
            // 
            this.osenkaBindingSource1.DataMember = "osenka";
            this.osenkaBindingSource1.DataSource = this.sntbDataSet;
            // 
            // incorrectTextBox
            // 
            this.incorrectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testsBindingSource, "incorrect", true));
            this.incorrectTextBox.Location = new System.Drawing.Point(231, 58);
            this.incorrectTextBox.Name = "incorrectTextBox";
            this.incorrectTextBox.Size = new System.Drawing.Size(35, 21);
            this.incorrectTextBox.TabIndex = 22;
            this.incorrectTextBox.Text = "0";
            // 
            // correctTextBox
            // 
            this.correctTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testsBindingSource, "correct", true));
            this.correctTextBox.Location = new System.Drawing.Point(103, 58);
            this.correctTextBox.Name = "correctTextBox";
            this.correctTextBox.Size = new System.Drawing.Size(35, 21);
            this.correctTextBox.TabIndex = 20;
            this.correctTextBox.Text = "1";
            // 
            // udovlTextBox
            // 
            this.udovlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testsBindingSource, "udovl", true));
            this.udovlTextBox.Location = new System.Drawing.Point(219, 21);
            this.udovlTextBox.Name = "udovlTextBox";
            this.udovlTextBox.Size = new System.Drawing.Size(33, 21);
            this.udovlTextBox.TabIndex = 18;
            // 
            // horTextBox
            // 
            this.horTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testsBindingSource, "hor", true));
            this.horTextBox.Location = new System.Drawing.Point(123, 21);
            this.horTextBox.Name = "horTextBox";
            this.horTextBox.Size = new System.Drawing.Size(33, 21);
            this.horTextBox.TabIndex = 16;
            // 
            // otlTextBox
            // 
            this.otlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testsBindingSource, "otl", true));
            this.otlTextBox.Location = new System.Drawing.Point(40, 21);
            this.otlTextBox.Name = "otlTextBox";
            this.otlTextBox.Size = new System.Drawing.Size(33, 21);
            this.otlTextBox.TabIndex = 14;
            // 
            // test_timeTextBox
            // 
            this.test_timeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.test_timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testsBindingSource, "test_time", true));
            this.test_timeTextBox.Location = new System.Drawing.Point(195, 198);
            this.test_timeTextBox.Name = "test_timeTextBox";
            this.test_timeTextBox.Size = new System.Drawing.Size(70, 21);
            this.test_timeTextBox.TabIndex = 8;
            this.test_timeTextBox.Tag = "2";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testsBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(12, 25);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(253, 116);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.Tag = "1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(365, 305);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 49);
            this.button1.TabIndex = 26;
            this.button1.Text = "Задать количество  вопросов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(289, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(260, 17);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Показывать количество правильных ответов";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(otlLabel);
            this.groupBox1.Controls.Add(this.otlTextBox);
            this.groupBox1.Controls.Add(horLabel);
            this.groupBox1.Controls.Add(this.horTextBox);
            this.groupBox1.Controls.Add(udovlLabel);
            this.groupBox1.Controls.Add(this.udovlTextBox);
            this.groupBox1.Controls.Add(correctLabel);
            this.groupBox1.Controls.Add(this.correctTextBox);
            this.groupBox1.Controls.Add(incorrectLabel);
            this.groupBox1.Controls.Add(this.incorrectTextBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(289, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 91);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры оценки";
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataMember = "Test";
            this.testBindingSource.DataSource = this.sntbDataSet;
            // 
            // testTableAdapter
            // 
            this.testTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 49);
            this.button2.TabIndex = 29;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(387, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 21);
            this.textBox3.TabIndex = 30;
            this.textBox3.Text = "По сумме баллов";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 354);
            this.ControlBox = false;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(test_timeLabel);
            this.Controls.Add(this.test_timeTextBox);
            this.Controls.Add(ocenca_typeLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание нового теста";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osenkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osenkaBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sntbDataSet sntbDataSet;
        private System.Windows.Forms.BindingSource osenkaBindingSource;
        private sntbDataSetTableAdapters.osenkaTableAdapter osenkaTableAdapter;
        private System.Windows.Forms.BindingSource testsBindingSource;
        private sntbDataSetTableAdapters.testsTableAdapter testsTableAdapter;
        private sntbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox incorrectTextBox;
        private System.Windows.Forms.TextBox correctTextBox;
        private System.Windows.Forms.TextBox udovlTextBox;
        private System.Windows.Forms.TextBox horTextBox;
        private System.Windows.Forms.TextBox otlTextBox;
        private System.Windows.Forms.TextBox test_timeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private sntbDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.BindingSource osenkaBindingSource1;
        private System.Windows.Forms.BindingSource testBindingSource;
        private sntbDataSetTableAdapters.TestTableAdapter testTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;

    }
}