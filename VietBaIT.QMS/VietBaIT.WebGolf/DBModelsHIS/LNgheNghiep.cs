using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LNgheNghiep
    {
        public int IdNgheNghiep { get; set; }
        public string MaNgheNghiep { get; set; }
        public string TenNgheNghiep { get; set; }
        public string MaVietTat { get; set; }
        public int? ParentId { get; set; }
        public int? IntLevel { get; set; }
        public byte? HienThi { get; set; }
    }
}
