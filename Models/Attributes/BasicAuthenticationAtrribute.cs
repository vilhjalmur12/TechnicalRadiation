using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using Microsoft.AspNetCore.Mvc.Filters;
using TechnicalRadiation.Models.Exceptions;

namespace TechnicalRadiation.Models.Attributes
{
    public class BasicAuthenticationAtrribute : ActionFilterAttribute
    {
        private string validValue = "Admin";

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var req = filterContext.HttpContext.Request;
            var auth = req.Headers["Authorization"];
            if(String.IsNullOrEmpty(auth))
            {
                var cred = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(auth));
                if(cred == validValue)
                    return;
            }
            else {
                throw new ResourceNotFoundException();
                //filterContext.Result = new HttpUnauthorizedResult();
            }
        }
    }
}