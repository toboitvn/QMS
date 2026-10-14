using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LServiceType
    {
        public LServiceType()
        {
            LServices = new HashSet<LServices>();
        }

        public short ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public byte? ServiceTypeType { get; set; }
        public short IntOrder { get; set; }
        public string SDesc { get; set; }
        public string MaKieuDvu { get; set; }
        public string ServiceTypeCode { get; set; }
        public string TenBhyt { get; set; }
        public string MaBoYte { get; set; }

        public virtual ICollection<LServices> LServices { get; set; }
    }
}
