using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                String a = textBox1.Text + "1";
                textBox1.Text = a;
            }
            else
            {
                String a = textBox3.Text + "1";
                textBox3.Text = a;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                String a = textBox1.Text + "2";
                textBox1.Text = a;
            }
            else
            {
                String a = textBox3.Text + "2";
                textBox3.Text = a;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                String a = textBox1.Text + "3";
                textBox1.Text = a;
            }
            else
            {
                String a = textBox3.Text + "3";
                textBox3.Text = a;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                String a = textBox1.Text + "4";
                textBox1.Text = a;
            }
            else
            {
                String a = textBox3.Text + "4";
                textBox3.Text = a;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                String a = textBox1.Text + "5";
                textBox1.Text = a;
            }
            else
            {
                String a = textBox3.Text + "5";
                textBox3.Text = a;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                String a = textBox1.Text + "6";
                textBox1.Text = a;
            }
            else
            {
                String a = textBox3.Text + "6";
                textBox3.Text = a;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                String a = textBox1.Text + "7";
                textBox1.Text = a;
            }
            else
            {
                String a = textBox3.Text + "7";
                textBox3.Text = a;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                String a = textBox1.Text + "8";
                textBox1.Text = a;
            }
            else
            {
                String a = textBox3.Text + "8";
                textBox3.Text = a;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                String a = textBox1.Text + "9";
                textBox1.Text = a;
            }
            else
            {
                String a = textBox3.Text + "9";
                textBox3.Text = a;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                String a = textBox1.Text + "0";
                textBox1.Text = a;
            }
            else
            {
                String a = textBox3.Text + "0";
                textBox3.Text = a;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = "x";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text = "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "+")
            {
                int b, c, d;
                b = Convert.ToInt32(textBox1.Text);
                c = Convert.ToInt32(textBox3.Text);
                d = b + c;
                textBox4.Text = Convert.ToString(d);
            }
            else if (textBox2.Text == "-")
            {
                int b, c, d;
                b = Convert.ToInt32(textBox1.Text);
                c = Convert.ToInt32(textBox3.Text);
                d = b - c;
                textBox4.Text = Convert.ToString(d);
            }
            else if (textBox2.Text == "x")
            {
                int b, c, d;
                b = Convert.ToInt32(textBox1.Text);
                c = Convert.ToInt32(textBox3.Text);
                d = b * c;
                textBox4.Text = Convert.ToString(d);
            }
            else if (textBox2.Text == "/")
            {
                int b, c;
                double d;
                b = Convert.ToInt32(textBox1.Text);
                c = Convert.ToInt32(textBox3.Text);
                d = b / c;
                textBox4.Text = Convert.ToString(d);
            }
            else {
                textBox4.Text = textBox2.Text + " no es un operador valido";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
