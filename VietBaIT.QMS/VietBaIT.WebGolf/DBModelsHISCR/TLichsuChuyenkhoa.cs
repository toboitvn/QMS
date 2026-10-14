using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TLichsuChuyenkhoa
    {
        public int TranferId { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public DateTime TranferDate { get; set; }
        public int FromTranferId { get; set; }
        public short FromDepartmentId { get; set; }
        public int FromPatientDeptId { get; set; }
        public short? FromRoomId { get; set; }
        public short? FromBedId { get; set; }
        public short ToDepartmentId { get; set; }
        public int ToPatientDeptId { get; set; }
        public short? StaffId { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public bool Status { get; set; }
        public bool TranferCancel { get; set; }
        public DateTime? NgayNhapKhoa { get; set; }
    }
}
