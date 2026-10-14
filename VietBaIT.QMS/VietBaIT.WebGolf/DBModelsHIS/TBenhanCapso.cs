using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TBenhanCapso
    {
        public int IdBenhan { get; set; }
        public string LoaiBenhan { get; set; }
        public string MaBenhan { get; set; }
        public string SoBenhan { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public DateTime? NgayKham { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? DieutriTungay { get; set; }
        public DateTime? DieutriDenngay { get; set; }
        public string ViTri { get; set; }
        public byte? TrangThai { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string NguoiKetThuc { get; set; }
        public string GhiChu { get; set; }
        public string MaBa { get; set; }
        public DateTime? NgayCap { get; set; }
        public string ChanDoan { get; set; }
    }
}
