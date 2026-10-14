using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TMienGiamThanhtoan
    {
        public int IdCkhau { get; set; }
        public string PatientCode { get; set; }
        public int? PatientId { get; set; }
        public short? IdNhanvien { get; set; }
        public DateTime? NgayCkhau { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public decimal? SoTienCkhau { get; set; }
        public byte? NoiTru { get; set; }
        public byte? HienThi { get; set; }
        public int? PkIdCkhau { get; set; }
        public string LyDo { get; set; }
        public int? PaymentId { get; set; }
        public string KieuMg { get; set; }
        public string NguoiKyMg { get; set; }
        public decimal? PtramMg { get; set; }
        public int? IdUudai { get; set; }
    }
}
