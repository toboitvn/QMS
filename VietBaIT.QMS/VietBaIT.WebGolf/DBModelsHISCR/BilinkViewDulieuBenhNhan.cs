using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class BilinkViewDulieuBenhNhan
    {
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public string MaLoaiKcb { get; set; }
        public string MaDoiTuong { get; set; }
        public short ObjectTypeId { get; set; }
        public byte HosStatus { get; set; }
        public byte? ThopStatus { get; set; }
        public DateTime? NgayNhapVien { get; set; }
        public int? IdKhoanhapvien { get; set; }
        public string KhoaNhapvien { get; set; }
        public DateTime? NgayRaVien { get; set; }
        public int? IdKhoaRvien { get; set; }
        public int? IdKhoaDangdieutri { get; set; }
        public string KhoaDangdieutri { get; set; }
        public string KhoaRavien { get; set; }
        public short? IdKetQuaDtri { get; set; }
        public string KetquaDieutri { get; set; }
        public int? IdNoiBvienCden { get; set; }
        public short? IdTtrangRavien { get; set; }
        public string RavienMaLoaiKcb { get; set; }
    }
}
