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
    public partial class Form4 : DevExpress.XtraEditors.XtraForm
    {   bool saved = true;
    bool saved1 = true;
    
        public Form4()
       
         
        {
            InitializeComponent();
            
        }
        
        private void doljnostBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doljnostBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sntbDataSet);
            saved = true;
            saved1 = true;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.doljnost". При необходимости она может быть перемещена или удалена.
            this.doljnostTableAdapter.Fill(this.sntbDataSet.doljnost);

        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            saved = false;
        }
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                System.Windows.Forms.DialogResult result = MessageBox.Show("Была добавлена новоя должность . Сохранить?", "Уведомление", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    doljnostBindingNavigatorSaveItem.PerformClick();
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
                    doljnostBindingNavigatorSaveItem.PerformClick();
                }
                else
                    if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }

            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            saved1 = false;
        }

      
    }
}
