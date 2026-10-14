using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class DDonThuocMau
    {
        public DDonThuocMau()
        {
            DDonThuocMauCt = new HashSet<DDonThuocMauCt>();
        }

        public int IdDonMau { get; set; }
        public string MaDonMau { get; set; }
        public string TenDonMau { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public bool IsPublic { get; set; }
        public string KieuThuocCt { get; set; }

        public virtual ICollection<DDonThuocMauCt> DDonThuocMauCt { get; set; }
    }
}
