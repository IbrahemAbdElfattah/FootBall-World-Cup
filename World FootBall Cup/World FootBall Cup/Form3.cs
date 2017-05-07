using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World_FootBall_Cup
{
    public partial class Form3 : Form
    {

        List<string> PlayersNam = new List<string>();
        List<string> PlayersNum = new List<string>();

        Dictionary<string, Dictionary<object, object>> TeamPlyrs = new Dictionary<string, Dictionary<object, object>>();
        Dictionary<object, object> PlyrNum = new Dictionary<object, object>();
        
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            m.Show();
            this.Hide();
        }
        //int i = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PlayersNam.Count; i++)
            {
                PlyrNum.Add(PlayersNam[i],PlayersNum[i]);
            }
                TeamPlyrs.Add(comboBox2.Text, PlyrNum);
                PlyrNum.Clear();
                PlayersNam.Clear();
                PlayersNum.Clear();

            System.IO.File.WriteAllText(@"C:\Users\IAA\Documents\Visual Studio 2012\Projects\World FootBall Cup\World FootBall Cup\Data\WriteText.txt", TeamPlyrs.Keys.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PlayersNam.Count == 22)
            {
                MessageBox.Show("Players Names is complete !");
            }
            else
            {
                PlayersNam.Add(textBox2.Text);
                PlayersNum.Add(comboBox1.Text);
            }
        }



        

        


    }
}
