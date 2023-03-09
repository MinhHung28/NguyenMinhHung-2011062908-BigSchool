using System.Web;
using System.Web.Mvc;

namespace NguyenMinhHung_2011062908_BigSchool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
