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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            fillarray();
        }
        public static class Globals
        {
            public static string[] teams = new string[32]; // Modifiable in Code
        }

        
        public void fillarray()
        {
            //Form3 mm = new Form3();
            if (Form3.Globals.Teams.Count != 32)
            {
                MessageBox.Show("Number of teams is less than 32! Please add teams first!");
                for (int i = 0; i < 32; i++)
                {
                    Globals.teams[i] = "(not fixed)";
                }
            }
            else 
            {
                for (int i = 0; i < 32; i++)
                {
                    Globals.teams[i] = Form3.Globals.Teams[i];
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form10 m = new Form10();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 m = new Form8();
            //A
            m.label1.Text = Globals.teams[0];
            m.label4.Text = Globals.teams[2];
            m.label32.Text = Globals.teams[4];
            m.label5.Text = Globals.teams[6];
            //B
            m.label2.Text = Globals.teams[1];
            m.label6.Text = Globals.teams[3];
            m.label7.Text = Globals.teams[5];
            m.label8.Text = Globals.teams[7];
            //C
            m.label3.Text = Globals.teams[8];
            m.label9.Text = Globals.teams[11];
            m.label10.Text = Globals.teams[9];
            m.label11.Text = Globals.teams[10];
            //D
            m.label12.Text = Globals.teams[20];
            m.label13.Text = Globals.teams[12];
            m.label14.Text = Globals.teams[21];
            m.label15.Text = Globals.teams[13];
            //E
            m.label31.Text = Globals.teams[22];
            m.label30.Text = Globals.teams[17];
            m.label29.Text = Globals.teams[15];
            m.label28.Text = Globals.teams[23];
            //F
            m.label27.Text = Globals.teams[16];
            m.label25.Text = Globals.teams[24];
            m.label24.Text = Globals.teams[25];
            m.label26.Text = Globals.teams[29];
            //G
            m.label23.Text = Globals.teams[19];
            m.label22.Text = Globals.teams[30];
            m.label21.Text = Globals.teams[26];
            m.label20.Text = Globals.teams[28];
            //H
            m.label16.Text = Globals.teams[27];
            m.label17.Text = Globals.teams[18];
            m.label18.Text = Globals.teams[14];
            m.label19.Text = Globals.teams[31];
           
            
            m.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 m = new Form4();
            m.Show();
            this.Hide();
        }
    }
}
