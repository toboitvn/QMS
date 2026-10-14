using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VietBaIT.WebGolf.APIHelpers;
using VietBaIT.WebGolf.APIModels;
using VietBaIT.WebGolf.DBModels;

namespace VietBaIT.WebGolf.Controllers
{
    public class ForgotPasswordController : Controller
    {
        private readonly AppSettings _appSettings;
        private SMLink_HaDongContext _dbcontext = new SMLink_HaDongContext();

        public ForgotPasswordController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }
        // Quên mật khẩu
        [HttpPut("/forgotPassword")]
        public IActionResult ForgotPassword(UserModelForgotPassword forgotPassword)
        {
            try
            {
                LUser user = _dbcontext.LUser.FirstOrDefault(x => x.Username == forgotPassword.PhoneNumber);

                if (user == null) BadRequest(new APIResponse(false, "User not found.", ""));

                user.Password = forgotPassword.NewPasword;

                _dbcontext.LUser.Update(user);
                _dbcontext.SaveChanges();

                return Ok(new APIResponse(true, "", ""));
            }
            catch (Exception ex)
            {
                return BadRequest(new APIResponse(false, ex.Message, ""));
            }
        }
    }
}
