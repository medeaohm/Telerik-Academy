namespace PrintBrowserTypeAndIP
{
    using System;

    public partial class PrintBrowserTypeAndIP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LiteralOutput.Text = "Browser Type: " + Request.Browser.Type + "<br/>";
            this.LiteralOutput.Text += "IP Address: " + Request.UserHostAddress;
        }
    }
}