using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DDonThuocMauCt
    {
        public int IdDonMauCt { get; set; }
        public int IdDonMau { get; set; }
        public int IdThuoc { get; set; }
        public double SoLuong { get; set; }
        public string ChiDan { get; set; }
        public string CachDung { get; set; }
        public string ChiDanThem { get; set; }
        public string DviDung { get; set; }
        public string SoLanDung { get; set; }
        public string SoLuongDung { get; set; }

        public virtual DDonThuocMau IdDonMauNavigation { get; set; }
        public virtual LDrugs IdThuocNavigation { get; set; }
    }
}
