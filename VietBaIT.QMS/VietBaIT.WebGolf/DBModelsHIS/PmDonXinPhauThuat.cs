using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
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
    }
}
