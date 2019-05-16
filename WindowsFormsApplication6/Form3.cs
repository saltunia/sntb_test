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
    public partial class Form3 : DevExpress.XtraEditors.XtraForm
    {   bool saved = true;
        bool saved1 = true;
        public Form3()
        {
            InitializeComponent();
           
        }
      
        private void predprBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.predprBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sntbDataSet);
            saved = true;
            saved1 = true;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.predpr". При необходимости она может быть перемещена или удалена.
            this.predprTableAdapter.Fill(this.sntbDataSet.predpr);

        }
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            saved1 = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            saved = false;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                System.Windows.Forms.DialogResult result = MessageBox.Show("Была добавлена новое предприятие . Сохранить?", "Уведомление", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    predprBindingNavigatorSaveItem.PerformClick();
                }
                else
                    if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }

            }
            if (!saved1)
            {
                System.Windows.Forms.DialogResult result = MessageBox.Show("Была удалена запись.Сохранить изменения? ", "Уведомление", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    predprBindingNavigatorSaveItem.PerformClick();
                }
                else
                    if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }

            }
        }

       
        }

       
    }

