using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EscapingHTML
{
    public partial class Escape : System.Web.UI.Page
    {
        protected void BtnShowText_Click(object sender, EventArgs e)
        {
            string enteredText = Server.HtmlEncode(this.InputText.Text);
            this.OutputText.Text = enteredText;
            this.LabelOutputText.Text = enteredText;
        }
    }
}