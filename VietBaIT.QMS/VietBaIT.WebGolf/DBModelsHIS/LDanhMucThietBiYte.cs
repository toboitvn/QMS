using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LDanhMucThietBiYte
    {
        public int Id { get; set; }
        public int? Stt { get; set; }
        public string TenTb { get; set; }
        public string KyHieu { get; set; }
        public string CongtySx { get; set; }
        public string NuocSx { get; set; }
        public string NamSx { get; set; }
        public string NamSd { get; set; }
        public string MaMay { get; set; }
        public string SoLuuHanh { get; set; }
        public DateTime? HdTu { get; set; }
        public DateTime? HdDen { get; set; }
        public string TuNgay { get; set; }
        public bool? GuiAx { get; set; }
    }
}
