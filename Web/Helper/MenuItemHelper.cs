using System;
using System.Collections.Generic;
using System.Linq;
using Zee.AspNetCore.AdminLTE3.Web.Models;

namespace Zee.AspNetCore.AdminLTE3.Web.Helpers
{
    public class MenuItemHelper
    {
        public static IEnumerable<MenuItem> GetParentMenuItem()
        {
            var items = GetItems();

            return items.Where(i => !i.ParentId.HasValue);
        }

        public static IEnumerable<MenuItem> GetAllMenuItem()
        {
            return GetItems();
        }


        private static IEnumerable<MenuItem> GetItems()
        {
            var items = new List<MenuItem>();

            MenuItem dashboard = new MenuItem()
            {
                Id = 1,
                Name = "Dashboard",
                CssClass = "fa-tachometer-alt ",
                Sort = 1
            };

            MenuItem layoutOptions = new MenuItem()
            {
                Id = 2,
                Name = "Layout Options",
                CssClass = "fa-th",
                Sort = 2
            };

            MenuItem charts = new MenuItem()
            {
                Id = 3,
                Name = "Charts",
                CssClass = "fa-chart-pie",
                Sort = 3
            };

            var dashboardV1 = new MenuItem()
            {
                Id = 4,
                ParentId = 1,
                Name = "Dashboard V1",
                Controller = "Dashboard",
                DefaultAction = "Index",
                Sort = 1
            };
            dashboard.SubItems.Add(dashboardV1);

            var dashboardV2 = new MenuItem()
            {
                Id = 5,
                ParentId = 1,
                Name = "Dashboard V2",
                Controller = "Dashboard",
                DefaultAction = "Index2",
                Sort = 2
            };
            dashboard.SubItems.Add(dashboardV2);

            items.Add(dashboard);
            items.Add(layoutOptions);
            items.Add(charts);
            items.Add(dashboardV1);
            items.Add(dashboardV1);


            return items;
        }
    }
}