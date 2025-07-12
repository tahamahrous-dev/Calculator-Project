using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace __01____Calculator_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public double GetResult(Button btn)
        {
            double Result = 0;

            switch(btn.Tag)
            {
                case "+":
                     Result = Convert.ToDouble(txtNum1.Text) + Convert.ToDouble(txtNum2.Text);
                    break;

                case "-":
                     Result = Convert.ToDouble(txtNum1.Text) - Convert.ToDouble(txtNum2.Text);
                    break;

                case "*":
                    Result = Convert.ToDouble(txtNum1.Text) * Convert.ToDouble(txtNum2.Text);
                    break;

                case "/":
                    Result = Convert.ToDouble(txtNum1.Text) / Convert.ToDouble(txtNum2.Text);
                    break;
            }

            return (double)Result;
        }


        public int Factorial(string txtNum)
        {
            int Number = 0;
            int factor = 1;

            Number = Convert.ToInt32(txtNum);

            for (int i = 1; i < Number; i++)
            {
                factor += (i * factor);
            }

            return factor;
        }

        public void Calculatt(Button btn)
        {
            btnAdd.Enabled = false;
            btnSub.Enabled = false;
            btnMul.Enabled = false;
            btnDive.Enabled = false;

            txtNum1.Enabled = false;
            txtNum2.Enabled = false;

            btnReset.Visible = true;
            btnReset.Focus();

            lblResult.Text = "Result = " + GetResult(btn);
            lblFactorialOf.Visible = true;
            lblFactorialOf.Text = "Factorial Of  " + txtNum1.Text + " = " + Factorial(txtNum1.Text);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Calculatt((Button)sender);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();

            btnAdd.Enabled = true;
            btnSub.Enabled = true;
            btnMul.Enabled = true;
            btnDive.Enabled = true;

            txtNum1.Enabled = true;
            txtNum2.Enabled = true;

            lblResult.Text = "Result = ";
            lblFactorialOf.Text = "Factorial Of  ";

            btnReset.Visible = false;
            lblFactorialOf.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnAdd.Visible)
            {
                btnAdd.Visible = false;
            }
            else
            {
                btnAdd.Visible = true;
            }
        }
    }
}
