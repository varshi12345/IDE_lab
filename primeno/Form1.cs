using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String num = textBox1.Text;
            Int32 n = Int32.Parse(num);
            if(n==0 || n==1)
            {
                label1.Text = "Neither";
            }
            else
            {
                if(n==2 || n==3)
                {
                    label1.Text = "Prime";
                }
                else
                {
                    int i, flag;
                    i = 2;
                    flag = 0;
                    while(i*i<=n)
                    {
                        if(n%i==0)
                        {
                            flag = 1;
                            break;
                        }
                        i++;
                    }
                    if(flag==0)
                    {
                        label1.Text = "Prime";
                    }
                    else
                    {
                        label1.Text = "Not Prime";
                    }
                }
            }

        }
    }
}
