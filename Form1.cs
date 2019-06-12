using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int count;
        double number;
        double answer;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Multiline = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

            number += double.Parse(textBox1.Text);
            textBox2.Text += textBox1.Text + "+";
            textBox1.Clear();
            count = 2;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (count)
            {
                case 1:
                    answer = number * double.Parse(textBox1.Text);
                    textBox2.Text += textBox1.Text;
                    textBox1.Text = Convert.ToString(answer);
                    break;
                case 2:
                    answer = number + double.Parse(textBox1.Text);
                    textBox2.Text += textBox1.Text;
                    textBox1.Text = Convert.ToString(answer);
                    break;
                case 3:
                    answer = number / double.Parse(textBox1.Text);
                    textBox2.Text += textBox1.Text;
                    textBox1.Text = Convert.ToString(answer);
                    break;
                case 4:
                    answer = number - double.Parse(textBox1.Text);
                    textBox2.Text += textBox1.Text;
                    textBox1.Text = Convert.ToString(answer);
                    break;
                case 5:
                    answer = number % double.Parse(textBox1.Text);
                    textBox2.Text += textBox1.Text;
                    textBox1.Text = Convert.ToString(answer);
                    break;
                default:
                    break;
            }
        }

        private void btnBy_Click(object sender, EventArgs e)
        {
            number += double.Parse(textBox1.Text);
            textBox2.Text += textBox1.Text + "x";
            textBox1.Clear();
            count = 1;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            number += double.Parse(textBox1.Text);
            textBox2.Text += textBox1.Text + "/";
            textBox1.Clear();
            count = 3;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            number += double.Parse(textBox1.Text);
            textBox2.Text += textBox1.Text + "-";
            textBox1.Clear();
            count = 4;
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            number += double.Parse(textBox1.Text);
            textBox2.Text += textBox1.Text + "%";
            textBox1.Clear();
            count = 5;
        }
        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            number = 0;
            answer = 0;
            count = 0;
        }
    }
}
