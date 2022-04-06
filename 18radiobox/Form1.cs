using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18radiobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            if (RBkorea.Checked)
                result += "국적 : 한국 ";
            else if (RBchina.Checked)
                result += "국적 : 중국 ";
            else if (RBjapan.Checked)
                result += "국적 : 일본 ";
            else
                result += "국적 : 그 외 ";

            if (RBmale.Checked)
                result += "성별 : 남성";
            else
                result += "성별 : 여성";

            MessageBox.Show(result);
        }

        /*private void RBmale_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("성별 : 남성");
        }

        private void RBfemale_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("성별 : 여성");
        }//if 뭐시기 추가하기*/
    }
}
