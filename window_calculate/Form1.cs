using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace window_calculate
{
    public partial class Form1 : Form
    {
        string operation = "";
        double result = 0;
        bool isOperation = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            if (textBox1.Text == "0" || isOperation == true) 
            {
                textBox1.Clear();
            }

            if(btn.Text == ".") 
            {
                if (!textBox1.Text.Contains(".")) 
                {
                    textBox1.Text = textBox1.Text + btn.Text;
                }
                  
            }
            else
            {
                textBox1.Text = textBox1.Text + btn.Text;
            }

            isOperation = false;


        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operation = btn.Text;
            result = double.Parse(textBox1.Text);
            isOperation = true;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            switch (operation) 
            {
                case "+":
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    break;
                case "X":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = 0;
        }
    }
}
