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
    public partial class audentification : DevExpress.XtraEditors.XtraForm
    {
        public audentification()
        {
            InitializeComponent();
        }

        private void user_NeActivBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_NeActivBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sntbDataSet);

        }

        private void audentification_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.User_NeActiv". При необходимости она может быть перемещена или удалена.
          
            try
            {
                this.user_NeActivTableAdapter.Fill(this.sntbDataSet.User_NeActiv);

            }
            catch (Exception)
            {
                MessageBox.Show("не подключен БД");
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton1_Click(null, null);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SGlobal.kkk = (int)((DataRowView)user_NeActivBindingSource.Current).Row["user_id"];
            bool err = true;
            foreach (DataRow dr in sntbDataSet.User_NeActiv.Rows)
            {
                if ((dr["name"].ToString().Trim() == comboBox1.Text.Trim()) && (dr["pass"].ToString().Trim() == textBox1.Text.Trim()))
                {
                    switch (comboBox1.SelectedIndex)
                    {

                        case 0:
                            {
                                MDIParent1 form = new MDIParent1();
                                form.Show();
                                Visible = false;
                                err = false;
                                break;
                            }
                        case 1:
                            {
                                MDIParent1 form = new MDIParent1();
                                form.Show();
                                Visible = false;

                                err = false;
                                break;
                            }

                        case 2:
                            {
                                MDIParent1 form = new MDIParent1();
                                form.Show();
                                Visible = false;
                                err = false;
                                break;
                            }



                    }

                }
                if (!err) return;
            }
            if (err) MessageBox.Show("Вы ввели неправильный пароль, проверьте и введите заново!");
        }
        }
    }

