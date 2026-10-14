using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class ViewThongTinTongHopChiPhiToKhai
    {
        public int PaymentTypeId { get; set; }
        public int TrongGoi { get; set; }
        public int? IdGoiDvu { get; set; }
        public byte IsPayment { get; set; }
        public int NoiTru { get; set; }
        public long IdPhieu { get; set; }
        public long IdPhieuCt { get; set; }
        public byte XacNhan { get; set; }
        public byte? PaymentStatus { get; set; }
        public int? IdDvu { get; set; }
        public double SoLuong { get; set; }
        public string TenDvu { get; set; }
        public string TenHienThi { get; set; }
        public string UnitName { get; set; }
        public int? IdLoaiDvu { get; set; }
        public int? IdNhomCphi { get; set; }
        public byte DaThien { get; set; }
        public DateTime? NgayDky { get; set; }
        public short? IdKhoaCdinh { get; set; }
        public short? IdBsyCdinh { get; set; }
        public string PatientCode { get; set; }
        public long? PatientId { get; set; }
        public int? IdGoiVattu { get; set; }
        public int? LanGoi { get; set; }
        public int? SttIn { get; set; }
        public string Loai { get; set; }
        public long? ParentService { get; set; }
    }
}
