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
    public partial class Form14 : Form
    {
        int timeLeft;
        DateTime Time;
        public TimeSpan tt;//int timeLeft1;
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            timeLeft = 1;
            label1.Text ="00:00:00" ; 
           
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Time = DateTime.Now;
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        { if (timeLeft > 0 && timeLeft < 10)
            {
                // Display the new time left
                // by updating the Time Left label.
                //timeLeft = timeLeft - 1;
                //timeLeft1 = timeLeft1 - 1;
                tt = DateTime.Now - Time;
                label1.Text = tt.ToString().Substring(0, 8);
                ++timeLeft;
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                label1.Text = "Время вышло!";
                //MessageBox.Show("You didn't finish in time.", "Sorry");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
      
        }
}

