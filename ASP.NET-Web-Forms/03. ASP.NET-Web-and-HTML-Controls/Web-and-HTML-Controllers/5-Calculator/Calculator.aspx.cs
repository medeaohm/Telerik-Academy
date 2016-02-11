namespace Calculator
{
    using System;
    using System.Globalization;

    public partial class Calculator : System.Web.UI.Page
    {
        CultureInfo provider = new CultureInfo("en-GB");

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.TextBoxNumber.Text = this.TextBoxNumber.Text + "1";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.TextBoxNumber.Text = this.TextBoxNumber.Text + "2";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            this.TextBoxNumber.Text = this.TextBoxNumber.Text + "3";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            this.TextBoxNumber.Text = this.TextBoxNumber.Text + "4";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            this.TextBoxNumber.Text = this.TextBoxNumber.Text + "5";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            this.TextBoxNumber.Text = this.TextBoxNumber.Text + "6";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            this.TextBoxNumber.Text = this.TextBoxNumber.Text + "7";
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            this.TextBoxNumber.Text = this.TextBoxNumber.Text + "8";
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            this.TextBoxNumber.Text = this.TextBoxNumber.Text + "9";
        }

        protected void Button0_Click(object sender, EventArgs e)
        {
            this.TextBoxNumber.Text = this.TextBoxNumber.Text + "0";
        }

        protected void ButtonPlus_Click(object sender, EventArgs e)
        {
            if (this.TextBoxNumber.Text == "")
            {
                return;
            }
            else
            {
                this.lastOperand.Value = "+";
                this.firstValue.Value = this.TextBoxNumber.Text;
                this.TextBoxNumber.Text = "";
            }
        }

        protected void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (this.TextBoxNumber.Text == "")
            {
                return;
            }
            else
            {
                this.lastOperand.Value = "-";
                this.firstValue.Value = this.TextBoxNumber.Text;
                this.TextBoxNumber.Text = "";
            }
        }

        protected void ButtonMultiply_Click(object sender, EventArgs e)
        {
            if (this.TextBoxNumber.Text == "")
            {
                return;
            }
            else
            {
                this.lastOperand.Value = "*";
                this.firstValue.Value = this.TextBoxNumber.Text;
                this.TextBoxNumber.Text = "";
            }
        }

        protected void ButtonDivide_Click(object sender, EventArgs e)
        {
            if (this.TextBoxNumber.Text == "")
            {
                return;
            }
            else
            {
                this.lastOperand.Value = "/";
                this.firstValue.Value = this.TextBoxNumber.Text;
                this.TextBoxNumber.Text = "";
            }
        }

        protected void ButtonSquareRoot_Click(object sender, EventArgs e)
        {
            if (this.TextBoxNumber.Text == "")
            {
                return;
            }
            else
            {
                this.TextBoxNumber.Text = Math.Sqrt(Double.Parse(this.TextBoxNumber.Text, provider)).ToString();
            }
        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            this.TextBoxNumber.Text = "";
        }

        protected void ButtonEqual_Click(object sender, EventArgs e)
        {
            if (this.lastOperand.Value == "+")
            {
                decimal rezult = Decimal.Parse(this.firstValue.Value, provider) + Decimal.Parse(this.TextBoxNumber.Text, provider);
                this.TextBoxNumber.Text = rezult.ToString();
            }
            else if (this.lastOperand.Value == "-")
            {
                decimal rezult = Decimal.Parse(this.firstValue.Value, provider) - Decimal.Parse(this.TextBoxNumber.Text, provider);
                this.TextBoxNumber.Text = rezult.ToString();
            }
            else if (this.lastOperand.Value == "*")
            {
                decimal rezult = Decimal.Parse(this.firstValue.Value, provider) * Decimal.Parse(this.TextBoxNumber.Text, provider);
                this.TextBoxNumber.Text = rezult.ToString();
            }
            else if (this.lastOperand.Value == "/")
            {
                decimal rezult = Decimal.Parse(this.firstValue.Value, provider) / Decimal.Parse(this.TextBoxNumber.Text, provider);
                this.TextBoxNumber.Text = rezult.ToString();
            }

            this.lastOperand.Value = string.Empty;
            this.firstValue.Value = string.Empty;
        }

        protected void ButtonDot_Click(object sender, EventArgs e)
        {
            if (this.TextBoxNumber.Text.Contains("."))
            {
            }
            else
            {
                this.TextBoxNumber.Text += ".";
            }
        }
    }
}