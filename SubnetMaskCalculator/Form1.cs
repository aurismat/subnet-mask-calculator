using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubnetMaskCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Subnet Mask Calculator/Helper.\nMade by aurismat\nhttps://github.com/aurismat","About");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            string output = "";
            int value = (int)numericUpDown1.Value;
            while(value > 0)
            {
                if (value >= 8)
                {
                    output += "255.";
                    value -= 8;
                }
                else
                {
                    int number = (int)Math.Pow((double)2, (double)(8-value));
                    number = 256 - number;
                    output += number + ".";
                    value -= value;
                }
                    
            }
            int dotCount = output.Count(x => x == '.');
            for(int i = 0; i < 4 - dotCount; i++)
            {
                output += "0.";
            }

            output = output.TrimEnd('.');
            textBox2.Text = output;
        }
    }
}
