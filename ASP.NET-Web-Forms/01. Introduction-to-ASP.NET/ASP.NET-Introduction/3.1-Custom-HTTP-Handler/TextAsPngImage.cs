using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Web;

namespace _03.HTTP_Handler
{
    public class TextAsPngImage : IHttpHandler
    {
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        // Enter some text in url - for example http://localhost:35285/helloworld
   
        public void ProcessRequest(HttpContext context)
        {
            var requestUrl = context.Request.Url.ToString();

            var path = context.Server.MapPath("images/image.png");
            var bitmap = new Bitmap(400, 150, PixelFormat.Format24bppRgb);
            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                var backgroundColor = Color.AliceBlue;
                graphics.Clear(backgroundColor);
                graphics.DrawString(
                    requestUrl,
                    new Font("Comic Sans MS", 15, FontStyle.Bold),
                    SystemBrushes.WindowText,
                    new PointF(20, 60));
                context.Response.ContentType = "image/png";
                bitmap.Save(context.Response.OutputStream, ImageFormat.Png);
            }
        }
    }
}