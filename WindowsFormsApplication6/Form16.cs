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
    public partial class Form16 : DevExpress.XtraEditors.XtraForm
    {
        public Form16()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            this.poiskTableAdapter.Fill(this.sntbDataSet.poisk, textBox1.Text);
        }

        private void poiskDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (poiskBindingSource.Count > 0)
            {
                SGlobal.id_vopr = (int)((DataRowView)poiskBindingSource.Current).Row["ID"];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.poisk1TableAdapter.Fill(this.sntbDataSet.poisk1, SGlobal.id_vopr);
        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }
    }
}
