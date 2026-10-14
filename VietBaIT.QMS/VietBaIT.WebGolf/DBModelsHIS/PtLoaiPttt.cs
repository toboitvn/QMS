using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class PtLoaiPttt
    {
        public PtLoaiPttt()
        {
            PtPhieuPttt = new HashSet<PtPhieuPttt>();
        }

        public short IdLoaiPttt { get; set; }
        public string MaLoaiPttt { get; set; }
        public string TenLoaiPttt { get; set; }
        public short Stt { get; set; }
        public bool HienThi { get; set; }
        public string GhiChu { get; set; }
        public string LoaiHinh { get; set; }
        public string TenLoaiHinh { get; set; }

        public virtual ICollection<PtPhieuPttt> PtPhieuPttt { get; set; }
    }
}
