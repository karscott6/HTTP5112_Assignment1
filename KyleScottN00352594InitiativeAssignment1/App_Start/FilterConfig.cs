using System.Web;
using System.Web.Mvc;

namespace InitiativeAssignment1KyleScottN00352594
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
