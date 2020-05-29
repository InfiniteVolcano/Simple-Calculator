using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        bool enter_value = false;
        double results;
        string operations;

        public Form1()
        {
            InitializeComponent();
        }

        private void numbtn_click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + num.Text;
            }
            else
                txtDisplay.Text = txtDisplay.Text + num.Text;
        }

        private void Arithmeticbtn_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operations = num.Text;
            results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            CurrentOperation.Text = System.Convert.ToString(results) + " " + operations;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            CurrentOperation.Text = "";
            switch (operations) { 
                case "+":
                    txtDisplay.Text = (results + Double.Parse(txtDisplay.Text)).ToString();
                break;
                case "-":
                    txtDisplay.Text = (results - Double.Parse(txtDisplay.Text)).ToString();
                break;
                case "*":
                    txtDisplay.Text = (results * Double.Parse(txtDisplay.Text)).ToString();
                break;
                case "/":
                    txtDisplay.Text = (results / Double.Parse(txtDisplay.Text)).ToString();
                break;
            }

        }

        private void CE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            CurrentOperation.Text = "";
        }
    }
}
