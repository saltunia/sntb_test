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
    public partial class prog : DevExpress.XtraEditors.XtraForm
    {
        public prog()
        {
            InitializeComponent();
        }

        private void progBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.progBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sntbDataSet);

        }

        private void prog_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.prog". При необходимости она может быть перемещена или удалена.
            this.progTableAdapter.Fill(this.sntbDataSet.prog);
            //bindingNavigatorAddNewItem.PerformClick();
        }
    }
}
