using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class DPhieuXuatBnhan
    {
        public int IdPhieuXuatBn { get; set; }
        public string MaPhieuXuatBn { get; set; }
        public DateTime? NgayXuatBn { get; set; }
        public DateTime? NgayChot { get; set; }
        public int? IdChot { get; set; }
        public DateTime? NgayKeDon { get; set; }
        public string TenBnhan { get; set; }
        public string TenKhongDau { get; set; }
        public byte? Gtinh { get; set; }
        public string ChanDoan { get; set; }
        public string MaBenh { get; set; }
        public string DiaChi { get; set; }
        public int? NamSinh { get; set; }
        public string SoThe { get; set; }
        public short? IdDoiTuong { get; set; }
        public int? IdCapphat { get; set; }
        public short? IdNhanVien { get; set; }
        public int? IdDonThuoc { get; set; }
        public short? IdKhoaCd { get; set; }
        public short? IdBsyCd { get; set; }
        public short? IdKhoXuat { get; set; }
        public byte? HienThi { get; set; }
        public byte? NoiTru { get; set; }
        public byte? LoaiDthuoc { get; set; }
        public byte? TrangThai { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public byte? LoaiPhieu { get; set; }
        public bool? DaChot { get; set; }
    }
}
