﻿using System.Web;
using System.Web.Mvc;

namespace ppowellRad2017Mvc2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
