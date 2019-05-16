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
    public partial class Form10 : DevExpress.XtraEditors.XtraForm
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void questionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.questionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sntbDataSet);
            SGlobal.str10 = (int)((DataRowView)questionsBindingSource.Current).Row["id"];
            id_temaTextBox.Text = SGlobal.str7.ToString();
            textBox1.Text = SGlobal.str10.ToString();
            queriesTableAdapter1.Insertvoprtema(SGlobal.str10, SGlobal.str7);




        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.truth". При необходимости она может быть перемещена или удалена.
            this.truthTableAdapter.Fill(this.sntbDataSet.truth);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.truth". При необходимости она может быть перемещена или удалена.
            //this.answersTableAdapter.Fill(this.sntbDataSet.answers);
            string str = "vopr_id = ";
            str = str + SGlobal.str10;
            //str = str + textBox1.Text;
            this.answersBindingSource1.Filter = str;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.tip_vopr". При необходимости она может быть перемещена или удалена.
            this.tip_voprTableAdapter.Fill(this.sntbDataSet.tip_vopr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sntbDataSet.questions". При необходимости она может быть перемещена или удалена.
            this.questionsTableAdapter.Fill(this.sntbDataSet.questions);
            bindingNavigatorAddNewItem.PerformClick();


        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //SGlobal.str8 =Convert.ToInt32(doc_idTextBox.Text);
            doc_idTextBox.Text = SGlobal.str8.ToString();
            id_temaTextBox.Text = SGlobal.str7.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                pictureTextBox.Text = openFileDialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            queriesTableAdapter1.insertanswer(Convert.ToInt32(textBox1.Text), textTextBox1.Text, pictureTextBox1.Text, Convert.ToByte(sequenceTextBox.Text), Convert.ToByte(comboBox2.SelectedValue));
            string str = "vopr_id = ";
            str = str + SGlobal.str10;
            //str = str + textBox1.Text;
            this.answersBindingSource1.Filter = str;
            this.answersTableAdapter.Fill(this.sntbDataSet.answers);
            answersDataGridView.Refresh();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                pictureTextBox1.Text = openFileDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.questionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sntbDataSet);
            SGlobal.str10 = (int)((DataRowView)questionsBindingSource.Current).Row["id"];
            id_temaTextBox.Text = SGlobal.str7.ToString();
            textBox1.Text = SGlobal.str10.ToString();
            queriesTableAdapter1.Insertvoprtema(SGlobal.str10, SGlobal.str7);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sequenceTextBox.Text = null;
            textTextBox1.Text = null;

            //private void answersDataGridView_SelectionChanged(object sender, EventArgs e)
            //{
            //   // SGlobal.str11 = (int)((DataRowView)answersBindingSource1.Current).Row["id"];
            //}

            //private void button2_Click(object sender, EventArgs e)
            //{
            //    //queriesTableAdapter1.fordeleteanswer(SGlobal.str11);
            //}












        }

       
    }
}