using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TPhieuthu
    {
        public string MaPthu { get; set; }
        public long PaymentId { get; set; }
        public DateTime NgayThien { get; set; }
        public string NguoiNop { get; set; }
        public string LdoNop { get; set; }
        public decimal SoTien { get; set; }
        public decimal? TienMat { get; set; }
        public decimal? TienCaThe { get; set; }
        public decimal? TienCno { get; set; }
        public short? SluongCtuGoc { get; set; }
        public string TkhoanNo { get; set; }
        public string TkhoanCo { get; set; }
        public byte? LoaiPhieu { get; set; }
        public short? IdNhanVien { get; set; }
        public short? IdKhoa { get; set; }
        public string IpMaySua { get; set; }
        public string IpMayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public decimal? TienChuyenKhoan { get; set; }
    }
}
