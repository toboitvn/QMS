using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LExamTypeObjDepartDoctorRelation
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public short ExamTypeId { get; set; }
        public short DepartmentId { get; set; }
        public short DoctorId { get; set; }
        public short ObjectTypeId { get; set; }
        public short RoomDept { get; set; }
        public decimal Price { get; set; }
        public decimal? Surcharge { get; set; }
        public string MaDtuong { get; set; }
        public int? ThuTu { get; set; }
        public byte? IsPayment { get; set; }
        public int? IdPhiKtheo { get; set; }
        public int? IdPhiKtheoNgio { get; set; }
        public string GhiChu { get; set; }
        public decimal? DonGiaNgio { get; set; }
        public decimal? PhuThuNgio { get; set; }
        public bool? HienThi { get; set; }
        public string MaBoYte { get; set; }
        public bool? GoiKemTheo { get; set; }
        public short? IdNhomCphi { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string TenBhyt { get; set; }
        public string MaBhyt { get; set; }
        public short? IdLanKham { get; set; }
        public bool? QmsHienThi { get; set; }
        public string MauPhieu { get; set; }
        public string MaLoaiKcb { get; set; }
        public string BanKham { get; set; }
        public string MaKhoa { get; set; }
        public int? Ldlk { get; set; }
        public int? LienKhoa { get; set; }
        public bool? GuiAx { get; set; }
    }
}
