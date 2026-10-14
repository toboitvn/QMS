using VietBaIT.WebGolf.DBModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VietBaIT.WebGolf.APIModels;
using Microsoft.Extensions.Options;
using VietBaIT.WebGolf.APIHelpers;

namespace VietBaIT.WebGolf.Controllers
{
    [ApiController]
    public class LoginController : Controller
    {
        private readonly AppSettings _appSettings;
        private SMLink_HaDongContext _dbcontext = new SMLink_HaDongContext();

        public LoginController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [HttpPost("/login")]
        public IActionResult Login([FromBody] LoginModel model)
        {

            try
            {

                // lấy thông tin người dùng theo số điện thoại
                LUser user = _dbcontext.LUser.FirstOrDefault(x => x.Username == model.PhoneNumber);
                if (user == null )
                    return BadRequest(new APIResponse(false, "Tên đăng nhập hoặc mật khẩu không chính xác", ""));

               /* byte[] passwordHash, passwordSalt;
                HashPassword(model.Password, out passwordHash, out passwordSalt);
                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;*/
                /*_dbcontext.SaveChanges();*/

                /*if (!VerifyPasswordHash(model.Password, user.PasswordHash, user.PasswordSalt))
                    return BadRequest(new APIResponse(false, "password incorrect", ""));*/

                /*if (!user.Danghoatdong) return BadRequest(new APIResponse(false, "account inactive", ""));*/

                user.Password = null;

                var result = new
                {
                    user = user,
                    token = TokenHelpers.generateJWTToken(_appSettings.Secret, user.Username)
                };
                return Ok(new APIResponse(true, "", result));
            }
            catch (Exception ex)
            {
                return BadRequest(new APIResponse(false, ex.Message, ""));
            }
        }

        private static void HashPassword(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
            if (storedHash.Length != 64) throw new ArgumentException("Invalid length of password hash (64 bytes expected).", "passwordHash");
            if (storedSalt.Length != 128) throw new ArgumentException("Invalid length of password salt (128 bytes expected).", "passwordHash");

            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }

            return true;
        }
    }
}
