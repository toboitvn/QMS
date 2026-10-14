using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LStaffType
    {
        public short StaffTypeId { get; set; }
        public string StaffTypeCode { get; set; }
        public string StaffTypeName { get; set; }
        public short IntOrder { get; set; }
        public string SDesc { get; set; }
        public string StaffTypeTypeId { get; set; }
        public string MaNhom { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
    }
}
