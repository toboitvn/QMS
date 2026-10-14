using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsQMS
{
    public partial class QmsCanLamSang
    {
        public int Id { get; set; }
        public string MaPhong { get; set; }
        public int SoKham { get; set; }
        public DateTime NgayTao { get; set; }
        public string MaCoSo { get; set; }
        public string MaBenhVien { get; set; }
        public byte UuTien { get; set; }
        public string SoPhong { get; set; }
        public string MaChucnang { get; set; }
        public long PatientId { get; set; }
        public string PatientCode { get; set; }
        public string TenBenhnhan { get; set; }
        public int NamSinh { get; set; }
        public byte? TrangThai { get; set; }
        public string MaKhoa { get; set; }
        public string MaPhieu { get; set; }
        public byte? CoKetqua { get; set; }
        public int? ServiceDetailId { get; set; }
    }
}
