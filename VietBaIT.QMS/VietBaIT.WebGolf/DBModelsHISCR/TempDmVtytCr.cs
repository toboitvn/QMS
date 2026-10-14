using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TempDmVtytCr
    {
        public string MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string MaBhyt { get; set; }
        public string TenBhyt { get; set; }
        public string MaLoai { get; set; }
        public string Donvitinh { get; set; }
        public string TenHoatchat { get; set; }
        public string QuyCach { get; set; }
        public string NuocSx { get; set; }
        public string NhaSx { get; set; }
        public double? NoitruNgoaitru { get; set; }
        public string NhomChiphi { get; set; }
        public string SoDangki { get; set; }
        public string NhaCungcap { get; set; }
        public string SoThau { get; set; }
        public string Congbo { get; set; }
        public string Soluong { get; set; }
        public string DongiaThau { get; set; }
        public string DongiaBh { get; set; }
        public int? IdHoatchat { get; set; }
        public int? IdDvt { get; set; }
        public int? IdNhomchiphi { get; set; }
        public int? CountryId { get; set; }
        public int? DrugTypeId { get; set; }
        public int? DrugNature { get; set; }
        public int? IdNhathau { get; set; }
        public int? IdPhanloaithuoc { get; set; }
        public int? DrugId { get; set; }
        public string GoiThau { get; set; }
    }
}
