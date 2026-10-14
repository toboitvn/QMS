using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class HiepHoaChiPhiTuyenXa
    {
        public int Id { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public DateTime? NgayDky { get; set; }
        public short? IdNhomDvu { get; set; }
        public short? IdDichVu { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? PhuThu { get; set; }
        public int? SoLuong { get; set; }
        public bool? DaTt { get; set; }
        public byte? PaymentTypeId { get; set; }
        public bool? TrongGoi { get; set; }
        public int? PaymentId { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public short? PtramBhyt { get; set; }
    }
}
