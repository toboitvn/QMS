using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class ViewNhomBacSy
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
        public string AssignKhoa { get; set; }
    }
}
