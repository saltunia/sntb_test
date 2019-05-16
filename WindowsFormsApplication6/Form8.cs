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
    public partial class Form8 : DevExpress.XtraEditors.XtraForm
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void type_docBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.type_docBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sntbDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.type_doc". При необходимости она может быть перемещена или удалена.
            this.type_docTableAdapter.Fill(this.sntbDataSet.type_doc);

        }
    }
}
