using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class QlpdDangkySudung
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public int IdPhacdo { get; set; }
        public int IdKhoa { get; set; }
        public string MaBenh { get; set; }
        public int? IdBacsyDtri { get; set; }
        public string MaLoaiKcb { get; set; }
        public bool? TrangThai { get; set; }
        public string GhiChu { get; set; }
        public string DanhGia { get; set; }
        public string KetQua { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string IpMacTao { get; set; }
        public string IpMayTao { get; set; }
        public string IpMacSua { get; set; }
        public string IpMaySua { get; set; }
    }
}
