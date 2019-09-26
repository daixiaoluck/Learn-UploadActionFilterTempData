using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Learn_Upload.Filters
{
    public class LocalizationAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string lang = null;
            if (filterContext.RouteData.Values["lang"] == null)
            {
                lang = "en";
            }
            else
            {
                lang = filterContext.RouteData.Values["lang"].ToString();
            }
            try
            {
                Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            }catch(Exception exception)
            {
                throw exception;
            }
        }
    }
}