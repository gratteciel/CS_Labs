using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3
{
    public partial class Form1 : Form
    {
        private double exchange_rate = 4;
        private bool EurToDH = true; 
        
        public Form1()
        {
            this.BackColor = Color.Aqua;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            EurToDH = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            EurToDH = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double inputAmount;
            double convertAmount;
            // Check for empty or invalid input
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }
            // check if the input is a number
            if (!double.TryParse(textBox2.Text, out inputAmount))
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
                return;
            }
            // check if the user choose a conversion option
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Please select a conversion option.");
                return;
            }
            // Perform conversion
            if (EurToDH)
            {
                convertAmount = inputAmount * exchange_rate;
                textBox3.Text = textBox3.ToString();
            }
            else
            {
                convertAmount = inputAmount / exchange_rate;
                textBox3.Text = convertAmount.ToString();
            }

        }
    }
}