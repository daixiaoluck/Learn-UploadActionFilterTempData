using System.Web;
using System.Web.Mvc;
using Learn_Upload.Filters;

namespace Learn_Upload
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LocalizationAttribute());
        }
    }
}
