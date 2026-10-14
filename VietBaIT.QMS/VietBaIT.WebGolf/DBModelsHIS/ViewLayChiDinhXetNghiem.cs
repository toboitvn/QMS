using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewLayChiDinhXetNghiem
    {
        public long AssignId { get; set; }
        public string AssignCode { get; set; }
        public string Barcode { get; set; }
        public string MaChidinh { get; set; }
        public string MaKhoaThien { get; set; }
        public long? ExamId { get; set; }
        public short? DepartmentId { get; set; }
        public long AssignDetailId { get; set; }
        public short? ServiceId { get; set; }
        public int ServiceDetailId { get; set; }
        public byte? NoiTru { get; set; }
        public short? DiagPerson { get; set; }
        public byte? PaymentStatus { get; set; }
        public byte AssignDetailStatus { get; set; }
        public DateTime? InputDate { get; set; }
        public string RegDate { get; set; }
        public string MaKetNoi { get; set; }
        public string MaChiTietKetNoi { get; set; }
        public string ServiceDetailName { get; set; }
        public int? ServiceDetailCode { get; set; }
        public string ServiceName { get; set; }
        public short GroupIntOrder { get; set; }
        public int? IntOrder { get; set; }
    }
}
