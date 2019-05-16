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
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
        bool saved = true;
        bool saved1 = true;
        public Form2()
        {
            InitializeComponent();
        }

        private void temaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.temaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sntbDataSet);
            bool saved = true;
            bool saved1 = true;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.tema". При необходимости она может быть перемещена или удалена.
            this.temaTableAdapter.Fill(this.sntbDataSet.tema);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form s =new Form6();
            s.Show();

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                System.Windows.Forms.DialogResult result = MessageBox.Show("Была добавлена новая тема . Сохранить?", "Уведомление", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    temaBindingNavigatorSaveItem.PerformClick();
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
                    temaBindingNavigatorSaveItem.PerformClick();
                }
                else
                    if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }

            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            saved = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            saved1 = false;
        }
    }
}
