using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class BhDichVuKtTyLe
    {
        public int IdDichVuKt { get; set; }
        public byte Loai { get; set; }
        public double TyLe { get; set; }
        public decimal DonGiaBh { get; set; }
    }
}
