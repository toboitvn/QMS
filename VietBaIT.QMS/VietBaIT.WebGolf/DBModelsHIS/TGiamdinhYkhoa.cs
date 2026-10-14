using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TGiamdinhYkhoa
    {
        public long IdGiamdinh { get; set; }
        public string NguoiChuTri { get; set; }
        public int? ChucVu { get; set; }
        public DateTime? NgayHop { get; set; }
        public string MaDoituong { get; set; }
        public int? KhamGiamDinh { get; set; }
        public string SoBienBan { get; set; }
        public int? TyleTtctCu { get; set; }
        public string DangHuongCheDo { get; set; }
        public DateTime? NgayChungTu { get; set; }
        public string SoGiayGioiThieu { get; set; }
        public DateTime? NgayDeNghi { get; set; }
        public string MaDonvi { get; set; }
        public string GioiThieuCua { get; set; }
        public string KetQuaKham { get; set; }
        public string SoVanBanCanCu { get; set; }
        public int? TyleTtctMoi { get; set; }
        public int? TongTyleTtct { get; set; }
        public int? DangKhuyettat { get; set; }
        public int? MucDoKhuyettat { get; set; }
        public string Denghi { get; set; }
        public string DuocXacdinh { get; set; }
        public string DuPhong { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string PatientCode { get; set; }
        public long? PatientId { get; set; }
        public int? Trangthai { get; set; }
        public string Lydohuy { get; set; }
        public DateTime? NgayHuy { get; set; }
        public string NguoiHuy { get; set; }
    }
}
