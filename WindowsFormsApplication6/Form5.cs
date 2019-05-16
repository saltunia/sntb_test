using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace WindowsFormsApplication6
{
    public partial class Form5 : DevExpress.XtraEditors.XtraForm
    {
        int lastRowSelected1;
        int lastRowSelected;
        public Form5()
        {
            InitializeComponent();
        }

        private void progBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.progBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sntbDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
          
            this.prog_userTableAdapter.Fill(this.sntbDataSet.Prog_user);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.sntbDataSet.users, DateTime.Today);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.user_prog". При необходимости она может быть перемещена или удалена.
            this.user_progTableAdapter.Fill(this.sntbDataSet.user_prog);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.prog". При необходимости она может быть перемещена или удалена.
            this.progTableAdapter.Fill(this.sntbDataSet.prog);

        }

   
        private void progBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                SGlobal.str1 = (int)((DataRowView)progBindingSource.Current).Row["prog_id"];
            }
            catch { }
        }

        private void prog_userBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                SGlobal.str2 = (int)((DataRowView)prog_userBindingSource.Current).Row["user_id"];
            }
            catch { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                queriesTableAdapter1.Nazna4proga(SGlobal.str, SGlobal.str1);
                this.prog_userTableAdapter.Fill(this.sntbDataSet.Prog_user);
            }
            catch (System.Exception)
            {
                MessageBox.Show("Этому сотруднику уже была назначена программа ");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            {
                System.Windows.Forms.DialogResult result = MessageBox.Show("Отменить назначение программы пользователю?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    queriesTableAdapter1.fordelete(SGlobal.str2);
                    this.prog_userTableAdapter.Fill(this.sntbDataSet.Prog_user);
                }


            }
        }

        

      
       
    }
}
