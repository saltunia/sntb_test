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
    public partial class Form9 : DevExpress.XtraEditors.XtraForm
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void temaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.temaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sntbDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.lectures". При необходимости она может быть перемещена или удалена.
            this.lecturesTableAdapter.Fill(this.sntbDataSet.lectures);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.doc_tema". При необходимости она может быть перемещена или удалена.
            this.doc_temaTableAdapter.Fill(this.sntbDataSet.doc_tema);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.tema". При необходимости она может быть перемещена или удалена.
            this.temaTableAdapter.Fill(this.sntbDataSet.tema);

        }

        private void temaDataGridView_Click(object sender, EventArgs e)
        {
            SGlobal.str4 = (int)((DataRowView)temaBindingSource.Current).Row["tema_id"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                queriesTableAdapter1.svyazkatemywithtable(SGlobal.str3, SGlobal.str4);
                this.doc_temaTableAdapter.Fill(this.sntbDataSet.doc_tema);
            }
            catch(System.Exception)
            {
                MessageBox.Show("Этот документ привязан ");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                System.Windows.Forms.DialogResult result = MessageBox.Show("Вы действительно хотите удалить связку?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    queriesTableAdapter1.fordeletelink(SGlobal.str5);
                    this.doc_temaTableAdapter.Fill(this.sntbDataSet.doc_tema);
                }


            }
        }

        private void doc_temaDataGridView_Click(object sender, EventArgs e)
        {
            SGlobal.str5 = (int)((DataRowView)doc_temaBindingSource.Current).Row["doc_id"];
        }

        
    }
}
