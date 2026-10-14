using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using VietBaIT.WebGolf.APIHelpers;
using VietBaIT.WebGolf.APIModels;
using VietBaIT.WebGolf.DBModels;
using VietBaIT.WebGolf.Helper;

namespace VietBaIT.WebGolf.Controllers
{
    public class FunctionController : Controller
    {
        private SMLink_HaDongContext _dbcontext = new SMLink_HaDongContext();
        private readonly AppSettings _appSettings;
        public FunctionController(IOptions<AppSettings> appSettings, IHttpContextAccessor httpContextAccessor)
        {
            _appSettings = appSettings.Value;
           /* var _phoneNumber = TokenHelpers.JWTTokenGetPhoneNumber(_appSettings.Secret, httpContextAccessor.HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last());*/
            /*LUser user = _dbcontext.LUser.FirstOrDefault(x => x.SoDienThoai == _phoneNumber);*/
        }
       
        // Lấy danh sách dịch vụ
        [HttpGet("/function/getListService")]
        public IActionResult GetListFucntion()
        {
            try
            {
                var functions = _dbcontext.LServiceListV2.Select(x => x);

                return Ok(new APIResponse(true, string.Empty, functions));
            }
            catch (Exception ex)
            {
                return BadRequest(new APIResponse(false, ex.Message, ""));
            }
        }
        // Lấy danh sách dịch vụ theo user
        [HttpGet("/function/ListServicebyUser")]
        public IActionResult getListServicebyUser(int userIDInfor)
        {
            try
            {
                var ds = SPHelper.ExecuteStoredProcedure(
                    globalValue.ConnectionString,
                    "getListServicebyUser", userIDInfor
                    );

                return Ok(new
                {
                    success = true,
                    message = string.Empty,
                    data = ds
                });
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    message = e.Message
                });
            }
        }

        // Lấy danh sách user
        [HttpGet("/function/getListUser")]
        public IActionResult GetListUser()
        {
            try
            {
                var functions = _dbcontext.LUser.Select(x => x);

                return Ok(new APIResponse(true, string.Empty, functions));
            }
            catch (Exception ex)
            {
                return BadRequest(new APIResponse(false, ex.Message, ""));
            }
        }
    }
}
