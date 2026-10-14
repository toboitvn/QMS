using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewDrugDonthuocChitietMau
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
        public short? SoLanDung { get; set; }
        public short? SoLuongDung { get; set; }
        public int? DrugId { get; set; }
        public string DrugCode { get; set; }
        public short DrugTypeId { get; set; }
        public byte DrugNature { get; set; }
        public string DrugName { get; set; }
        public decimal Price { get; set; }
        public short UnitId { get; set; }
        public string Active { get; set; }
        public string Content { get; set; }
        public string Manufacturers { get; set; }
        public string NumberRegister { get; set; }
        public string Producer { get; set; }
        public string ListBhyt { get; set; }
        public byte HieuLuc { get; set; }
        public string DangBche { get; set; }
        public string UnitName { get; set; }
        public string SDesc { get; set; }
        public string MaNhomThuoc { get; set; }
    }
}
