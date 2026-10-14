using Microsoft.AspNetCore.Http;
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
    public class UserController : Controller
    {
        private SMLink_HaDongContext _dbcontext = new SMLink_HaDongContext();
        private readonly AppSettings _appSettings;
        private readonly string _phoneNumber;
        private readonly LUser _currentUser;

        public UserController(IOptions<AppSettings> appSettings, IHttpContextAccessor httpContextAccessor)
        {
            _appSettings = appSettings.Value;
            /*_phoneNumber = TokenHelpers.JWTTokenGetPhoneNumber(_appSettings.Secret, httpContextAccessor.HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last());*/
            _currentUser = _dbcontext.LUser.FirstOrDefault(x => x.SoDienThoai == _phoneNumber);
            
        }


        //Quên mật khẩu
        [HttpPut("/user/changePassword")]
        public IActionResult ChangePassword(UserModelChangePassword changePassword)
        {
            try
            {
                LUser user = _currentUser;

                if (user.Password != changePassword.CurrentPassword)
                {
                    return BadRequest(new APIResponse(false, "Password is incorrect.", ""));
                }
                else
                {
                    user.Password = changePassword.NewPassword;
                }

                _dbcontext.LUser.Update(user);
                _dbcontext.SaveChanges();

                return Ok(new APIResponse(true, string.Empty, user));
            }
            catch (Exception ex)
            {
                return BadRequest(new APIResponse(false, ex.Message, ""));
            }
        }
        // Tạo tài khoản người dùng
        [HttpPost("/register/new")]
        public IActionResult AddNewCustomer([FromBody] CustomerUser newCustomer)
        {
            try
            {
                LUser isExistStaff = _dbcontext.LUser.FirstOrDefault(x => x.SoDienThoai == newCustomer.PhoneNumber);

                if (isExistStaff != null) return BadRequest(new APIResponse(false, "PhoneNumber is used", ""));
                LUser customer = new LUser
                {
                    HoTen = newCustomer.FullName,
                    SoDienThoai = newCustomer.PhoneNumber,
                    Password = newCustomer.Password,
                    GioiTinh = newCustomer.Gender,
                    NgaySinh = newCustomer.DateOfBirth,
                    DiaChi = newCustomer.AddressDetail,
                    Email = newCustomer.Email,
                    TrangThai = true,
                };
                _dbcontext.LUser.Add(customer);
                _dbcontext.SaveChanges();

                return Ok(new APIResponse(true, string.Empty, customer));
            }
            catch (Exception ex)
            {
                return BadRequest(new APIResponse(false, ex.Message, ""));
            }
        }

        // Cập nhật thông tin người dùng 
        [HttpPut("/user/update")]
        public IActionResult UpdateUserInfo([FromBody] UserModelUpdate updateUser)
        {
            try
            {
                LUser user = _dbcontext.LUser.FirstOrDefault(x => x.SoDienThoai == updateUser.PhoneNumber);

                if (user == null) return BadRequest(new APIResponse(false, "User not found", ""));

                user.HoTen = updateUser.FullName;
                user.GioiTinh = updateUser.Gender;
                user.NgaySinh = (DateTime)updateUser.DateOfBirth;
                user.DiaChi = updateUser.AddressDetail;
                user.Email = updateUser.Email;

                _dbcontext.LUser.Update(user);
                _dbcontext.SaveChanges();

                return Ok(new APIResponse(true, string.Empty, user));
            }
            catch (Exception ex)
            {
                return BadRequest(new APIResponse(false, ex.Message, ""));
            }
        }
    }
}
