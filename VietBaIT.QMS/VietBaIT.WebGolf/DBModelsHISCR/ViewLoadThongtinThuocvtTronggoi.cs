using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class ViewLoadThongtinThuocvtTronggoi
    {
        public decimal? LastPrice { get; set; }
        public decimal? Surcharge { get; set; }
        public int DrugId { get; set; }
        public int DrugTypeId { get; set; }
        public string DrugCode { get; set; }
        public byte DrugNature { get; set; }
        public string DrugName { get; set; }
        public decimal Price { get; set; }
        public short UnitId { get; set; }
        public string SDesc { get; set; }
        public string Active { get; set; }
        public string Content { get; set; }
        public string Manufacturers { get; set; }
        public string NumberRegister { get; set; }
        public string Producer { get; set; }
        public string ListBhyt { get; set; }
        public byte HieuLuc { get; set; }
        public string DangBche { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string ObjectTypeCode { get; set; }
        public int Quantity { get; set; }
        public int? IdGoiDvu { get; set; }
        public int TrongGoi { get; set; }
        public string MaGoiDvu { get; set; }
        public string MaDtuong { get; set; }
        public string MaKieuDvu { get; set; }
        public int IdDvu { get; set; }
        public int IdLoaiDvu { get; set; }
        public string UnitName { get; set; }
    }
}
