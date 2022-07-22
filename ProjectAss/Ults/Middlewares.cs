using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using ProjectAss.Models;
using System;
using System.Linq;

namespace ProjectAss.Ults
{
    public class Middlewares : ActionFilterAttribute
    {

        public override void OnActionExecuted(ActionExecutedContext context) { }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            try
            {
                var dtb = new prj_prnContext();
                string curUserJson = context.HttpContext.Session.GetString("admin");
                Tblemployee curUser = JsonConvert.DeserializeObject<Tblemployee>(curUserJson);
                bool isAccess = dtb.Tblemployees.FirstOrDefault(x => x.Username.ToLower().Equals(curUser.Username.ToLower())
                && x.Password.Equals(curUser.Password)) != null;
                if (!isAccess)
                {
                    context.HttpContext.Session.Remove("admin");
                    context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Acount", action = "Login" }));
                    return;
                }
            }
            catch (Exception e)
            {
                context.HttpContext.Session.Remove("admin");
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Acount", action = "Login" }));
                return;
            }
            base.OnActionExecuting(context);
        }
    }
}
