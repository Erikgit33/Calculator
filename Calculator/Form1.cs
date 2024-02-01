using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int binary = 0;
        string mode = "0";
        double number = 0;
        double MS = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            Button btn = (Button)sender;
            label1.Text = label1.Text + btn.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            Button btn = (Button)sender;
            label1.Text = label1.Text + btn.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            Button btn = (Button)sender;
            label1.Text = label1.Text + btn.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            Button btn = (Button)sender;
            label1.Text = label1.Text + btn.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            Button btn = (Button)sender;
            label1.Text = label1.Text + btn.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            Button btn = (Button)sender;
            label1.Text = label1.Text + btn.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            Button btn = (Button)sender;
            label1.Text = label1.Text + btn.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            Button btn = (Button)sender;
            label1.Text = label1.Text + btn.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            Button btn = (Button)sender;
            label1.Text = label1.Text + btn.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            Button btn = (Button)sender;
            label1.Text = label1.Text + btn.Text;
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            number = double.Parse(label1.Text);
            label1.Text = "0";
            mode = btn.Text;
        }

        private void buttonremove_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            number = double.Parse(label1.Text);
            label1.Text = "0";
            mode = btn.Text;
        }

        private void buttonmultiply_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            number = double.Parse(label1.Text);
            label1.Text = "0";
            mode = btn.Text;
        }

        private void buttondivide_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            number = double.Parse(label1.Text);
            label1.Text = "0";
            mode = btn.Text;
        }

        private void buttoncomma_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!label1.Text.Contains(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                label1.Text = label1.Text + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            }
            else
            {
                label1.Text = label1.Text + "";
            }

            
        }

        private void buttoncalc_Click(object sender, EventArgs e)
        {
            double tmp = double.Parse(label1.Text);
            if (mode == "/")
            {
                if (tmp == 0)
                {
                    MS = 0;
                    number = 0;
                    label1.Text = ("0");
                    MessageBox.Show("Can't divide by zero!");
                    return;
                }
            }

            if (mode == "+")
            {
                tmp = tmp + number;
                label1.Text = tmp.ToString();
            }
            else if (mode == "-")
            {
                tmp = number - tmp;
                label1.Text = tmp.ToString();
            }
            else if (mode == "*")
            {
                tmp = tmp * number;
                label1.Text = tmp.ToString();
            }
            else if (mode == "/")
            {
                tmp = number / tmp;
                label1.Text = tmp.ToString();
            }
            else if (mode == "x^y")
            {
                label1.Text = Math.Pow(number, tmp).ToString();
            }
            else if (mode == "%")
            {
                label1.Text = ((number / 100) * tmp).ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonclear.ForeColor = Color.Red;
            buttonMC.ForeColor = Color.Red;
        }

        private void toxthpower_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            number = double.Parse(label1.Text);
            label1.Text = "0";
            mode = btn.Text;
        }

        private void buttonsqrt_Click(object sender, EventArgs e)
        {
            double tmp = double.Parse(label1.Text);
            label1.Text = Math.Sqrt(tmp).ToString();
        }

        private void buttondecbin_Click(object sender, EventArgs e)
        {
            if (binary == 1) 
            {
                label1.Text = Convert.ToInt64(label1.Text, 2).ToString();
                binary = 0;
            }
            else 
            {
                double tmp = double.Parse(label1.Text);
                label1.Text = Convert.ToString((int)tmp, 2);
                binary = 1;
            }
        }

        private void buttonconvert_Click(object sender, EventArgs e)
        {
            double tmp = double.Parse(label1.Text);
            label1.Text = (tmp * -1).ToString();
        }

        private void button10_Click(object sender, EventArgs e) //buttonpercent
        {
            Button btn = (Button)sender;
            number = double.Parse(label1.Text);
            label1.Text = "0";
            mode = btn.Text;
        }

        private void button11_Click(object sender, EventArgs e) // MS
        {
            MS = double.Parse(label1.Text);
            label1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e) // MR
        {
           if (MS == 0)
           {
                return;
           }
           else
           {
                label1.Text = MS.ToString();
            }
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            MS = 0;
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            label1.Text = ("0");
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 1 ) 
            {
                label1.Text = "0";
            }
            else
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);
            }
        }
    }
}
