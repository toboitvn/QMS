using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TKskLaixe
    {
        public int IdKsk { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public int? RegId { get; set; }
        public int? ExamId { get; set; }
        public string Sokham { get; set; }
        public DateTime Ngaykham { get; set; }
        public string Hangbanglai { get; set; }
        public decimal? Nongdocon { get; set; }
        public string Dvinongdocon { get; set; }
        public string Matuy { get; set; }
        public string Ketluan { get; set; }
        public DateTime Ngayketluan { get; set; }
        public int IdBacsiKetluan { get; set; }
        public DateTime? Ngaykhamlai { get; set; }
        public string Lydo { get; set; }
        public string Tinhtrangbenh { get; set; }
        public string Signdata { get; set; }
        public int? Dagui { get; set; }
        public DateTime? Ngaygui { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
    }
}
