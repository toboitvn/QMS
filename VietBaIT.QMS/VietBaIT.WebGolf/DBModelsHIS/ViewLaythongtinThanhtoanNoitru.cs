using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewLaythongtinThanhtoanNoitru
    {
        public int PaymentId { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int IdBenhly { get; set; }
        public string MaDtuong { get; set; }
        public int IdGoiDvu { get; set; }
        public decimal SoTienGoi { get; set; }
        public decimal? TongDongia { get; set; }
        public decimal? TongPhuthu { get; set; }
        public decimal? TongBhct { get; set; }
        public decimal? TongBnct { get; set; }
        public decimal? TongTamung { get; set; }
        public decimal? TongBnPtra { get; set; }
        public decimal? SoTienTraLai { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public int KieuPhieu { get; set; }
        public int? DaTraLaitien { get; set; }
        public decimal? TongTutuc { get; set; }
        public string TenBn { get; set; }
        public short? NamSinh { get; set; }
        public string MaDoiTuong { get; set; }
    }
}
