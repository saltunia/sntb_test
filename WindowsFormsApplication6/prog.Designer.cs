namespace WindowsFormsApplication6
{
    partial class prog
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
            System.Windows.Forms.Label prog_nameLabel;
            System.Windows.Forms.Label create_dateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prog));
            this.sntbDataSet = new WindowsFormsApplication6.sntbDataSet();
            this.progBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progTableAdapter = new WindowsFormsApplication6.sntbDataSetTableAdapters.progTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication6.sntbDataSetTableAdapters.TableAdapterManager();
            this.progBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.progBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.prog_nameTextBox = new System.Windows.Forms.TextBox();
            this.create_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            prog_nameLabel = new System.Windows.Forms.Label();
            create_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progBindingNavigator)).BeginInit();
            this.progBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // prog_nameLabel
            // 
            prog_nameLabel.AutoSize = true;
            prog_nameLabel.Location = new System.Drawing.Point(7, 28);
            prog_nameLabel.Name = "prog_nameLabel";
            prog_nameLabel.Size = new System.Drawing.Size(122, 13);
            prog_nameLabel.TabIndex = 3;
            prog_nameLabel.Text = "Название программы:";
            // 
            // create_dateLabel
            // 
            create_dateLabel.AutoSize = true;
            create_dateLabel.Location = new System.Drawing.Point(7, 66);
            create_dateLabel.Name = "create_dateLabel";
            create_dateLabel.Size = new System.Drawing.Size(87, 13);
            create_dateLabel.TabIndex = 5;
            create_dateLabel.Text = "Дата создания:";
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
            // progBindingNavigator
            // 
            this.progBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.progBindingNavigator.BindingSource = this.progBindingSource;
            this.progBindingNavigator.CountItem = null;
            this.progBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.progBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.progBindingNavigatorSaveItem});
            this.progBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.progBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.progBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.progBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.progBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.progBindingNavigator.Name = "progBindingNavigator";
            this.progBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.progBindingNavigator.Size = new System.Drawing.Size(289, 25);
            this.progBindingNavigator.TabIndex = 0;
            this.progBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // progBindingNavigatorSaveItem
            // 
            this.progBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.progBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("progBindingNavigatorSaveItem.Image")));
            this.progBindingNavigatorSaveItem.Name = "progBindingNavigatorSaveItem";
            this.progBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.progBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.progBindingNavigatorSaveItem.Click += new System.EventHandler(this.progBindingNavigatorSaveItem_Click);
            // 
            // prog_nameTextBox
            // 
            this.prog_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.progBindingSource, "prog_name", true));
            this.prog_nameTextBox.Location = new System.Drawing.Point(8, 41);
            this.prog_nameTextBox.Name = "prog_nameTextBox";
            this.prog_nameTextBox.Size = new System.Drawing.Size(273, 20);
            this.prog_nameTextBox.TabIndex = 4;
            // 
            // create_dateDateTimePicker
            // 
            this.create_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.progBindingSource, "create_date", true));
            this.create_dateDateTimePicker.Location = new System.Drawing.Point(8, 80);
            this.create_dateDateTimePicker.Name = "create_dateDateTimePicker";
            this.create_dateDateTimePicker.Size = new System.Drawing.Size(273, 20);
            this.create_dateDateTimePicker.TabIndex = 6;
            this.create_dateDateTimePicker.Value = new System.DateTime(2013, 6, 17, 0, 0, 0, 0);
            // 
            // prog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 116);
            this.Controls.Add(prog_nameLabel);
            this.Controls.Add(this.prog_nameTextBox);
            this.Controls.Add(create_dateLabel);
            this.Controls.Add(this.create_dateDateTimePicker);
            this.Controls.Add(this.progBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "prog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Введите название программы";
            this.Load += new System.EventHandler(this.prog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sntbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progBindingNavigator)).EndInit();
            this.progBindingNavigator.ResumeLayout(false);
            this.progBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sntbDataSet sntbDataSet;
        private System.Windows.Forms.BindingSource progBindingSource;
        private sntbDataSetTableAdapters.progTableAdapter progTableAdapter;
        private sntbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator progBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton progBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox prog_nameTextBox;
        private System.Windows.Forms.DateTimePicker create_dateDateTimePicker;
    }
}