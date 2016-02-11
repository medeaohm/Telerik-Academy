using System;

namespace RandomGenerator
{
    public partial class RandomGenerator : System.Web.UI.Page
    {
        private readonly Random rand = new Random();

        protected void Btn_Gen_Random_Click(object sender, EventArgs e)
        {
            try
            {
                var min = int.Parse(this.min.Text);
                var max = int.Parse(this.max.Text);
                this.random.Text = "Random Number: " + this.rand.Next(min, max).ToString();
            }
            catch (Exception)
            {
                this.random.Text = "Invalid";
            }
        }
    }
}