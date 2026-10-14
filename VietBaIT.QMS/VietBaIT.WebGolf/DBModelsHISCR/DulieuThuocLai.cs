using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DulieuThuocLai
    {
        public int? DrugId { get; set; }
        public string TenBhyt { get; set; }
        public string MaBoYte { get; set; }
        public string Content { get; set; }
        public string IdDuongDung { get; set; }
        public string NumberRegister { get; set; }
        public string NqTt { get; set; }
        public int? IdNhomCphi { get; set; }
        public string UnitName { get; set; }
        public int? UnitId { get; set; }
        public string TyleTt { get; set; }
        public decimal? Giabhyt { get; set; }
    }
}
