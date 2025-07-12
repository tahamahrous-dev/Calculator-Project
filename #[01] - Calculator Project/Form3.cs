using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace __01____Calculator_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string OpType = "+";

        public double GetResult(Button btn)
        {
            double Result = 0;

            switch (btn.Tag)
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

        public void Calculatt(Button btn)
        {
            btn.Tag = OpType;

            btnAdd.Enabled = false;
            btnSub.Enabled = false;
            btnMul.Enabled = false;
            btnDive.Enabled = false;

            txtNum1.Enabled = false;
            txtNum2.Enabled = false;

            txtResult.Text = txtNum1.Text + " " + btn.Tag + " " + txtNum2.Text + " = " + GetResult(btn);

            btnCalculat.Enabled = false;
           
        }


        private void btnCalculat_Click(object sender, EventArgs e)
        {
            Calculatt((Button)sender);
        }

        public void OpTypebtn(Button btn)
        {
            OpType = btn.Tag.ToString();
        }

        private void Opbtn_Click(object sender, EventArgs e)
        {
            OpTypebtn((Button)sender);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResult.Clear();

            btnAdd.Enabled = true;
            btnSub.Enabled = true;
            btnMul.Enabled = true;
            btnDive.Enabled = true;

            txtNum1.Enabled = true;
            txtNum2.Enabled = true;

            btnCalculat.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
