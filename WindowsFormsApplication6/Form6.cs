﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form6 : DevExpress.XtraEditors.XtraForm
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.tema_count_vopr". При необходимости она может быть перемещена или удалена.
            this.tema_count_voprTableAdapter.Fill(this.sntbDataSet.tema_count_vopr);

        }
    }
}
