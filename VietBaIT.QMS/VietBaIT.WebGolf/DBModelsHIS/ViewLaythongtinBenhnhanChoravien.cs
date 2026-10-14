using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewLaythongtinBenhnhanChoravien
    {
        public int SoPhieuRavien { get; set; }
        public int? PatientId { get; set; }
        public string PatientCode { get; set; }
        public string MaBa { get; set; }
        public string BenhKemTheo { get; set; }
        public int? IdKhoaRvien { get; set; }
        public int? IdKhoaNtru { get; set; }
        public int? TrangThai { get; set; }
        public string ChanDoan { get; set; }
        public string CachDtri { get; set; }
        public string TtrangBnhanRvien { get; set; }
        public string YkienDnghi { get; set; }
        public string NxetBvien { get; set; }
        public DateTime? NgayRaVien { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string MaBenh { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgayKetthuc { get; set; }
        public string NguoiKetthuc { get; set; }
        public string LoiDanThaythuoc { get; set; }
        public string MaYte { get; set; }
        public string SoLuuTru { get; set; }
        public int? ChoPhepTtoan { get; set; }
        public string InsuranceNum { get; set; }
        public string InsClinicCode { get; set; }
        public string MedicalNumber { get; set; }
        public string MaDoiTuong { get; set; }
        public string PatientName { get; set; }
        public string PatientAddr { get; set; }
        public DateTime? PatientBirth { get; set; }
        public short? YearOfBirth { get; set; }
        public string SPatientSex { get; set; }
        public byte PatientSex { get; set; }
        public string PatientJob { get; set; }
        public string IdentifyNum { get; set; }
        public byte HosStatus { get; set; }
        public decimal? DiscountRate { get; set; }
        public string MaDtuong { get; set; }
    }
}
