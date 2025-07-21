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

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                calcDisplay.Text += btn.Text;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                calcDisplay.Text += btn.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                calcDisplay.Text += btn.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                calcDisplay.Text += btn.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                calcDisplay.Text += btn.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                calcDisplay.Text += btn.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                calcDisplay.Text += btn.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                calcDisplay.Text += btn.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                calcDisplay.Text += btn.Text;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                calcDisplay.Text += btn.Text;
            }
        }
    }
}
