using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace World_FootBall_Cup
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "A";
            int t1pt = 0;
            int t2pt = 0;
            int t3pt = 0;
            int t4pt = 0;

            int first = 0, second = 0, third = 0, fourth = 0;
            Form13 m = new Form13();

            label3.Text = Form9.Globals.teams[0];
            label4.Text = Form9.Globals.teams[2];
            label5.Text = Form9.Globals.teams[4];
            label6.Text = Form9.Globals.teams[6];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "B";
            label3.Text = Form9.Globals.teams[1];
            label4.Text = Form9.Globals.teams[3];
            label5.Text = Form9.Globals.teams[5];
            label6.Text = Form9.Globals.teams[7];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "C";
            label3.Text = Form9.Globals.teams[8];
            label4.Text = Form9.Globals.teams[11];
            label5.Text = Form9.Globals.teams[9];
            label6.Text = Form9.Globals.teams[10];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "D";
            label3.Text = Form9.Globals.teams[20];
            label4.Text = Form9.Globals.teams[12];
            label5.Text = Form9.Globals.teams[21];
            label6.Text = Form9.Globals.teams[13];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "E";
            label3.Text = Form9.Globals.teams[22];
            label4.Text = Form9.Globals.teams[17];
            label5.Text = Form9.Globals.teams[15];
            label6.Text = Form9.Globals.teams[23];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = "F";
            label3.Text = Form9.Globals.teams[16];
            label4.Text = Form9.Globals.teams[24];
            label5.Text = Form9.Globals.teams[25];
            label6.Text = Form9.Globals.teams[29];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = "G";
            label3.Text = Form9.Globals.teams[19];
            label4.Text = Form9.Globals.teams[30];
            label5.Text = Form9.Globals.teams[26];
            label6.Text = Form9.Globals.teams[28];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = "H";
            label3.Text = Form9.Globals.teams[27];
            label4.Text = Form9.Globals.teams[18];
            label5.Text = Form9.Globals.teams[14];
            label6.Text = Form9.Globals.teams[31];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form9 m = new Form9();
            m.Show();
            this.Hide();
        }

       

        

       
       
    }
}
