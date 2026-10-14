using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LMeasureUnits
    {
        public LMeasureUnits()
        {
            LServiceDetail = new HashSet<LServiceDetail>();
        }

        public short UnitId { get; set; }
        public string UnitName { get; set; }
        public short IntOrder { get; set; }
        public string SDesc { get; set; }

        public virtual ICollection<LServiceDetail> LServiceDetail { get; set; }
    }
}
