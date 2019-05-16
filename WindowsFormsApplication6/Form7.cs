using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form7 : DevExpress.XtraEditors.XtraForm
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void lecturesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lecturesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sntbDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
         
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.type_doc". При необходимости она может быть перемещена или удалена.
            this.type_docTableAdapter.Fill(this.sntbDataSet.type_doc);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.lectures". При необходимости она может быть перемещена или удалена.
            this.lecturesTableAdapter.Fill(this.sntbDataSet.lectures);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form s = new Form8();
            s.Show();
        }

        private void Form7_Activated(object sender, EventArgs e)
        {
            this.type_docTableAdapter.Fill(this.sntbDataSet.type_doc);
        }

        private void lecturesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.lecturesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sntbDataSet);

        }
    }
}
