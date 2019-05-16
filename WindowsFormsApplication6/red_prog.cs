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
    public partial class red_prog : DevExpress.XtraEditors.XtraForm
    {
        public red_prog()
        {
            InitializeComponent();
        }

        private void progBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.progBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sntbDataSet);

        }

        private void red_prog_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.newtable1". При необходимости она может быть перемещена или удалена.
            this.newtable1TableAdapter.Fill(this.sntbDataSet.newtable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.newtable". При необходимости она может быть перемещена или удалена.
            this.newtableTableAdapter.Fill(this.sntbDataSet.newtable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.prog". При необходимости она может быть перемещена или удалена.
            this.progTableAdapter.Fill(this.sntbDataSet.prog);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void red_prog_Activated(object sender, EventArgs e)
        {
            this.progTableAdapter.Fill(this.sntbDataSet.prog);
        }

        private void progDataGridView_Click(object sender, EventArgs e)
        {
            SGlobal.str6 = (int)((DataRowView)progBindingSource.Current).Row["prog_id"];
            
        }

        private void progDataGridView_DoubleClick(object sender, EventArgs e)
        {
            queriesTableAdapter1.ListTemProg(SGlobal.str6);
            this.newtable1TableAdapter.Fill(this.sntbDataSet.newtable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.newtable". При необходимости она может быть перемещена или удалена.
            this.newtableTableAdapter.Fill(this.sntbDataSet.newtable);

        }

        private void progDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            queriesTableAdapter1.ListTemProg(SGlobal.str6);
            this.newtable1TableAdapter.Fill(this.sntbDataSet.newtable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.newtable". При необходимости она может быть перемещена или удалена.
            this.newtableTableAdapter.Fill(this.sntbDataSet.newtable);
        }

       

        

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
this.progTableAdapter.Fill(this.sntbDataSet.prog);
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Form s = new prog();
            s.Show();

        }
    }
}
