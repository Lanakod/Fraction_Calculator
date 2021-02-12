using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_countResult_Click(object sender, EventArgs e)
        {
            Fraction a = Fraction.Parse(textBox_firstNumber.Text);
            Fraction b = Fraction.Parse(textBox_secondNumber.Text);

            if (radioButton1.Checked) textBox_result.Text = (a + b).Round(trackBar1.Value).ToString();
            else if (radioButton2.Checked) textBox_result.Text = (a - b).Round(trackBar1.Value).ToString();
            else if (radioButton3.Checked) textBox_result.Text = (a * b).Round(trackBar1.Value).ToString();
            else if (radioButton4.Checked) textBox_result.Text = (a / b).Round(trackBar1.Value).ToString();
        }

        private void textCheck(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 42 || number >= 58) && number != 8 && number != 32) e.Handled = true;
        }
    }
}
