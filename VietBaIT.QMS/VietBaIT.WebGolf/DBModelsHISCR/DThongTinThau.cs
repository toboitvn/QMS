using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DThongTinThau
    {
        public int IdThau { get; set; }
        public string LoaiThau { get; set; }
        public string NhomThau { get; set; }
        public string GoiThau { get; set; }
        public string SoThau { get; set; }
        public DateTime NgayThau { get; set; }
        public string SoQdinh { get; set; }
        public DateTime NgayQdinh { get; set; }
        public short? IdNhaCcap { get; set; }
        public string MaNhaCcap { get; set; }
        public string GhiChu { get; set; }
        public byte? DaXacNhan { get; set; }
        public byte? TrangThai { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string NguoiXacNhan { get; set; }
        public DateTime? NgayXacNhan { get; set; }
        public bool? DieuTiet { get; set; }
        public int? VienDieuTiet { get; set; }
        public string SohdDieutiet { get; set; }
        public DateTime? NgayhdDieutiet { get; set; }
        public DateTime? NgayktDieutiet { get; set; }
        public int? HtThau { get; set; }
        public int? BophanDung { get; set; }
        public DateTime? NgaythauDen { get; set; }
        public DateTime? NgayqdDen { get; set; }
        public string KieuThuocVt { get; set; }
    }
}
