using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DPhieuCapphatCt
    {
        public int IdCapPhatCt { get; set; }
        public int IdCapphat { get; set; }
        public int IdDonthuoc { get; set; }
        public int IdDonthuocCtiet { get; set; }
        public bool? DaLinh { get; set; }
        public double SoLuong { get; set; }
        public double? SoLuongPhat { get; set; }
        public int IdThuoc { get; set; }
        public int? IdDtri { get; set; }
        public string PatientCode { get; set; }
        public int? PatientId { get; set; }
        public int? IdThuocKho { get; set; }

        public virtual DPhieuCapphat IdCapphatNavigation { get; set; }
    }
}
