using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TFileDigitalSignatureInfo
    {
        public long FileDigitalsignatureinfoId { get; set; }
        public long IdFile { get; set; }
        public string FileName { get; set; }
        public string UserSigned { get; set; }
        public DateTime? DateSigned { get; set; }
        public byte? TrangThai { get; set; }
        public double? Llx { get; set; }
        public double? Lly { get; set; }
        public double? Urx { get; set; }
        public double? Ury { get; set; }
        public int? PageNo { get; set; }
        public string DigitalsignatureName { get; set; }
    }
}
