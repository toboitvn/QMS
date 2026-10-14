using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class ViewThongTinTongHopBaoCao
    {
        public int PaymentTypeId { get; set; }
        public long? PatientId { get; set; }
        public string PatientCode { get; set; }
        public long Id { get; set; }
        public long IdDetail { get; set; }
        public decimal? OriginPrice { get; set; }
        public decimal? DongiaTralai { get; set; }
        public decimal? SurchargePrice { get; set; }
        public decimal? PhuthuTralai { get; set; }
        public double? Quantity { get; set; }
        public double? Soluong { get; set; }
        public double? SoluongTralai { get; set; }
        public double? Soluongthuc { get; set; }
        public int? ServiceId { get; set; }
        public int? ServiceDetailId { get; set; }
        public string MaBoYte { get; set; }
        public string MaGia { get; set; }
        public string ServiceDetailName { get; set; }
        public string TenHienThi { get; set; }
        public string DonViTinh { get; set; }
        public short? DoctorId { get; set; }
        public short? DepartmentId { get; set; }
        public short? IdDonviTructhuoc { get; set; }
        public byte? PaymentStatus { get; set; }
        public int? PaymentId { get; set; }
        public byte IsPayment { get; set; }
        public DateTime? NgayDky { get; set; }
        public DateTime? PaymentDate { get; set; }
        public byte NoiTru { get; set; }
        public int? TrongGoi { get; set; }
        public byte? IsCancel { get; set; }
        public int? XacNhan { get; set; }
        public int? DaThien { get; set; }
        public string MaCoSo { get; set; }
        public string SDesc { get; set; }
        public int? CamGuiXml { get; set; }
        public string NguoiTao { get; set; }
        public long IdThe { get; set; }
        public decimal TyleTt { get; set; }
        public decimal? MienGiam { get; set; }
        public string NhomBaocao { get; set; }
        public int? KieuThanhToan { get; set; }
    }
}
