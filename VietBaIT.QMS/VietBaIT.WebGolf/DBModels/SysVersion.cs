using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModels
{
    public partial class SysVersion
    {
        public int PkIntId { get; set; }
        public string SFileName { get; set; }
        public string SRarFileName { get; set; }
        public byte[] ObjData { get; set; }
        public string SVersion { get; set; }
        public short? IntRar { get; set; }
        public short? IntPatch { get; set; }
        public DateTime? TUpdatedDate { get; set; }
        public int? DblCapacity { get; set; }
        public string SDesc { get; set; }
    }
}
