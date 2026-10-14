using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LStaffs
    {
        public short StaffId { get; set; }
        public string StaffCode { get; set; }
        public string MaBoYte { get; set; }
        public string StaffName { get; set; }
        public short DepartmentId { get; set; }
        public int? ParentId { get; set; }
        public short StaffTypeId { get; set; }
        public short RankId { get; set; }
        public string Uid { get; set; }
        public byte? Status { get; set; }
        public string SDesc { get; set; }
        public decimal SpecMoney { get; set; }
        public byte? Actived { get; set; }
        public int? CanSign { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public int? SoThuTu { get; set; }
        public string DienThoai { get; set; }
        public string AssignKhoa { get; set; }
        public string SignUser { get; set; }
        public string SignPass { get; set; }
        public byte[] SignImage { get; set; }
        public string MaLoaiKcb { get; set; }
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string MaBhxh { get; set; }
        public byte? GioiTinh { get; set; }
        public string ChucdanhNn { get; set; }
        public string ViTri { get; set; }
        public string NgaycapCchn { get; set; }
        public string NoicapCchn { get; set; }
        public string PhamviCm { get; set; }
        public string PhamviCmbs { get; set; }
        public string DvktKhac { get; set; }
        public string VbPhancong { get; set; }
        public byte? ThoigianDk { get; set; }
        public string ThoigianNgay { get; set; }
        public string ThoigianTuan { get; set; }
        public string CskcbKhac { get; set; }
        public string CskcbCgkt { get; set; }
        public string QdCgkt { get; set; }
        public bool? GuiAx { get; set; }
        public string SoCccd { get; set; }
    }
}
