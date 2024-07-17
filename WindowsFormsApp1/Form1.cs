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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = Convert.ToSingle(txtOperand1.Text);
                float num2 = Convert.ToSingle(txtOperand2.Text);
                txtAnswer.Text = (num1 * num2).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(" Enter only numeric values");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = Convert.ToSingle(txtOperand1.Text);
                float num2 = Convert.ToSingle(txtOperand2.Text);
                txtAnswer.Text = (num1 + num2).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(" Enter only numeric values");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = Convert.ToSingle(txtOperand1.Text);
                float num2 = Convert.ToSingle(txtOperand2.Text);
                txtAnswer.Text = (num1 - num2).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(" Enter only numeric values");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = Convert.ToSingle(txtOperand1.Text);
                float num2 = Convert.ToSingle(txtOperand2.Text);
                txtAnswer.Text = (num1 / num2).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(" Enter only numeric values");
            }
        }
    }
}
