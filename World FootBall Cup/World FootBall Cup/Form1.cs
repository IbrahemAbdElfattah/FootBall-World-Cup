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
    public partial class Form1 : Form
    {
        public int [] a= new int[48];
        public Form1()
        {
            InitializeComponent();
        }
        public int ad() 
        {
            return 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            m.Show();
            this.Hide();
        }

        
    }
}
