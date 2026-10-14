using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TTheodoichisosinhtontruyenmau
    {
        public int IdTheodoi { get; set; }
        public int IdTruyenmau { get; set; }
        public DateTime? ThoigianDo { get; set; }
        public int? Tocdotruyen { get; set; }
        public string MausacdaNiemmac { get; set; }
        public string Nhiptho { get; set; }
        public string Mach { get; set; }
        public string Huyetap { get; set; }
        public string Nhietdo { get; set; }
        public string Dienbienkhac { get; set; }
        public string CreateBy { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyBy { get; set; }
    }
}
