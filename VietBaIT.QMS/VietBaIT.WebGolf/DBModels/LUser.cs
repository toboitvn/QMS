using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class LUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string HoTen { get; set; }
        public string Password { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public byte GioiTinh { get; set; }
        public bool TrangThai { get; set; }
    }
}
