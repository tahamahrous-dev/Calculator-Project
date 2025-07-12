using System;
using System.Windows.Forms;

namespace __01____Calculator_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Number1 = 0;
        public int Number2 = 0;
        public string OpType = "";

      


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

        public void InputOpType(Button btn)
        {
            Number1 = Convert.ToInt32(txtEnterNum.Text);

            OpType =  btn.Tag.ToString();

            txtEnterNum.Text += " " + btn.Tag + " ";

            

        }

        private void btnOp_Click(object sender, EventArgs e)
        {
            InputOpType((Button)sender);
        }

        public void InputNumbers(Button btn)
        {
            if (txtEnterNum.Text == "0")
            {
                txtEnterNum.Text = btn.Text;
            }
            else
            {
                txtEnterNum.Text += btn.Text;
            }

            for (int i = 0; i < txtEnterNum.Text.Length; i++)
            {
                if (txtEnterNum.Text[i] == '+' || txtEnterNum.Text[i] == '-' || txtEnterNum.Text[i] == '*' || txtEnterNum.Text[i] == '/')
                {
                    Number2 = Convert.ToInt32(txtEnterNum.Text.Substring(i + 1));
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            InputNumbers((Button)sender);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblView.Text = "";
            txtEnterNum.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtEnterNum.Text = "0";
        }

        private void btnEqul_Click(object sender, EventArgs e)
        {
            txtEnterNum.Text = GetResult().ToString();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
          txtEnterNum.Text = txtEnterNum.Text.Substring(0, txtEnterNum.TextLength - 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtEnterNum.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtEnterNum.Text = "0";
        }
    }
}
