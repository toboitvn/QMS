using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using VietBaIT.WebGolf.APIHelpers;
using VietBaIT.WebGolf.DBModels;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeAttribute : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        /*var user = (LmtnNhanvien) context.HttpContext.Items["Staff"];
        if (user == null)
        {
            context.Result = new JsonResult(new APIResponse(false, "Account not found", ""));
        }*/
    }
}