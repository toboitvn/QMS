using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class PmDonXinPhauThuat
    {
        public int IdPhongMo { get; set; }
        public DateTime? NgayLamDon { get; set; }
        public string NguoiLamDon { get; set; }
        public string DiaChi { get; set; }
        public string QuanHe { get; set; }
        public string NoiDung { get; set; }
        public bool? XacNhanBndaKy { get; set; }
        public string Namsinh { get; set; }
        public string Gioitinh { get; set; }
        public string Socmt { get; set; }
        public string Sodt { get; set; }
        public string Tenbenhnhan { get; set; }
        public string Tinhtrangbenhcua { get; set; }
        public string Canthiepngoaikhoa { get; set; }
        public string Moibstuvan { get; set; }
    }
}
