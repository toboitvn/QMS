using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LHoadonLog
    {
        public decimal HdonLogId { get; set; }
        public decimal CapphatId { get; set; }
        public int PaymentId { get; set; }
        public decimal TongTien { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public string MauHdon { get; set; }
        public string KiHieu { get; set; }
        public string MaQuyen { get; set; }
        public string Serie { get; set; }
        public string MaNvien { get; set; }
        public string MaLdo { get; set; }
        public DateTime NgayIn { get; set; }
        public string IpAddress { get; set; }
        public string MacAddress { get; set; }
        public short TrangThai { get; set; }
        public bool? DaGui { get; set; }
        public string QrDataCode { get; set; }
        public bool? DaIn { get; set; }
        public string TenDonVi { get; set; }
        public int? SoLanIn { get; set; }
        public bool? InGop { get; set; }
        public string NguoiHuy { get; set; }
        public DateTime? NgayHuy { get; set; }
        public string IpMacHuy { get; set; }
        public string TransactionId { get; set; }
        public string SupplierTaxCode { get; set; }
        public string InvInvoiceAuthId { get; set; }
        public string InvInvoiceCodeId { get; set; }
        public string Sobaomat { get; set; }
        public string Id { get; set; }
        public int? SolanIn1 { get; set; }
        public int? NguoiIn { get; set; }
        public int? LoaiXuat { get; set; }
    }
}
