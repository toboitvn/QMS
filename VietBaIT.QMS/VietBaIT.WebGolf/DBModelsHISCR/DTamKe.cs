using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DTamKe
    {
        public long Id { get; set; }
        public short IdKho { get; set; }
        public int IdThuocKho { get; set; }
        public int IdThuoc { get; set; }
        public double SoLuong { get; set; }
        public int IdPhieuCt { get; set; }
        public int? IdPhieu { get; set; }
        public byte Loai { get; set; }
        public string GuidKey { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string PatientCode { get; set; }
        public int? PatientId { get; set; }
        public byte? NoiTru { get; set; }
        public bool? TrangThai { get; set; }
        public string IpMay { get; set; }
    }
}
