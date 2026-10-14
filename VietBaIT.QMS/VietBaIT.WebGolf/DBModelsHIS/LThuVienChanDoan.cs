using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LThuVienChanDoan
    {
        public int Id { get; set; }
        public string BenhChinh { get; set; }
        public string BenhPhu { get; set; }
        public string ChanDoan { get; set; }
        public int? ParentId { get; set; }
        public string ObjectTypeCode { get; set; }
        public int? ServiceId { get; set; }
        public int? ServiceDetailId { get; set; }
        public int? StaffId { get; set; }
        public int? DepartmentId { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string KetLuan { get; set; }
        public string KieuCode { get; set; }
        public int? Quantity { get; set; }
    }
}
