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
    public partial class redac_vopr : DevExpress.XtraEditors.XtraForm
    {
        public redac_vopr()
        {
            InitializeComponent();
        }

        private void redac_vopr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.glava_punkt". При необходимости она может быть перемещена или удалена.
           // this.glava_punktTableAdapter.Fill(this.sntbDataSet.glava_punkt);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.kol_documentov_vteme". При необходимости она может быть перемещена или удалена.
            this.kol_documentov_vtemeTableAdapter.Fill(this.sntbDataSet.kol_documentov_vteme);
            SGlobal.str7 = (int)((DataRowView)kol_documentov_vtemeBindingSource.Current).Row["tema_id"];
            this.kol_vopr_docTableAdapter.Fill(this.sntbDataSet.kol_vopr_doc, SGlobal.str7);
            SGlobal.str8 = (int)((DataRowView)kolvoprdocBindingSource.Current).Row["id"];
            this.vopr_docTableAdapter.Fill(this.sntbDataSet.vopr_doc, SGlobal.str8);
            SGlobal.str9 = (int)((DataRowView)vopr_docBindingSource.Current).Row["doc_id"];
            this.otvetyTableAdapter.Fill(this.sntbDataSet.otvety, SGlobal.str9);
        }

       

        private void kol_documentov_vtemeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (kol_documentov_vtemeBindingSource.Count > 0)
            {
                //kol_vopr_docDataGridView.DataSource = kolvoprdocBindingSource;
                SGlobal.str7 = (int)((DataRowView)kol_documentov_vtemeBindingSource.Current).Row["tema_id"];
                this.kol_vopr_docTableAdapter.Fill(this.sntbDataSet.kol_vopr_doc, SGlobal.str7);
                kol_vopr_docDataGridView.Refresh();
            }
            //else
            //{
            //    kol_vopr_docDataGridView.DataSource = null;
            //}
            //    kol_vopr_docDataGridView_SelectionChanged(sender, e);
            //try
            //{
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
        }

        private void kol_vopr_docDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (kolvoprdocBindingSource.Count > 0)
            {
                //vopr_docDataGridView.DataSource = vopr_docBindingSource;
                SGlobal.str8 = (int)((DataRowView)kolvoprdocBindingSource.Current).Row["id"];
                this.vopr_docTableAdapter.Fill(this.sntbDataSet.vopr_doc, SGlobal.str8);
                vopr_docDataGridView.Refresh();
            }
            //else {
            //    vopr_docDataGridView.DataSource= null;
            //}

            //    SGlobal.str8 = 1;
            //try
            //{   
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
        }

        private void vopr_docDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (vopr_docBindingSource.Count > 0)
            {
                dataGridView1.DataSource = otvetyBindingSource;
                SGlobal.str9 = (int)((DataRowView)vopr_docBindingSource.Current).Row["id"];
                this.otvetyTableAdapter.Fill(this.sntbDataSet.otvety, SGlobal.str9);
                dataGridView1.Refresh();
            }
            else
            {
                dataGridView1.DataSource = null;
                //(int)((DataRowView)vopr_docBindingSource.Current).Row["id"];
                //otvetyBindingSource.Clear();
               // vopr_docDataGridView.Focus();
               // vopr_docDataGridView.SelectAll();
               // vopr_docDataGridView.ClearSelection();
               // dataGridView1.Focus();
               //dataGridView1.Focus();
               // dataGridView1.SelectAll();
               // dataGridView1.ClearSelection();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form s = new Form10();
            s.Show();
        }

        private void redac_vopr_Activated(object sender, EventArgs e)
        {
            this.kol_documentov_vtemeTableAdapter.Fill(this.sntbDataSet.kol_documentov_vteme);
            SGlobal.str7 = (int)((DataRowView)kol_documentov_vtemeBindingSource.Current).Row["tema_id"];
            this.kol_vopr_docTableAdapter.Fill(this.sntbDataSet.kol_vopr_doc, SGlobal.str7);
            SGlobal.str8 = (int)((DataRowView)kolvoprdocBindingSource.Current).Row["id"];
            this.vopr_docTableAdapter.Fill(this.sntbDataSet.vopr_doc, SGlobal.str8);
            SGlobal.str9 = (int)((DataRowView)vopr_docBindingSource.Current).Row["doc_id"];
            this.otvetyTableAdapter.Fill(this.sntbDataSet.otvety, SGlobal.str9);
        }

        private void kol_vopr_docDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     

       
      

        
      

       
    }
}
