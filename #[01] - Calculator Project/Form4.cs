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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int Number1 = 0;
        int Number2 = 0;
        string OpType;

        public double GetResult()
        {
            double Result = 0;

            switch (OpType)
            {
                case "+":
                    Result = Number1 + Number2;
                    break;

                case "-":
                    Result = Result = Number1 - Number2;
                    break;

                case "*":
                    Result = Result = Number1 * Number2;
                    break;

                case "/":
                    Result = Result = Number1 / Number2;
                    break;
            }

            return (double)Result;
        }

        public void NumberClick(Button btn)
        {
            if(txtEnterNum.Text == "0")
            {
                txtEnterNum.Text = btn.Tag.ToString();
            }
            else
            {
                txtEnterNum.Text += btn.Tag.ToString();
            }     
        }

        private void btn_Click(object sender, EventArgs e)
        {
            NumberClick((Button)sender);
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtEnterNum.Text == "0")
            {
                return;
            }
            else if(txtEnterNum.Text.Length > 0)
            {
                //txtEnterNum.Text = txtEnterNum.Text.Remove(txtEnterNum.Text.Length - 1);
                txtEnterNum.Text = txtEnterNum.Text.Substring(0, txtEnterNum.TextLength - 1);

            }
            else
            {
                txtEnterNum.Text = "0";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtEnterNum.Text = "0";
        }

        public void OpretorClick(Button btn)
        {
            if (lblOpertor.Text == "" && lblResult.Text == "")
            {
                Number1 = Convert.ToInt32(txtEnterNum.Text);
                OpType = btn.Tag.ToString();
                lblOpertor.Text = btn.Tag.ToString();
                lblResult.Text = txtEnterNum.Text;
                txtEnterNum.Text = "0";
            }
            else
            {
                Number2 = Convert.ToInt32(txtEnterNum.Text);
                OpType = btn.Tag.ToString();
                lblOpertor.Text = btn.Tag.ToString();
                lblResult.Text = GetResult().ToString();
                Number1 = Convert.ToInt32(lblResult.Text);
                txtEnterNum.Text = "0";
            }

        }

        private void btnOpType_Click(object sender, EventArgs e)
        {
            OpretorClick((Button)sender);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Number2 = Convert.ToInt32(txtEnterNum.Text);
            txtEnterNum.Text = GetResult().ToString();
            lblResult.Text = Number1.ToString() + " " + OpType + " " + Number2 + " =";
            lblOpertor.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblResult.Text = string.Empty;
            txtEnterNum.Text = "0";
        }
    }
}
