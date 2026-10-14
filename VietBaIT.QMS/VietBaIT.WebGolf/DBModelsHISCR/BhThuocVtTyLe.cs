using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class BhThuocVtTyLe
    {
        public int DrugId { get; set; }
        public double TyLe { get; set; }
        public decimal DonGiaBh { get; set; }

        public virtual LDrugs Drug { get; set; }
    }
}
