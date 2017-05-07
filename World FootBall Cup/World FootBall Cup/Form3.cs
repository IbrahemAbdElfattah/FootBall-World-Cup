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
        List<string> Teams = new List<string>();
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
            file.Close();
            Form2 m = new Form2();
            m.Show();
            this.Hide();
        }
        System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\IAA\Documents\Visual Studio 2012\Projects\World FootBall Cup\World FootBall Cup\Data\Teams.txt");
        private void button3_Click(object sender, EventArgs e)
        {
            file.WriteLine(comboBox2.Text);
            Teams.Add(comboBox2.Text);
            if( Teams.Count > 48)
            {
                MessageBox.Show("Teams is completed ! please go back Or click RESET Botton");
            }
            for (int i = 0; i < PlayersNam.Count; i++)
            {
                file.Write(PlayersNum[i]);
                file.Write(" ");
                file.Write(PlayersNam[i]);
                file.WriteLine(" ");
                PlyrNum.Add(PlayersNam[i],PlayersNum[i]);
            }
                TeamPlyrs.Add(comboBox2.Text, PlyrNum);
                PlyrNum.Clear();
                PlayersNam.Clear();
                PlayersNum.Clear();
                            
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
