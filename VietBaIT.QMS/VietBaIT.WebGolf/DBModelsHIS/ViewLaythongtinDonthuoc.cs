using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewLaythongtinDonthuoc
    {
        public int? TreatId { get; set; }
        public int? PatientDeptId { get; set; }
        public int? ReplacePresId { get; set; }
        public long? ExamId { get; set; }
        public int? PatientId { get; set; }
        public string PatientCode { get; set; }
        public DateTime PresDate { get; set; }
        public int IsLocked { get; set; }
        public short? AssignId { get; set; }
        public byte Status { get; set; }
        public string SExpireDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string PresName { get; set; }
        public string PresCode { get; set; }
        public short? LoaiDonthuoc { get; set; }
        public int? AssginDetailId { get; set; }
        public byte? PreHos { get; set; }
        public byte? PresType { get; set; }
        public bool TheoDoi { get; set; }
        public double? Thanhtien { get; set; }
        public double? Tt { get; set; }
        public string InsuranceNum { get; set; }
        public int PresDetailId { get; set; }
        public int PresId { get; set; }
        public int DrugId { get; set; }
        public DateTime ExpireDate { get; set; }
        public double? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? SurchargePrice { get; set; }
        public string SDesc { get; set; }
        public byte? PaymentStatus { get; set; }
        public int? QuantityCancel { get; set; }
        public byte? IsCancel { get; set; }
        public DateTime? PaymentDate { get; set; }
        public byte? IsPayment { get; set; }
        public int? StockId { get; set; }
        public byte? HasComfirm { get; set; }
        public byte? BhytStatus { get; set; }
        public short? ThuTuIn { get; set; }
        public decimal? GiaBhytCt { get; set; }
        public decimal? GiaBnct { get; set; }
        public string MaDtuong { get; set; }
        public int? PaymentId { get; set; }
        public byte? XacNhan { get; set; }
        public byte TrongGoi { get; set; }
        public string CachDung { get; set; }
        public string ChiDanThem { get; set; }
        public string DviDung { get; set; }
        public string SoLanDung { get; set; }
        public double? SluongSua { get; set; }
        public double? SluongLinh { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string SoLuongDung { get; set; }
        public string DrugCode { get; set; }
        public string Active { get; set; }
        public string DrugName { get; set; }
        public string HamLuong { get; set; }
        public short? DrugTypeId { get; set; }
        public string DrugTypeName { get; set; }
        public short? UnitId { get; set; }
        public string UnitName { get; set; }
        public string DoctorName { get; set; }
        public string InputUserName { get; set; }
        public string SPresDate { get; set; }
        public string DrugTypeCode { get; set; }
        public int? IdGoiDvu { get; set; }
        public string KieuDonthuoc { get; set; }
    }
}
