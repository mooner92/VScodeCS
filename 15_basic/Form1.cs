﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_basic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool flag = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if(flag ==false)
            {
                label1.Text = "hello windows form programming";
                flag = true;
            }
            if (textBox1.Text == "")
                MessageBox.Show("이름을 입력하세요", "warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else
            {
                label2.Text = textBox1.Text + "님! 안녕하세요!";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label0_Click(object sender, EventArgs e)
        {

        }
    }
}
