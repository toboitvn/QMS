using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LMauDichVuThuoc
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string TenMau { get; set; }
        public int? ParentId { get; set; }
        public int? ServiceId { get; set; }
        public int? ServiceDetailId { get; set; }
        public int? Quantity { get; set; }
        public int? StaffId { get; set; }
        public int? DeparmentId { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string KieuMau { get; set; }
        public string ChiDan { get; set; }
        public string MaDoiTuong { get; set; }
        public byte? TrongGoi { get; set; }
        public string CachDung { get; set; }
        public string ChiDanThem { get; set; }
        public string DviDung { get; set; }
        public byte? IsPayment { get; set; }
        public string SoLanDung { get; set; }
        public string SoLuongDung { get; set; }
    }
}
