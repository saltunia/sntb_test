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
    public partial class Form12 : DevExpress.XtraEditors.XtraForm
    {
       
        
        public Form12( )
        {
            InitializeComponent();
          
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.Test". При необходимости она может быть перемещена или удалена.
            //this.testTableAdapter.Fill(this.sntbDataSet.Test);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.tests". При необходимости она может быть перемещена или удалена.
            this.testsTableAdapter.Fill(this.sntbDataSet.tests);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.osenka". При необходимости она может быть перемещена или удалена.
            //this.osenkaTableAdapter.Fill(this.sntbDataSet.osenka);
            textBox1.Text = SGlobal.str12.ToString();
            nameTextBox.Text = "";
            test_timeTextBox.Text = "";
            
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Вы не ввели название теста");
                nameTextBox.Focus();
                return;
            }
            if (test_timeTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите время  в минутах");
                test_timeTextBox.Focus();
                return;

            }
           
            queriesTableAdapter1.novtest(nameTextBox.Text, Convert.ToInt16(test_timeTextBox.Text));
            //testsTableAdapter.Fill(this.sntbDataSet.tests);
            testsTableAdapter.Fill(this.sntbDataSet.tests);
            testsBindingSource.MoveLast();
            SGlobal.str13 = (int)((DataRowView)testsBindingSource.Current).Row["id"];
            textBox2.Text = SGlobal.str13.ToString();
            queriesTableAdapter1.progr_test(SGlobal.str12, SGlobal.str13);
            Form k = new Form11();
            k.Show();
          
        }

      

        

      

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       

     
        

        
    }
}
