﻿using System.Web;
using System.Web.Mvc;

namespace WebAppReference452Mvc523VS2013
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
