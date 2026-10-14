using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class VibankTransaction
    {
        public int Transactionid { get; set; }
        public string Mti { get; set; }
        public string Providerid { get; set; }
        public string Hospitalid { get; set; }
        public string Processingcode { get; set; }
        public string Accountname { get; set; }
        public string Acctno { get; set; }
        public string Pan { get; set; }
        public string Issuedate { get; set; }
        public string Identifycardno { get; set; }
        public string Phonenumber { get; set; }
        public string Patientid { get; set; }
        public string Billid { get; set; }
        public decimal? Settlementamount { get; set; }
        public string Currency { get; set; }
        public string Paymentchanel { get; set; }
        public string Requesttime { get; set; }
        public string Clientip { get; set; }
        public string Addtion1 { get; set; }
        public string Addtion2 { get; set; }
        public string Addtion3 { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Issucess { get; set; }
        public string ReturnMessage { get; set; }
        public string BankTrxId { get; set; }
        public string Refundtranid { get; set; }
        public string Addinfo { get; set; }
        public string Querytranid { get; set; }
        public decimal? Amount { get; set; }
        public string Responsecode { get; set; }
        public string MaCoSo { get; set; }
        public string OtpCode { get; set; }
        public string OtpUserid { get; set; }
    }
}
