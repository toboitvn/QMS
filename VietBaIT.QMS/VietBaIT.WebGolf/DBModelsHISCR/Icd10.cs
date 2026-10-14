using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class Icd10
    {
        public long Id { get; set; }
        public string SttChuong { get; set; }
        public string MaChuong { get; set; }
        public string ChapterName { get; set; }
        public string TenChuong { get; set; }
        public string MaNhomChinh { get; set; }
        public string MainGroupNameI { get; set; }
        public string TenNhomChinh { get; set; }
        public string MaNhomPhu1 { get; set; }
        public string SubGroupNameI { get; set; }
        public string TenNhomPhu1 { get; set; }
        public string MaNhomPhu2 { get; set; }
        public string SubGroupNameIi { get; set; }
        public string TenNhomPhu2 { get; set; }
        public string MaLoai { get; set; }
        public string TypeName { get; set; }
        public string TenLoai { get; set; }
        public string MaBenh { get; set; }
        public string MaBenhKhongDau { get; set; }
        public string DiseaseName { get; set; }
        public string TenBenh { get; set; }
        public string GhiChu { get; set; }
        public string NgayCapNhat { get; set; }
    }
}
