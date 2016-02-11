using System;
using System.Reflection;
using System.Web.UI;

namespace _02.Web_Forms_App
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.HelloFromCSharp.Text = "Hello, ASP.NET (from the C# code)";
            this.LabelAssembly.Text = Assembly.GetExecutingAssembly().Location;
        }
    }
}