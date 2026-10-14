using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TChuyenKhoaSua
    {
        public int Id { get; set; }
        public int PatientDeptId { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public short DepartmentId { get; set; }
        public short? RoomId { get; set; }
        public short? BedId { get; set; }
        public short? StaffId { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public bool IsSua { get; set; }
    }
}
