using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        Double res = 0;
        String operPerfor = "";
        bool isTOrF = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isTOrF))
            {
                textBox_Result.Clear();
            }

            isTOrF = false;

            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;
            }
            else
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(res != 0)
            {
                button11.PerformClick();
                operPerfor = button.Text;
                res = Double.Parse(textBox_Result.Text);
                OperPer.Text = res + " " + operPerfor;
                isTOrF = true;
            }

            operPerfor = button.Text;
            res = Double.Parse(textBox_Result.Text);
            OperPer.Text = res + " " + operPerfor;
            isTOrF = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            res = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch(operPerfor)
            {
                case "+":
                    textBox_Result.Text = (res + Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "-":
                    textBox_Result.Text = (res - Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "*":
                    textBox_Result.Text = (res * Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "/":
                    textBox_Result.Text = (res / Double.Parse(textBox_Result.Text)).ToString();
                    break;
 
                default:
                    break;
            }
            res = Double.Parse(textBox_Result.Text);
            OperPer.Text = "";
        }
    }
}
