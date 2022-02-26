using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Epinikion.Core.Extensions
{
    public static class HtmlExtensions
    {
        public static IHtmlString GetGridHtml(this HtmlHelper html, IPublishedContent contentItem, string framework, string propertyAlias, bool fluidImages, bool showPadding)
        {
            if (fluidImages)
            {
                return html.Raw(html.GetGridHtml(contentItem, framework, propertyAlias).ToString().Replace("<img ", $"<img class=\"img-fluid {(showPadding ? "p-1 bg-body rounded" : "")}\" "));
            }

            return html.GetGridHtml(contentItem, propertyAlias, framework);
        }
    }
}