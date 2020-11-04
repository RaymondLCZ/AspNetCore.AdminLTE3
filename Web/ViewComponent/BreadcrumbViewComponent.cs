using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Zee.AspNetCore.AdminLTE3.Web.Models;
using Zee.AspNetCore.AdminLTE3.Web.Helpers;

namespace Zee.AspNetCore.AdminLTE3.Web.ViewComponent
{
    [Microsoft.AspNetCore.Mvc.ViewComponent(Name = "Breadcrumb")]
    public class BreadcrumbViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string currentController)
        {
            var items = MenuItemHelper.GetAllMenuItem();

            var item = items.Where(i => i.Controller == currentController).FirstOrDefault();

            return View(item);
        }

    }
}