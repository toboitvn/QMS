using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class PmHinhAnhPttt
    {
        public long IdPhieu { get; set; }
        public int IdPhongMo { get; set; }
        public int IdPhieuPttt { get; set; }
        public string SPath { get; set; }
        public string SFileName { get; set; }
        public byte[] Thumbnail { get; set; }
        public string SDescription { get; set; }
        public int? IntOrder { get; set; }
    }
}
