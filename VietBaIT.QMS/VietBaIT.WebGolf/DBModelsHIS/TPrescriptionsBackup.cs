using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TPrescriptionsBackup
    {
        public int PresId { get; set; }
        public int? TreatId { get; set; }
        public int? PatientDeptId { get; set; }
        public int? ReplacePresId { get; set; }
        public long? ExamId { get; set; }
        public short? StockId { get; set; }
        public int? PatientId { get; set; }
        public string PatientCode { get; set; }
        public DateTime PresDate { get; set; }
        public short? AssignId { get; set; }
        public byte Status { get; set; }
        public byte PaymentStatus { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string SDesc { get; set; }
        public string PresName { get; set; }
        public string PresCode { get; set; }
        public short? LoaiDonthuoc { get; set; }
        public int? AssginDetailId { get; set; }
        public byte? PreHos { get; set; }
        public byte? PresType { get; set; }
        public short? DepartmentId { get; set; }
        public short? RoomId { get; set; }
        public short? BedId { get; set; }
        public byte? PresStatus { get; set; }
        public string KieuDonthuoc { get; set; }
        public string LoiDanBsy { get; set; }
        public DateTime? NgayTaiKham { get; set; }
        public string TaiKham { get; set; }
        public string MaKhoaThien { get; set; }
        public byte? KeDonTquay { get; set; }
        public string NguoiPhatThuoc { get; set; }
        public DateTime? NgayPhatThuoc { get; set; }
        public int? IdChot { get; set; }
        public DateTime? NgayChot { get; set; }
        public short? SoIn { get; set; }
        public string MaCoSo { get; set; }
    }
}
