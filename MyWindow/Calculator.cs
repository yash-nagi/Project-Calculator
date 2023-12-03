using System.Web;

namespace MyWindow
{
    public partial class Calculator : Form
    {
        string operation;
        decimal a;
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            if (result.Text != "0")
            {
                result.Text = "0";
            }
            else
            {
                result.Clear();
            }

        }

        private void btndiv_Click(object sender, EventArgs e)
        {
             a = Convert.ToDecimal(result.Text);
            result.Text = "0";
            operation = "/";
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
             a = Convert.ToDecimal(result.Text);
            result.Text = "0";
            operation = "*";
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
             a = Convert.ToDecimal(result.Text);
            result.Text = "0";
            operation = "-";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" && result.Text == "7")
            {
                result.Text = "7";
            }
            else
            {
                result.Text = result.Text + "7";
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" && result.Text == "8")
            {
                result.Text = "8";
            }
            else
            {
                result.Text = result.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" && result.Text == "9")
            {
                result.Text = "9";
            }
            else
            {
                result.Text = result.Text + "9";
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
             a = Convert.ToDecimal(result.Text);
            result.Text = "0";
            operation = "+";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" && result.Text == "4")
            {
                result.Text = "4";
            }
            else
            {
                result.Text = result.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" && result.Text == "5")
            {
                result.Text = "5";
            }
            else
            {
                result.Text = result.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" && result.Text == "6")
            {
                result.Text = "6";
            }
            else
            {
                result.Text = result.Text + "6";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(result.Text == "0" && result.Text == "1")
            {
                result.Text = "1";
            }
            else
            {
                result.Text = result.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" && result.Text == "2")
            {
                result.Text = "2";
            }
            else
            {
                result.Text = result.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" && result.Text == "3")
            {
                result.Text = "3";
            }
            else
            {
                result.Text = result.Text + "3";
            }
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" && result.Text == "0")
            {
                result.Text = "0";
            }
            else
            {
                result.Text = result.Text + "0";
            }
        }

        private void btndecimal_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" && result.Text == ".")
            {
                result.Text = ".";
            }
            else
            {
                result.Text = result.Text + ".";
            }
        }

        private void btnequalsto_Click(object sender, EventArgs e)
        {
            //logic

            decimal r;
            decimal b = Convert.ToDecimal(result.Text);
           if(operation == "+")
            {
                r = a + b;
                result.Text = r.ToString();
            }
           if(operation == "-")
            {
                r = a - b;
                result.Text = r.ToString();
            }
           if(operation == "*")
            {
                r = a * b;
                result.Text = r.ToString();
            }
           if(operation == "/")
            {
                if(b==0)
                {
                    result.Text = "Can't Divide by 0";
                }
                else
                {
                    r = a / b;
                    result.Text = r.ToString();
                }
             
            }
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}