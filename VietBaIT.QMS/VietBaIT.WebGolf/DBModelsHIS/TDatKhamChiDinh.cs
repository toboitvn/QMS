using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TDatKhamChiDinh
    {
        public int ChiDinhId { get; set; }
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public int DatKhamId { get; set; }
        public short ServiceDetailId { get; set; }
        public short? ServiceId { get; set; }
        public decimal Price { get; set; }
        public int? Quantity { get; set; }
        public DateTime InputDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool? TrangThai { get; set; }
    }
}
