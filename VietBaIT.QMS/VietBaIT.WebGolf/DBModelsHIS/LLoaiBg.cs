using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LLoaiBg
    {
        public LLoaiBg()
        {
            LGiuongLoaiBg = new HashSet<LGiuongLoaiBg>();
        }

        public short IdLoaiBg { get; set; }
        public string MaLoaiBg { get; set; }
        public string MaBoYte { get; set; }
        public string TenLoaiBg { get; set; }
        public short? ThuTu { get; set; }
        public string KieuThue { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? PhuThuTrongGoi { get; set; }
        public decimal? PhuThuNgoaigoi { get; set; }
        public string GhiChu { get; set; }
        public string MaDtuong { get; set; }
        public bool? HienThi { get; set; }
        public string TenHienThi { get; set; }
        public decimal? DongiaBh { get; set; }
        public decimal? DongiaBhTt { get; set; }
        public decimal? PhuThuBhTt { get; set; }
        public short? IdNhomCphi { get; set; }
        public decimal? GiaCu { get; set; }
        public DateTime? NgaySua { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public string NguoiTao { get; set; }
        public string MaBhyt { get; set; }

        public virtual ICollection<LGiuongLoaiBg> LGiuongLoaiBg { get; set; }
    }
}
