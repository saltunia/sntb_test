using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace WindowsFormsApplication6
{
    public partial class Form15 : DevExpress.XtraEditors.XtraForm
    {
        int lastRowSelected;
        public Form15()
        {
            
            InitializeComponent();
        }

        private void protokolBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.protokolBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sntbDataSet);

        }

        private void Form15_Load(object sender, EventArgs e)
        {
           
            this.protokolTableAdapter.Fill(this.sntbDataSet.protokol,Convert.ToString(DateTime.Today).Substring(0,11));
            protokolBindingSource.MoveLast();
            this.reportViewer1.RefreshReport();
        }

        private void protokolDataGridView_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.protokolTableAdapter.Fill(this.sntbDataSet.protokol, Convert.ToString(DateTime.Today).Substring(0, 11));
            protokolBindingSource.MoveLast();
            this.reportViewer1.RefreshReport();

        }

       

       

       

       
        private void protokolBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {

                SGlobal.id_prot = (int)((DataRowView)protokolBindingSource.Current).Row["prot_id"];
                this.reportTableAdapter.Fill(this.sntbDataSet.report, SGlobal.id_prot);
                reportViewer1.RefreshReport();

            }
            catch (Exception)
            {
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.protokolTableAdapter.FillByAll(this.sntbDataSet.protokol);
            protokolBindingSource.MoveLast();
            this.reportViewer1.RefreshReport();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

       
     


       


        }

    }
