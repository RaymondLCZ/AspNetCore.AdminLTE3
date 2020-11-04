using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Zee.AspNetCore.AdminLTE3.Web.Models;
using Zee.AspNetCore.AdminLTE3.Web.Helpers;

namespace Zee.AspNetCore.AdminLTE3.Web.ViewComponent
{
    [Microsoft.AspNetCore.Mvc.ViewComponent(Name = "TopNavigation")]
    public class TopNavigationViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = MenuItemHelper.GetParentMenuItem();

            return View(items);
        }
    }

}
