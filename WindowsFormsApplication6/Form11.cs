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
    public partial class Form11 : DevExpress.XtraEditors.XtraForm
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            string str = "test_id = ";
            str = str + SGlobal.str13;
            //str = str + textBox1.Text;
            this.prog_test_docBindingSource.Filter = str;// TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.prog_test_doc". При необходимости она может быть перемещена или удалена.
            //this.prog_test_docTableAdapter.Fill(this.sntbDataSet.prog_test_doc);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.kol_documentov_vteme". При необходимости она может быть перемещена или удалена.
            this.kol_documentov_vtemeTableAdapter.Fill(this.sntbDataSet.kol_documentov_vteme);
            SGlobal.str7 = (int)((DataRowView)koldocumentovvtemeBindingSource.Current).Row["tema_id"];
            this.kol_vopr_docTableAdapter.Fill(this.sntbDataSet.kol_vopr_doc, SGlobal.str7);

        }

        private void kol_documentov_vtemeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (koldocumentovvtemeBindingSource.Count > 0)
            {
                //kol_vopr_docDataGridView.DataSource = kolvoprdocBindingSource;
                SGlobal.str7 = (int)((DataRowView)koldocumentovvtemeBindingSource.Current).Row["tema_id"];
                this.kol_vopr_docTableAdapter.Fill(this.sntbDataSet.kol_vopr_doc, SGlobal.str7);
                kol_vopr_docDataGridView.Refresh();

            }
        }

        private void kol_vopr_docDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (kolvoprdocBindingSource.Count > 0)
            {
SGlobal.str8 = (int)((DataRowView)kolvoprdocBindingSource.Current).Row["id"];
            }
            
        }

        private void kol_vopr_docDataGridView_Click(object sender, EventArgs e)
        {
            Form g = new Form13();
            g.Show();
        }

        private void Form11_Activated(object sender, EventArgs e)
        {
            string str = "test_id = ";
            str = str + SGlobal.str13;
            //str = str + textBox1.Text;
            this.prog_test_docBindingSource.Filter = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}