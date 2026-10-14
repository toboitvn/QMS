using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class QmsSoKham
    {
        public int Id { get; set; }
        public int? SoKham { get; set; }
        public DateTime? NgayTao { get; set; }
        public string MayTao { get; set; }
        public byte? Status { get; set; }
        public string MaQuay { get; set; }
        public string IpMayTao { get; set; }
        public string PatientCode { get; set; }
        public int? PatientId { get; set; }
        public byte? IsUuTien { get; set; }
        public byte? IsDaXoa { get; set; }
        public int? SoPhong { get; set; }
        public short? DepartmentId { get; set; }
        public string MaCoSo { get; set; }
        public string MaBenhVien { get; set; }
        public string MaTram { get; set; }
    }
}
