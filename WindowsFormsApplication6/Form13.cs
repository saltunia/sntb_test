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
    public partial class Form13 : DevExpress.XtraEditors.XtraForm
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                queriesTableAdapter1.progr_test_doc(SGlobal.str13, SGlobal.str8, Convert.ToInt16(textBox1.Text));
            }
            catch(Exception)
                {
                    MessageBox.Show("Не задали количество тестов");
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }
    }
}
