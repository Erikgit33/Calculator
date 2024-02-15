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
        int binary = 0; //Variable whose value is 1 if binary mode is active, and 0 if it's not. 
        string mode = "0"; //String carrying the mode of the calulation. 
        double number = 0; //Double which carries the number in the calulator before choosing which mode to use, I.e "+" or "*".
        double MS = 0; //Double which carries the number the calulator had after pressing the MS, Memory Store, button.
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
            //A list of nine buttons which all do the same thing, that is add one character that 
            // is the same as on them to the label working as the display. They Also replace any zero
            // that might be in the display at start.
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
            //Four buttons with each of the four operations, which set the text in label1 as "0" an
            // store what was written before any of them being pressed in the variable number.
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
            //The button for writing a comma
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
            //When pressing the calulate button, the program first checks if you are trying to divide by zero, and if you 
            //are, it tells you that you cannot divide by zero.
            //
            //After that, it goes through each of the operations and acts accordingly, for example, if you've put in "2 + 7", the 
            //program adds them together under the names "tmp", temporary, and "number", our variable. The text in the label is then
            //set to the value that tmp carries in a string format.
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
            buttonclear.ForeColor = Color.Red; //As the form loads, the foreground color of the "Clear" and "Memory Clear" buttons is set to red.
            buttonMC.ForeColor = Color.Red;
        }

        private void toxthpower_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            number = double.Parse(label1.Text); 
            label1.Text = "0";
            mode = btn.Text;   
            //This button does the exact same thing as all the other operation buttons, but is instead for raising numbers by an Xth power.
        }

        private void buttonsqrt_Click(object sender, EventArgs e)
        {
            double tmp = double.Parse(label1.Text);
            label1.Text = Math.Sqrt(tmp).ToString();
            //This button takes the square root of numbers.
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
            //When changing between binary and decimal, the program simply converts the text in label1 to base 2 if the binary variable
            //indicates that binary is true, otherwise, it declares a temporary variable with the value of the text in label1, and converts
            //it to base 2.
        }

        private void buttonconvert_Click(object sender, EventArgs e)
        {
            double tmp = double.Parse(label1.Text);
            label1.Text = (tmp * -1).ToString();
            //Converts numbers in label1 to their negative version, I.e "1" becomes "-1".
        }

        private void button10_Click(object sender, EventArgs e) 
        {
            Button btn = (Button)sender;
            number = double.Parse(label1.Text);
            label1.Text = "0";
            mode = btn.Text;
            //The button for showing a desired number of percent of a number. 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MS = double.Parse(label1.Text);
            label1.Text = "0";
            //The button that updates the Memory Store variable.
        }

        private void button12_Click(object sender, EventArgs e)
        {
           if (MS == 0)
           {
               
           }
           else
           {
                label1.Text = MS.ToString();
           }
           //The button for pasting what value was stored in MS.
           //If MS hasn't stored anything, nothing happens. If something is stored in it, it will be
           //pasted into label1 as its text.
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            MS = 0;
            //The button for clearing the memory, MS is set to 0.
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            label1.Text = ("0");
            //The button for clearing the text in label1.
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
            //The button for deleating characters in the text of label1.
            //If the button is pressed, and there is only one character left in label1, it will be switced to 0.
            //If there is more than one character left, the length of the text in label1 is decreased by 1.
        }
    }
}
