namespace ExchangeDataWithCookies
{
    using System;
    using System.Web;

    public partial class LoginCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookieUser = Request.Cookies["user"];
            if (cookieUser != null)
            {
                this.LabelLoginResult.Text = ("You are currently logged in as " + cookieUser.Values["username"]);
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }
    }
}