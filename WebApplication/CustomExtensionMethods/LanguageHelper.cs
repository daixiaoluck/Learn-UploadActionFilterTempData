using System.Web.Mvc;
using System.Web.Routing;
using System;

namespace Learn_Upload.CustomExtensionMethods
{
    public static class LanguageHelper
    {
        public static string SwitchLanguage(this UrlHelper urlHelper, string languageValue)
        {
            RouteValueDictionary routeValueDictionary = urlHelper.RequestContext.RouteData.Values;
            if (routeValueDictionary.ContainsKey("lang"))
            {
                routeValueDictionary.Remove("lang");
            }
            routeValueDictionary.Add("lang", languageValue);
            // 不要使用RouteUrl
            // 不要忘了ToString
            return urlHelper.Action(
                routeValueDictionary["action"].ToString(), 
                routeValueDictionary["controller"].ToString(), 
                new { lang = routeValueDictionary["lang"].ToString() }
                );
        }
    }
}