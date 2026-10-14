using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewTimKiemPhatThuocTaiKho
    {
        public int PresId { get; set; }
        public int? TreatId { get; set; }
        public int? PatientDeptId { get; set; }
        public int? ReplacePresId { get; set; }
        public long? ExamId { get; set; }
        public int? PatientId { get; set; }
        public string PatientCode { get; set; }
        public DateTime PresDate { get; set; }
        public short? AssignId { get; set; }
        public byte Status { get; set; }
        public byte PaymentStatus { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string SDesc { get; set; }
        public string PresName { get; set; }
        public string PresCode { get; set; }
        public byte? PreHos { get; set; }
        public byte? PresType { get; set; }
        public short? DepartmentId { get; set; }
        public short? RoomId { get; set; }
        public short? BedId { get; set; }
        public byte? PresStatus { get; set; }
        public string KieuDonthuoc { get; set; }
        public string LoiDanBsy { get; set; }
        public DateTime? NgayTaiKham { get; set; }
        public string TaiKham { get; set; }
        public string MaKhoaThien { get; set; }
        public byte? KeDonTquay { get; set; }
        public string PatientName { get; set; }
        public string PatientAddr { get; set; }
        public string ProvinceId { get; set; }
        public string DistrictId { get; set; }
        public DateTime? PatientBirth { get; set; }
        public short? YearOfBirth { get; set; }
        public byte PatientSex { get; set; }
        public string PatientJob { get; set; }
        public string Offices { get; set; }
        public string TenKhongDau { get; set; }
        public string IdentifyNum { get; set; }
        public short ObjectTypeId { get; set; }
        public string InsuranceNum { get; set; }
        public string MaDoiTuong { get; set; }
        public string SPresDate { get; set; }
        public int? Age { get; set; }
        public string MaDtuong { get; set; }
        public string StaffName { get; set; }
        public string DepartmentName { get; set; }
        public short? StockId { get; set; }
        public string StockName { get; set; }
        public int? PaymentId { get; set; }
        public string HtThanhtoan { get; set; }
        public string MaLoaiKcb { get; set; }
    }
}
