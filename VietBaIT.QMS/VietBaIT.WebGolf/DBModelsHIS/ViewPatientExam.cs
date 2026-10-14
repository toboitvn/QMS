using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewPatientExam
    {
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public short ObjectTypeId { get; set; }
        public byte HosTrans { get; set; }
        public string RelativeName { get; set; }
        public string RelativePhone { get; set; }
        public string RelativeAddress { get; set; }
        public string InsuranceNum { get; set; }
        public DateTime? InsuranceFromDate { get; set; }
        public DateTime? InsuranceToDate { get; set; }
        public string InsuranceSupply { get; set; }
        public string InsClinicCode { get; set; }
        public string InsObjectCode { get; set; }
        public int? InsObjectCodeNumber { get; set; }
        public string InsObjectCodeTp { get; set; }
        public string InsLastObjectCode { get; set; }
        public DateTime InputDate { get; set; }
        public string UserId { get; set; }
        public byte HosStatus { get; set; }
        public decimal? DiscountRate { get; set; }
        public byte? Locked { get; set; }
        public long? IndentityNo { get; set; }
        public DateTime? OutDateTime { get; set; }
        public int? DepartmentId { get; set; }
        public decimal? SalaryBasic { get; set; }
        public short? RoomId { get; set; }
        public short? BedId { get; set; }
        public int? RankId { get; set; }
        public int? UnitId { get; set; }
        public int? EmergencyHos { get; set; }
        public int? ToHos { get; set; }
        public string PositionName { get; set; }
        public string Symptoms { get; set; }
        public byte? CorrectLine { get; set; }
        public int? FromClinicStatus { get; set; }
        public string ToClinicCode { get; set; }
        public string MbenhChinh { get; set; }
        public string MbenhPhu { get; set; }
        public string ChanDoanPhu { get; set; }
        public string ChanDoanChinh { get; set; }
        public byte? TinhTrangRaVienStatus { get; set; }
        public string GhiChuCv { get; set; }
        public string MedicalNumber { get; set; }
        public int? TongSoNgayDtri { get; set; }
        public string MaDoiTuong { get; set; }
        public string MaDtSsong { get; set; }
        public byte? ThopStatus { get; set; }
        public byte? KieuBn { get; set; }
        public bool? BoVien { get; set; }
        public short? PtramBhytDthe { get; set; }
        public DateTime? NgayKthuc { get; set; }
        public DateTime? NgayNhapVien { get; set; }
        public DateTime? NgayRaVien { get; set; }
        public bool? TuyenXa { get; set; }
        public DateTime? NgayTao { get; set; }
        public bool? KhoaTheBhyt { get; set; }
        public string SoBhyt { get; set; }
        public string MaTinh { get; set; }
        public int? IdRavien { get; set; }
        public string MaKhoaThien { get; set; }
        public string MaDkkcb { get; set; }
        public string MaCoSo { get; set; }
        public bool GuiXml { get; set; }
        public string NguonGthieu { get; set; }
        public string MaNguon { get; set; }
        public bool? GiayBhyt { get; set; }
        public DateTime? NgayDu5nam { get; set; }
        public short? IdBenhVienChuyen { get; set; }
        public short? LoaiTuoi { get; set; }
        public string Tuoi { get; set; }
        public long? IdThe { get; set; }
        public int? MaLydoVv { get; set; }
        public bool? DeleteStatus { get; set; }
        public string MaLoaiKcb { get; set; }
        public int? MaLydoVvien { get; set; }
        public string ThongBao { get; set; }
        public int Thongtuyen { get; set; }
        public byte? NoThe { get; set; }
        public string CdoanTtruoc { get; set; }
        public short? IdBacsiDieutri { get; set; }
    }
}
