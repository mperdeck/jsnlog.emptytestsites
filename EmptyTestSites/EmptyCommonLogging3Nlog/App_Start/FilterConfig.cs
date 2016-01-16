using System.Web;
using System.Web.Mvc;

namespace EmptyCommonLogging3NLog
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}