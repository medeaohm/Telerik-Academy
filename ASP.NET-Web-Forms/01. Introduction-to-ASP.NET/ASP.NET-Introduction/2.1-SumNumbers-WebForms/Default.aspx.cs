using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2._1_SumNumbers_WebForms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SumButton_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(TextBox1.Text);
            Console.WriteLine(number1);
            int number2 = int.Parse(TextBox2.Text);
            Console.WriteLine(number2);
            int result = number1 + number2;
            Console.WriteLine(result);
            Result.Text = result.ToString();
        }
    }
}