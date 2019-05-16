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
    public partial class red_testov : DevExpress.XtraEditors.XtraForm
    {
        public red_testov()
        {
            InitializeComponent();

        }





        public void red_testov_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.prog". При необходимости она может быть перемещена или удалена.
            this.progTableAdapter.Fill(this.sntbDataSet.prog);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.prog_test_count". При необходимости она может быть перемещена или удалена.
           
            //SGlobal.str12 = (int)((DataRowView)prog_test_countBindingSource.Current).Row["prog_id"];

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form k = new Form12();
            k.Show();
            //this.prog_test_countTableAdapter.Fill(this.sntbDataSet.prog_test_count);
        }

        private void selectTestfromProgDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (selectTestfromProgBindingSource.Count > 0)
            {
                SGlobal.str14 = (int)((DataRowView)selectTestfromProgBindingSource.Current).Row["test_id"];
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            queriesTableAdapter1.fordeletetest(SGlobal.str14);

            if (progBindingSource.Count > 0)
            {
                //SGlobal.str12 = (int)((DataRowView)prog_test_countBindingSource.Current).Row["prog_id"];
                SGlobal.str12 = (int)((DataRowView)progBindingSource.Current).Row["prog_id"];
                //prog_test_countDataGridView.Row["prog_id"];
                //SGlobal.str12 = (int)((DataViewManagerListItemTypeDescriptor)BindingSource red_testov.prog_test_countBindingSource.Current).Row["prog_id"];
                this.selectTestfromProgTableAdapter.Fill(this.sntbDataSet.SelectTestfromProg, SGlobal.str12);
                selectTestfromProgDataGridView.Refresh();

            }

            this.progTableAdapter.Fill(this.sntbDataSet.prog);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (progBindingSource.Count > 0)
            {
                //SGlobal.str12 = (int)((DataRowView)prog_test_countBindingSource.Current).Row["prog_id"];
                SGlobal.str12 = (int)((DataRowView)progBindingSource.Current).Row["prog_id"];
                //prog_test_countDataGridView.Row["prog_id"];
                //SGlobal.str12 = (int)((DataViewManagerListItemTypeDescriptor)BindingSource red_testov.prog_test_countBindingSource.Current).Row["prog_id"];
                this.selectTestfromProgTableAdapter.Fill(this.sntbDataSet.SelectTestfromProg, SGlobal.str12);
                selectTestfromProgDataGridView.Refresh();

            }

            this.progTableAdapter.Fill(this.sntbDataSet.prog);
        }

        private void progDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (progBindingSource.Count > 0)
                {
                    //SGlobal.str12 = (int)((DataRowView)prog_test_countBindingSource.Current).Row["prog_id"];
               SGlobal.str12 = (int)((DataRowView)progBindingSource.Current).Row["prog_id"];
                    //prog_test_countDataGridView.Row["prog_id"];
                    //SGlobal.str12 = (int)((DataViewManagerListItemTypeDescriptor)BindingSource red_testov.prog_test_countBindingSource.Current).Row["prog_id"];
                    this.selectTestfromProgTableAdapter.Fill(this.sntbDataSet.SelectTestfromProg, SGlobal.str12);
                    selectTestfromProgDataGridView.Refresh();

                }
            }
            catch (Exception)
            {
            }
            
        }

        




        //private void button1_Click(object sender, EventArgs e)
        //{
        //   
        //}




    }
}