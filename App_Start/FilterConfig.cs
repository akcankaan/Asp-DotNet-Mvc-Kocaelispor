using System.Web;
using System.Web.Mvc;

namespace g212102053_mehmet_kaan_akcan_odev
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
