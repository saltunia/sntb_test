using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.DXCore.Controls.XtraGrid;
namespace WindowsFormsApplication6
{
    public partial class grafik : DevExpress.XtraEditors.XtraForm
    {
        public grafik()
        {
            InitializeComponent();
        }

       

        private void grafik_Load(object sender, EventArgs e)
        {
            DateTime s = DateTime.Today.AddDays(-3);
            DateTime d = DateTime.Today.AddDays(2);
            this.grafik_sdachiTableAdapter.FillBydate(this.sntbDataSet.grafik_sdachi,s,d);
            this.predprTableAdapter.Fill(this.sntbDataSet.predpr);
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            ShowGridPreview(grafik_sdachiGridControl);
        }

        private void ShowGridPreview(DevExpress.XtraGrid.GridControl grafik_sdachiGridControl)
        {
            if (!grafik_sdachiGridControl.IsPrintingAvailable)
            {
                MessageBox.Show("Библиотека 'DevExpress.XtraPrinting' не найдена", "Ошибка");
                return;
            }

            // Open the Preview window.
            grafik_sdachiGridControl.ShowPrintPreview();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.grafik_sdachiTableAdapter.Fill(this.sntbDataSet.grafik_sdachi);
            this.predprTableAdapter.Fill(this.sntbDataSet.predpr);
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            if (dateEdit5.Text != "" && dateEdit6.Text != "")
            {
                DateTime s = Convert.ToDateTime(dateEdit6.Text);
                DateTime d = Convert.ToDateTime(dateEdit5.Text);
                this.grafik_sdachiTableAdapter.FillBydate(this.sntbDataSet.grafik_sdachi, s, d);
                this.predprTableAdapter.Fill(this.sntbDataSet.predpr);
            }
            else
            { MessageBox.Show("Введите даты для поиска"); }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Today;
            this.grafik_sdachiTableAdapter.FillByprosrochka(this.sntbDataSet.grafik_sdachi, d);
            this.predprTableAdapter.Fill(this.sntbDataSet.predpr);
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            DateTime s = DateTime.Today.AddDays(-3);
            DateTime d = DateTime.Today.AddDays(3);
            this.grafik_sdachiTableAdapter.FillBydate(this.sntbDataSet.grafik_sdachi, s, d);
            this.predprTableAdapter.Fill(this.sntbDataSet.predpr);

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            grafik_sdachiBindingSource.AddNew();
            SGlobal.insert = "insert";
        }

        private void bandedGridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                if (SGlobal.insert == "insert")
                {
                    var rowHandle = bandedGridView1.FocusedRowHandle;
                    if (bandedGridView1.GetRowCellValue(rowHandle, "id_res").ToString() == "" || bandedGridView1.GetRowCellValue(rowHandle, "fio").ToString() == "" || bandedGridView1.GetRowCellValue(rowHandle, "dolj").ToString() == "" || bandedGridView1.GetRowCellValue(rowHandle, "ptb").ToString() == "" || bandedGridView1.GetRowCellValue(rowHandle, "pte").ToString() == "" || bandedGridView1.GetRowCellValue(rowHandle, "ppb").ToString() == "" || bandedGridView1.GetRowCellValue(rowHandle, "gr_po_tb").ToString() == "")
                    {
                        MessageBox.Show("Введите все данные!!!");

                    }
                    else
                    {
                        int predp = (int)bandedGridView1.GetRowCellValue(rowHandle, "id_res");
                        string fio = (string)bandedGridView1.GetRowCellValue(rowHandle, "fio");
                        string dolj = (string)bandedGridView1.GetRowCellValue(rowHandle, "dolj");
                         string gr_po_tb = (string)bandedGridView1.GetRowCellValue(rowHandle, "gr_po_tb");
                        DateTime ptb = (DateTime)bandedGridView1.GetRowCellValue(rowHandle, "ptb");
                        DateTime pte = (DateTime)bandedGridView1.GetRowCellValue(rowHandle, "pte");
                        DateTime ppb = (DateTime)bandedGridView1.GetRowCellValue(rowHandle, "ppb");
                        DateTime s = DateTime.Today.AddDays(-3);
                        DateTime d = DateTime.Today.AddDays(3);
                      
                        //this.usersTableAdapter.InsertQuery(predp, dolj, name, pass, DateTime.Now.ToString()); 
                        this.grafik_sdachiTableAdapter.InsertQuery(predp, fio, dolj, gr_po_tb, ptb, pte, ppb);
                        this.grafik_sdachiTableAdapter.FillBydate(this.sntbDataSet.grafik_sdachi, s, d);
                        this.predprTableAdapter.Fill(this.sntbDataSet.predpr);
                        grafik_sdachiBindingSource.MoveLast();
                    }
                }
                else
                {
                    var rowHandle = bandedGridView1.FocusedRowHandle;
                    int i = grafik_sdachiBindingSource.Position;
                    int id = (int)bandedGridView1.GetRowCellValue(rowHandle, "id");
                    int predp = (int)bandedGridView1.GetRowCellValue(rowHandle, "id_res");
                   
                    string fio = (string)bandedGridView1.GetRowCellValue(rowHandle, "fio");
                    string dolj = (string)bandedGridView1.GetRowCellValue(rowHandle, "dolj");
                    string gr_po_tb = (string)bandedGridView1.GetRowCellValue(rowHandle, "gr_po_tb");
                    DateTime ptb = (DateTime)bandedGridView1.GetRowCellValue(rowHandle, "ptb");
                    DateTime pte = (DateTime)bandedGridView1.GetRowCellValue(rowHandle, "pte");
                    DateTime ppb = (DateTime)bandedGridView1.GetRowCellValue(rowHandle, "ppb");
                    this.grafik_sdachiTableAdapter.UpdateQuery(predp, fio, dolj, gr_po_tb, ptb, pte, ppb,id);
                    DateTime s = DateTime.Today.AddDays(-3);
                    DateTime d = DateTime.Today.AddDays(3);
                    this.grafik_sdachiTableAdapter.FillBydate(this.sntbDataSet.grafik_sdachi, s, d);
                    this.predprTableAdapter.Fill(this.sntbDataSet.predpr);
                    grafik_sdachiBindingSource.Position = i;
                }
                MessageBox.Show("Данные успешно сохранены");
              
            }
            catch{ MessageBox.Show("Данные не сохранены"); }
            SGlobal.insert = "";
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
 DialogResult result = MessageBox.Show("Вы действительно \nхотите удалить? \n" , "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                grafik_sdachiTableAdapter.DeleteQuery(SGlobal.str_del);
                this.grafik_sdachiTableAdapter.Fill(this.sntbDataSet.grafik_sdachi);
                this.predprTableAdapter.Fill(this.sntbDataSet.predpr);
              
            }
        }

        private void grafik_sdachiBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                SGlobal.str_del = (int)((DataRowView)grafik_sdachiBindingSource.Current).Row["id"];
               
            }
            catch { }
        }
 
    }
}