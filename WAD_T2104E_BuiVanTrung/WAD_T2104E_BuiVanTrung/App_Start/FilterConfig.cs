using System.Web;
using System.Web.Mvc;

namespace WAD_T2104E_BuiVanTrung
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
