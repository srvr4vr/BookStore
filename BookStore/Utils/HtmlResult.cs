using System.Web.Mvc;

namespace BookStore.Util
{
    public class HtmlResult : ActionResult
    {
        private string htmlCode;

        public HtmlResult(string html)
        {
            htmlCode = html;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            string fullHtmlCode = "<!DOCTYPE html><html><head>";
            fullHtmlCode += "<title>Главная страница</title>";
            fullHtmlCode += "<meta charset=utf-8 />";
            fullHtmlCode += "</head> <body>";
            fullHtmlCode += htmlCode;
            fullHtmlCode += "</body></html>";
            context.HttpContext.Response.Write(fullHtmlCode);
        }

        public class ImageResult : ActionResult
        {
            private string path;
            public ImageResult(string path)
            {
                this.path = path;
            }
            public override void ExecuteResult(ControllerContext context)
            {
                context.HttpContext.Response.Write("<div style='width:100%;text-align:center;'>" +
                    "<img style='max-width:600px;' src='" + path + "' /></div>");
            }
        }
    }
}