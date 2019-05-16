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
    public partial class MDIParent1 : DevExpress.XtraEditors.XtraForm
    {
              public MDIParent1()
        {
            InitializeComponent();
           
        }

      

      









        private void программToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form childForm = new red_prog();
            
            childForm.Show();
        }

        private void темыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Form2();
           
            childForm.Show();
        }

        private void документовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new red_doc();
            
            childForm.Show();

        }

        private void тестовToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form childForm = new red_testov();
         
            childForm.Show();
        }

        private void вопросовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new redac_vopr();
           
            childForm.Show();
        }

       

        private void назначениеПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Form1();
           
            childForm.Show();
        }

        private void протоколToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Form15();
           
            childForm.Show();

        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            
          
            if (SGlobal.kkk == 1)
            {
                this.протоколаToolStripMenuItem.Visible = false;
            }
            Form childForm = new Form1();
            childForm.ShowDialog();


        }

        

       

        private void правильныхОтветовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new Form16();
           
            childForm.Show();

        }

        private void графикСдачиЭкзаменовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new grafik();

            childForm.Show();
        }

        private void MDIParent1_FormClosed(object sender, FormClosedEventArgs e)
        {
  DialogResult result = MessageBox.Show("Хотите войти под другим пользователем \nСмена пользователя \n", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                Form s = new audentification();
                s.Show();
            }
            else
            {
                Application.Exit();



            }
        }

       

       

       
    }
}
