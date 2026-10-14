using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewChiphiNoiTru
    {
        public int PaymentTypeId { get; set; }
        public byte? TrongGoi { get; set; }
        public byte? IsPayment { get; set; }
        public int NoiTru { get; set; }
        public long IdPhieu { get; set; }
        public long IdPhieuCt { get; set; }
        public int XacNhan { get; set; }
        public byte? PaymentStatus { get; set; }
        public int? IdDvu { get; set; }
        public decimal DonGia { get; set; }
        public decimal PhuThu { get; set; }
        public double? SoLuong { get; set; }
        public string TenDvu { get; set; }
        public string TenHienThi { get; set; }
        public string UnitName { get; set; }
        public int? IdLoaiDvu { get; set; }
        public int DaThien { get; set; }
        public DateTime? NgayDky { get; set; }
        public short? IdKhoaCdinh { get; set; }
        public short? IdBsyCdinh { get; set; }
        public string PatientCode { get; set; }
        public long? PatientId { get; set; }
        public int? PaymentId { get; set; }
    }
}
