using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class QmsCls
    {
        public int Id { get; set; }
        public string PatientCode { get; set; }
        public int? PatientId { get; set; }
        public int? Stt { get; set; }
        public int? AssignId { get; set; }
        public string MaQuay { get; set; }
        public byte? Status { get; set; }
        public byte? IsDaXoa { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string MaKhoaThien { get; set; }
        public string MaPhongStt { get; set; }
    }
}
