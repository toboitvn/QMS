using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class DDichVuThuocVtu
    {
        public int Id { get; set; }
        public int? ServiceDetailId { get; set; }
        public int? IdThuoc { get; set; }
        public double? SoLuong { get; set; }
        public string Cachdung { get; set; }
        public byte? Tutuc { get; set; }
        public byte? Tronggoi { get; set; }

        public virtual LDrugs IdThuocNavigation { get; set; }
        public virtual LServiceDetail ServiceDetail { get; set; }
    }
}
