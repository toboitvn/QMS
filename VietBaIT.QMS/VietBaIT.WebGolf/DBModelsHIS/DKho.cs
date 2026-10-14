using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class DKho
    {
        public DKho()
        {
            DKiemKe = new HashSet<DKiemKe>();
            TPrescriptionDetail = new HashSet<TPrescriptionDetail>();
        }

        public short IdKho { get; set; }
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public int? ThuTu { get; set; }
        public byte? KieuKho { get; set; }
        public string LoaiKho { get; set; }
        public string ThuKho { get; set; }
        public short IdKhoa { get; set; }
        public string GhiChu { get; set; }
        public byte? KhoBan { get; set; }
        public byte? KtraTon { get; set; }
        public DateTime? NgaySua { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public string NguoiTao { get; set; }
        public byte? LaTuthuoc { get; set; }
        public string LoaiBnhan { get; set; }
        public byte? HienThi { get; set; }
        public bool? IsThuocHetHan { get; set; }
        public bool? IsKeDonThuoc { get; set; }
        public bool? IsKhoNhap { get; set; }
        public bool? XuatTuTruc { get; set; }
        public string MaCoSo { get; set; }
        public byte? Khongtinhgia { get; set; }
        public string KieuXuat { get; set; }
        public bool? HienthiGiaban { get; set; }
        public byte? ChophepKele { get; set; }
        public double? SongayNhaton { get; set; }

        public virtual ICollection<DKiemKe> DKiemKe { get; set; }
        public virtual ICollection<TPrescriptionDetail> TPrescriptionDetail { get; set; }
    }
}
