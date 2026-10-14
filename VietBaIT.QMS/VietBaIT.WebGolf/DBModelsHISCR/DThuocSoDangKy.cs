using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DThuocSoDangKy
    {
        public int DrugId { get; set; }
        public string MaSoDky { get; set; }

        public virtual LDrugs Drug { get; set; }
        public virtual DSoDangKy MaSoDkyNavigation { get; set; }
    }
}
