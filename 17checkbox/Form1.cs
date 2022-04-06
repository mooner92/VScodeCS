using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CheckStates = "";
            CheckBox[] cbox = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 };
            /*foreach(var c in cbox)
            {
                CheckStates += String.Format("{0} : {1}\n", c.Text, c.Checked);
            }*/
            for(int i = 0; i < cbox.Length; i++)
            {
                CheckStates += String.Format("{0} : {1}\n", cbox[i].Text, cbox[i].Checked);
            }
            MessageBox.Show(CheckStates,"Summary");
            //string summary = string.Format("좋아하는 과일은 :");
            string summary = "좋아하는 과일은 :";
            foreach(var c in cbox)
            {
                if (c.Checked == true)
                {
                    summary += c.Text + " ";  //문자열 더하기 우겨넣기 가능
                }
            }
            MessageBox.Show(summary, "summary");
        }
    }
}
