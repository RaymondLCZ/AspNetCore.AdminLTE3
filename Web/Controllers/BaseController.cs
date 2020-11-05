using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Zee.AspNetCore.AdminLTE3.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {

        }
    }
}