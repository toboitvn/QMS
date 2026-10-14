using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewDanhSachThuNgan
    {
        public short StaffId { get; set; }
        public string StaffCode { get; set; }
        public string StaffName { get; set; }
        public short DepartmentId { get; set; }
        public int? ParentId { get; set; }
        public short StaffTypeId { get; set; }
        public short RankId { get; set; }
        public string Uid { get; set; }
        public byte? Status { get; set; }
        public string SDesc { get; set; }
        public decimal SpecMoney { get; set; }
        public byte? Actived { get; set; }
        public int? CanSign { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public byte? ChoPhepChuyenGoi { get; set; }
        public byte? ChoPhepDchinhTtoan { get; set; }
        public byte? ChoPhepHuyKhoat { get; set; }
        public byte? ChoPhepKhoat { get; set; }
        public byte? ChoPhepNvien { get; set; }
        public byte? ChoPhepNhapTheBhyt { get; set; }
        public byte? ChoPhepSuaDlieu { get; set; }
        public byte? ChoPhepChonBly { get; set; }
        public byte? ChoPhepDieuChinhBg { get; set; }
    }
}
