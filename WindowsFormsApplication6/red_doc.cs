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
    public partial class red_doc : DevExpress.XtraEditors.XtraForm
    {
        public red_doc()
        {
            InitializeComponent();
        }

        private void lecturesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lecturesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sntbDataSet);

        }

        private void red_doc_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.lectures". При необходимости она может быть перемещена или удалена.
            this.lecturesTableAdapter.Fill(this.sntbDataSet.lectures);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.type_doc". При необходимости она может быть перемещена или удалена.
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.lectures". При необходимости она может быть перемещена или удалена.
            this.lecturesTableAdapter.Fill(this.sntbDataSet.lectures);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form s = new Form7();
            s.Show();
        }

        private void red_doc_Activated(object sender, EventArgs e)
        {
          
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.lectures". При необходимости она может быть перемещена или удалена.
            this.lecturesTableAdapter.Fill(this.sntbDataSet.lectures);


        }

        private void lecturesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.lecturesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sntbDataSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.lecturesTableAdapter.Fill(this.sntbDataSet.lectures);
        }

        private void lecturesDataGridView_Click(object sender, EventArgs e)
        {
            SGlobal.str3 = (int)((DataRowView)lecturesBindingSource.Current).Row["id"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form s = new Form9();
            s.Show();
        }

        private void lecturesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
