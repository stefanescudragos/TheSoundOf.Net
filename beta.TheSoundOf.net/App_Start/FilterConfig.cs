﻿using System.Web;
using System.Web.Mvc;

namespace beta.TheSoundOf.net
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            
            //filters.Add(new ElmahHandleErrorAttribute());
            filters.Add(new HandleErrorAttribute());
            
        }
    }
}