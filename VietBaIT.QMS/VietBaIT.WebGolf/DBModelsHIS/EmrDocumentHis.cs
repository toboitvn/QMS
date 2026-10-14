using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class EmrDocumentHis
    {
        public long IdDocumentHis { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public string EmrNo { get; set; }
        public long IdPhieu { get; set; }
        public string LoaiPhieu { get; set; }
        public string MaPhieuHis { get; set; }
        public string EmrMauphieu { get; set; }
        public string GhiChu { get; set; }
        public byte? TrangThai { get; set; }
        public byte? TrangThaihuy { get; set; }
        public int? DocumentId { get; set; }
        public DateTime? ThoigianGui { get; set; }
        public int? OldDocumentId { get; set; }
        public byte? TrangthaiTao { get; set; }
        public DateTime? ThoigianTao { get; set; }
        public byte? TrangthaiKy { get; set; }
        public DateTime? ThoigianKy { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string MayTao { get; set; }
    }
}
