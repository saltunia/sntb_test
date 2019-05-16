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
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
      
        public Form1()
        {
            InitializeComponent();
          
        }

       

     

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.doljnost". При необходимости она может быть перемещена или удалена.
            this.doljnostTableAdapter.Fill(this.sntbDataSet.doljnost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.predpr". При необходимости она может быть перемещена или удалена.
            this.predprTableAdapter.Fill(this.sntbDataSet.predpr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.sntbDataSet.users,DateTime.Today);
            usersBindingSource.MoveLast();
        
        }


        
        private void button2_Click(object sender, EventArgs e)
        {
            Form s = new Form5();
            s.Show();

        }

       

       

       

       

       

       

      

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            usersBindingSource.AddNew();
            SGlobal.insert = "insert";
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {

            try
            {
                if (SGlobal.insert == "insert")
                {
                    var rowHandle = gridView1.FocusedRowHandle;
                    if (gridView1.GetRowCellValue(rowHandle, "name").ToString() == "" || gridView1.GetRowCellValue(rowHandle, "predpr_id").ToString() == "" || gridView1.GetRowCellValue(rowHandle, "doljn_id").ToString() == "" || gridView1.GetRowCellValue(rowHandle, "pass").ToString() == "" )
                    {
                        MessageBox.Show("Введите все данные!!!");

                    }
                    else
                    {
                        int predp = (int)gridView1.GetRowCellValue(rowHandle, "predpr_id");
                        int dolj = (int)gridView1.GetRowCellValue(rowHandle, "doljn_id");
                        string name = (string)gridView1.GetRowCellValue(rowHandle, "name");
                        string pass= (string)gridView1.GetRowCellValue(rowHandle, "pass");
                       
                        this.usersTableAdapter.InsertQuery(predp, dolj,name,pass,DateTime.Now.ToString());
                        usersBindingSource.MoveLast();
                    }
                }
                else
                {
                    var rowHandle = gridView1.FocusedRowHandle;
                    int predp = (int)gridView1.GetRowCellValue(rowHandle, "predpr_id");
                    int dolj = (int)gridView1.GetRowCellValue(rowHandle, "doljn_id");
                    string name = (string)gridView1.GetRowCellValue(rowHandle, "name");
                    string pass = (string)gridView1.GetRowCellValue(rowHandle, "pass");
                    DateTime date = (DateTime)gridView1.GetRowCellValue(rowHandle, "user_reg_date");
                    this.usersTableAdapter.UpdateQuery(predp, dolj, name, pass,date, SGlobal.str);
                }
                MessageBox.Show("Данные успешно сохранены");
                this.usersTableAdapter.Fill(this.sntbDataSet.users, DateTime.Today);
                usersBindingSource.MoveLast();
            }
            catch { MessageBox.Show("Данные не сохранены"); }
        }

        private void usersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                SGlobal.str = (int)((DataRowView)usersBindingSource.Current).Row["user_id"];
                SGlobal.user_name = (string)((DataRowView)usersBindingSource.Current).Row["name"];
            }
            catch { }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Form s = new Form5();
            s.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно \nхотите удалить? \n" + SGlobal.user_name, "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.Yes)
      {
          usersTableAdapter.DeleteQuery(SGlobal.str);
          this.usersTableAdapter.Fill(this.sntbDataSet.users, DateTime.Today);
      }
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            DateTime s = Convert.ToDateTime(dateEdit6.Text);
            DateTime d = Convert.ToDateTime(dateEdit5.Text);
            this.usersTableAdapter.FillByDate(this.sntbDataSet.users,s,d);
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.sntbDataSet.users, DateTime.Today);

        }

       

     

     

       

       
        
    }
}
