using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class DDieuTietThauCt
    {
        public int IdDieutietCt { get; set; }
        public int IdDieutiet { get; set; }
        public int IdThauCt { get; set; }
        public int SoLuong { get; set; }
    }
}
