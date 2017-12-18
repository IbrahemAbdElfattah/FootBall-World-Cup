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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form4 m = new Form4();
            m.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label19.Text = "A";
            Form8 m = new Form8();
            label3.Text = m.label1.Text;
            label8.Text = m.label4.Text;
            label5.Text = m.label32.Text;
            label4.Text = m.label5.Text;
           
            label12.Text = m.label5.Text;
            label6.Text = m.label1.Text;
            label11.Text = m.label4.Text;
            label7.Text = m.label32.Text;
            
            label9.Text = m.label32.Text;
            label1.Text = m.label1.Text;
            label10.Text = m.label5.Text;
            label2.Text = m.label4.Text;
            
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label19.Text = "B";
            Form8 m = new Form8();
            label3.Text = m.label2.Text;
            label8.Text = m.label6.Text;
            label5.Text = m.label7.Text;
            label4.Text = m.label8.Text;
            
            label12.Text = m.label8.Text;
            label6.Text = m.label2.Text;
            label11.Text = m.label6.Text;
            label7.Text = m.label7.Text;
            
            label9.Text = m.label7.Text;
            label1.Text = m.label2.Text;
            label10.Text = m.label8.Text;
            label2.Text = m.label6.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label19.Text = "C";
            Form8 m = new Form8();
            label3.Text = m.label3.Text;
            label8.Text = m.label9.Text;
            label5.Text = m.label10.Text;
            label4.Text = m.label11.Text;
           
            label12.Text = m.label11.Text;
            label6.Text = m.label3.Text;
            label11.Text = m.label9.Text;
            label7.Text = m.label10.Text;
            
            label9.Text = m.label10.Text;
            label1.Text = m.label3.Text;
            label10.Text = m.label11.Text;
            label2.Text = m.label9.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label19.Text = "D";
            Form8 m = new Form8();
            label3.Text = m.label12.Text;
            label8.Text = m.label13.Text;
            label5.Text = m.label14.Text;
            label4.Text = m.label15.Text;
            
            label12.Text = m.label15.Text;
            label6.Text = m.label12.Text;
            label11.Text = m.label13.Text;
            label7.Text = m.label14.Text;
            
            label9.Text = m.label14.Text;
            label1.Text = m.label12.Text;
            label10.Text = m.label15.Text;
            label2.Text = m.label13.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label19.Text = "E";
            Form8 m = new Form8();
            label3.Text = m.label31.Text;
            label8.Text = m.label30.Text;
            label5.Text = m.label29.Text;
            label4.Text = m.label28.Text;
            
            label12.Text = m.label28.Text;
            label6.Text = m.label31.Text;
            label11.Text = m.label30.Text;
            label7.Text = m.label29.Text;
            
            label9.Text = m.label29.Text;
            label1.Text = m.label31.Text;
            label10.Text = m.label30.Text;
            label2.Text = m.label28.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label19.Text = "F";
            Form8 m = new Form8();
            label3.Text = m.label27.Text;
            label8.Text = m.label25.Text;
            label5.Text = m.label24.Text;
            label4.Text = m.label26.Text;
            
            label12.Text = m.label26.Text;
            label6.Text = m.label27.Text;
            label11.Text = m.label25.Text;
            label7.Text = m.label24.Text;
            
            label9.Text = m.label24.Text;
            label1.Text = m.label27.Text;
            label10.Text = m.label25.Text;
            label2.Text = m.label26.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label19.Text = "G";
            Form8 m = new Form8();
            label3.Text = m.label23.Text;
            label8.Text = m.label22.Text;
            label5.Text = m.label21.Text;
            label4.Text = m.label20.Text;
            
            label12.Text = m.label20.Text;
            label6.Text = m.label23.Text;
            label11.Text = m.label22.Text;
            label7.Text = m.label21.Text;
            
            label9.Text = m.label21.Text;
            label1.Text = m.label23.Text;
            label10.Text = m.label22.Text;
            label2.Text = m.label20.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label19.Text = "H";
            Form8 m = new Form8();
            label3.Text = m.label16.Text;
            label8.Text = m.label17.Text;
            label5.Text = m.label18.Text;
            label4.Text = m.label19.Text;
            
            label12.Text = m.label19.Text;
            label6.Text = m.label16.Text;
            label11.Text = m.label17.Text;
            label7.Text = m.label18.Text;
            
            label9.Text = m.label18.Text;
            label1.Text = m.label16.Text;
            label10.Text = m.label17.Text;
            label2.Text = m.label19.Text;
        }
    }
}
