using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DThangSoBanleThuoc
    {
        public int Id { get; set; }
        public decimal DonGiaNhapTu { get; set; }
        public decimal DonGiaNhapDen { get; set; }
        public decimal ThangSoBanLe { get; set; }
        public bool? HienThi { get; set; }
        public string MoTa { get; set; }
    }
}
