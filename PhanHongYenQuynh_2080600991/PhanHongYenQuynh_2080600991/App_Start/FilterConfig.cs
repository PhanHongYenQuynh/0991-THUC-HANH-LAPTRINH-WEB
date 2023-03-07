using System.Web;
using System.Web.Mvc;

namespace PhanHongYenQuynh_2080600991
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
