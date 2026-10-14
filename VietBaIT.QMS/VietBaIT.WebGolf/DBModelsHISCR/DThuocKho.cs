using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DThuocKho
    {
        public int IdThuocKho { get; set; }
        public short IdKho { get; set; }
        public int IdThuoc { get; set; }
        public DateTime NgayHetHan { get; set; }
        public decimal DonGia { get; set; }
        public double SoLuong { get; set; }
        public decimal Vat { get; set; }
        public bool? CamSdung { get; set; }
        public string SoLo { get; set; }
        public short? IdSoQdinh { get; set; }
        public string SttQdinh { get; set; }
        public int Id { get; set; }
        public bool? ThuocChia { get; set; }
        public decimal GiaBan { get; set; }
        public decimal? GiaBhyt { get; set; }
        public decimal? PhuThu { get; set; }
        public DateTime? NgayNhapKho { get; set; }
        public string NumberRegister { get; set; }
        public short? SttBan { get; set; }
        public decimal? DonGiaTruocVat { get; set; }
        public int? IdPhieuNhap { get; set; }

        public virtual LDrugs IdThuocNavigation { get; set; }
    }
}
