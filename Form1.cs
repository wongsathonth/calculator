using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1 = 0.0;
        double num2 = 0.0;
        string operatorList = "";
        bool operatorState = false;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form(object sender, EventArgs e)
        {
            Button buttonText = (Button)sender;

            if (operatorState)
            {
                this.textBox1.Text = string.Empty;
                operatorState = false;
            }

            if (this.textBox1.Text == "0")
            {
                this.textBox1.Text = string.Empty;
            }

            if (buttonText.Text == ".")
            {
                if (this.textBox1.Text.Contains("."))
                {
                    return;
                }
            }

            if (buttonText.Text != ".")
            {
                this.textBox1.Text = this.textBox1.Text + buttonText.Text;
                this.textBox1.Text = String.Format("{0:#,##0.#####}", double.Parse(this.textBox1.Text));
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + buttonText.Text;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bot1(object sender, EventArgs e)
        {
            Button buttonText = (Button)sender;

            if (buttonText.Text == "clear")
            {
                this.textBox1.Text = "0";
                this.textBox2.Text = "";
                num1 = 0.0;
                num2 = 0.0;
                operatorList = string.Empty;
            }

            if (buttonText.Text == "+")
            {
                num1 = double.Parse(this.textBox1.Text);
                operatorList = "+";
                operatorState = true;
                this.textBox2.Text = this.textBox1.Text + operatorList;
            }
            if (buttonText.Text == "-")
            {
                num1 = double.Parse(this.textBox1.Text);
                operatorList = "-";
                operatorState = true;
                this.textBox2.Text = this.textBox1.Text + operatorList;
            }
            if (buttonText.Text == "*")
            {
                num1 = double.Parse(this.textBox1.Text);
                operatorList = "*";
                operatorState = true;
                this.textBox2.Text = this.textBox1.Text + operatorList;
            }
            if (buttonText.Text == "/")
            {
                num1 = double.Parse(this.textBox1.Text);
                operatorList = "/";
                operatorState = true;
                this.textBox2.Text = this.textBox1.Text + operatorList;
            }

            if (buttonText.Text == "=")
            {
                num2 = double.Parse(this.textBox1.Text);

                if (operatorList == "+")
                {
                    this.textBox1.Text = (num1 + num2).ToString();
                    this.textBox2.Text = num1.ToString() + operatorList + " = " + num2.ToString();
                }
                if (operatorList == "-")
                {
                    this.textBox1.Text = (num1 - num2).ToString();
                    this.textBox2.Text = num1.ToString() + operatorList + " = " + num2.ToString();

                }
                if (operatorList == "*")
                {
                    this.textBox1.Text = (num1 * num2).ToString();
                    this.textBox2.Text = num1.ToString() + " " + operatorList + " = " + num2.ToString();

                }
                if (operatorList == "/")
                {
                    this.textBox1.Text = (num1 / num2).ToString();
                    this.textBox2.Text = num1.ToString() + operatorList + " = " + num2.ToString();

                }
                operatorList = string.Empty;
            }
        }
    }
    
}

