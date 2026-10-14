using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TPhieukhamthaiTiensusankhoa
    {
        public int IdTiensuSankhoa { get; set; }
        public int IdPhieuKhamthai { get; set; }
        public string ThoigianNoiketthucThainghen { get; set; }
        public string TuoiThai { get; set; }
        public string DienbienKhicothai { get; set; }
        public string CachThucSinh { get; set; }
        public string TreSoSinh { get; set; }
        public string HauSan { get; set; }
    }
}
