using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Munch = "노르웨이 출신의 표현주의 화가이다.";
            string history = "처음에는 신(新)인상파의 영향을 받아 점묘의 수법을 사용하여 \n삶과 죽음에의 극적이고 내면적인 그림을 그렸다. 1892년 베를린으로 이주,\n 그곳의 미술 협회에 출품했다. 그는 나면서부터 몸이 약해 작품에도 그 영향이 드러나 있는데,\n 나치스는 퇴폐예술이라는 이유로 그의 그림을 몰수하기도 했다.\n 작품으로 <절규>, <병든 소녀> 등이 있다.";
            label1.Text = Munch;
            label2.Text = history;
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
