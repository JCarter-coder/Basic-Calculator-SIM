using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator_SIM
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void calcDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            // This method is used to handle the click event for all number buttons
            // It appends the button's text to the calculator display
            Button btn = sender as Button;
            if (btn != null)
            {
                calcDisplay.Text += btn.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Button 1
            numberButton_Click(sender, e);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Button 2
            numberButton_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Button 3
            numberButton_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Button 4
            numberButton_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Button 5
            numberButton_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Button 6
            numberButton_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Button 7
            numberButton_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Button 8
            numberButton_Click(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Button 9
            numberButton_Click(sender, e);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            // Button 0
            numberButton_Click(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // This clears the display
            calcDisplay.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // This is the Delete back button
            // If the display text isn't empty, remove the last character
            if (calcDisplay.Text.Length > 0)
            {
                // Reassign the substring to the display text
                calcDisplay.Text = calcDisplay.Text.Substring(0, calcDisplay.Text.Length - 1);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Decimal point button
            // Ensure that there is only one decimal point in the display
            if (!calcDisplay.Text.Contains("."))
            {
                calcDisplay.Text = string.IsNullOrEmpty(calcDisplay.Text) ? "0." : calcDisplay.Text + ".";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // This is the addition button
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // This is the subtraction button
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // This is the multiplication button
        }

        private void button20_Click(object sender, EventArgs e)
        {
            // This is the division button
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // This is the equals button
        }
    }
}
