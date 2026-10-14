using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class LDepartments
    {
        public short DepartmentId { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public short? ParentId { get; set; }
        public byte Speciality { get; set; }
        public short IntOrder { get; set; }
        public string SDesc { get; set; }
        public int? DeptType { get; set; }
        public decimal? DeptFee { get; set; }
        public string LoaiTamUng { get; set; }
        public decimal? TienTamUng { get; set; }
        public string KieuKphong { get; set; }
        public int? KhoaCapcuu { get; set; }
        public string LoaiKhoa { get; set; }
        public int? UnitId { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string PhongThien { get; set; }
        public string MaPhongStt { get; set; }
        public byte? HienThi { get; set; }
    }
}
