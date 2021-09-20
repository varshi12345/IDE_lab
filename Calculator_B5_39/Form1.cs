using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_B5_39
{
    public partial class Form1 : Form
    {
        Double output = 0;
        String operation = "";
        bool operator_given = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if ((tB_output.Text == "0") || (operator_given))
                tB_output.Clear();
            operator_given = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!tB_output.Text.Contains("."))
                {
                    tB_output.Text = tB_output.Text + button.Text;
                }
            }
            else
            {
                tB_output.Text = tB_output.Text + button.Text;
            }
        }

        private void op_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (output != 0)
            {
                equal.PerformClick();
                operation = button.Text;
                output = Double.Parse(tB_output.Text);
                label_operation_string.Text = output + " " + operation;
                operator_given = true;

            }
            if(button.Text=="-/")
            {
                operation = button.Text;
                output = Double.Parse(tB_output.Text);
                label_operation_string.Text = "-/(" + output + ")";
                operator_given = true;
            }
            else
            {
                operation = button.Text;
                output = Double.Parse(tB_output.Text);
                label_operation_string.Text = output + " " + operation;
                operator_given = true;
            }
        }

        private void bC_Click(object sender, EventArgs e)
        {
            tB_output.Text = "0";
            output = 0;
        }

        private void bCE_Click(object sender, EventArgs e)
        {
            tB_output.Text = "0";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    tB_output.Text = (output + Double.Parse(tB_output.Text)).ToString();
                    break;
                case "-":
                    tB_output.Text = (output - Double.Parse(tB_output.Text)).ToString();
                    break;
                case "*":
                    tB_output.Text = (output * Double.Parse(tB_output.Text)).ToString();
                    break;
                case "/":
                    tB_output.Text = (output / Double.Parse(tB_output.Text)).ToString();
                    break;
                case "-/":
                    tB_output.Text = (Math.Sqrt(output)).ToString();
                    break;
                default:
                    break;

            }
            output = Double.Parse(tB_output.Text);
            label_operation_string.Text = "";

        }

    }
}
