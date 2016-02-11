namespace Hello
{
    using System;
    using System.Globalization;

    public partial class Hello : System.Web.UI.Page
    {
        protected void ButtonPrintName_Click(object sender, EventArgs e)
        {
            var name = this.TextBoxName.Text;
                
            var helloName = "Hello " + name;
            this.TextBoxHello.Text = helloName;
        }
    }
}
