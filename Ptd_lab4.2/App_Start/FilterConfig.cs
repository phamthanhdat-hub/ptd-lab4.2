﻿using System.Web;
using System.Web.Mvc;

namespace Ptd_lab4._2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
