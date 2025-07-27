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

        private float firstNumber = 0;
        string operation = "";

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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // This clears the display
            calcDisplay.Text = "";
            firstNumber = 0; // Reset the answer
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

        private void buttonPI_Click(object sender, EventArgs e)
        {
            // This is the PI constant button
            if (calcDisplay.Text.Length == 0)
            {
                // If the display is empty, set it to PI
                calcDisplay.Text = Math.PI.ToString().Substring(0, 16);
            }
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // This is the addition button
            if (calcDisplay.Text.Length > 0)
            {
                // Try to parse the first number from the display text
                if (float.TryParse(calcDisplay.Text, out firstNumber))
                {
                    // Successfully parsed the number
                    operation = "+";
                    // Clear the display for the next input
                    calcDisplay.Text = "";
                }
                else
                {
                    // Handle the case where parsing fails (e.g., display invalid input)
                    MessageBox.Show("Invalid input. Please enter a valid number.");
                }
            }
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            // This is the subtraction button
            if (calcDisplay.Text.Length > 0)
            {
                // Try to parse the first number from the display text
                if (float.TryParse(calcDisplay.Text, out firstNumber))
                {
                    // Successfully parsed the number
                    operation = "-";
                    // Clear the display for the next input
                    calcDisplay.Text = ""; 
                }
                else
                {
                    // Handle the case where parsing fails (e.g., display invalid input)
                    MessageBox.Show("Invalid input. Please enter a valid number.");
                }
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            // This is the multiplication button
            if (calcDisplay.Text.Length > 0)
            {
                // Try to parse the first number from the display text
                if (float.TryParse(calcDisplay.Text, out firstNumber))
                {
                    // Successfully parsed the number
                    operation = "*";
                    // Clear the display for the next input
                    calcDisplay.Text = "";
                }
                else
                {
                    // Handle the case where parsing fails (e.g., display invalid input)
                    MessageBox.Show("Invalid input. Please enter a valid number.");
                }
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            // This is the division button
            if (calcDisplay.Text.Length > 0)
            {
                // Try to parse the first number from the display text
                if (float.TryParse(calcDisplay.Text, out firstNumber))
                {
                    // Successfully parsed the number
                    operation = "/";
                    // Clear the display for the next input
                    calcDisplay.Text = "";
                }
                else
                {
                    // Handle the case where parsing fails (e.g., display invalid input)
                    MessageBox.Show("Invalid input. Please enter a valid number.");
                }
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            // This is the equals button
            float secondNumber;
            if (float.TryParse(calcDisplay.Text, out secondNumber))
            {
                float result = 0;

                if (operation == "+")
                {
                    result = firstNumber + secondNumber; // Perform addition
                }
                else if (operation == "-")
                {
                    result = firstNumber - secondNumber; // Perform addition
                }
                else if (operation == "*")
                {
                    result = firstNumber * secondNumber; // Perform addition
                }
                else if (operation == "/")
                {
                    // TODO: Check for division by zero
                    result = firstNumber / secondNumber; // Perform addition
                }
                // Update firstNumber for potential further calculations
                firstNumber = result;
                // Display the result
                calcDisplay.Text = result.ToString();
                // Reset the operation after calculation
                operation = ""; 
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // This is the percentage button
            if (calcDisplay.Text.Length > 0)
            {
                // Try to parse the first number from the display text
                if (float.TryParse(calcDisplay.Text, out firstNumber))
                {
                    // Successfully parsed the number
                    // Convert to percentage
                    firstNumber /= 100;
                    // Display the percentage value
                    calcDisplay.Text = firstNumber.ToString();
                }
                else
                {
                    // Handle the case where parsing fails (e.g., display invalid input)
                    MessageBox.Show("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}
