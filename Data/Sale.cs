//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Katswiri.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public int SaleId { get; set; }
        public double TotalTendered { get; set; }
        public double TotalBill { get; set; }
        public double DiscountPercent { get; set; }
        public double DiscountAmount { get; set; }
        public double TaxAmount { get; set; }
        public Nullable<int> SoldTo { get; set; }
        public int SoldBy { get; set; }
        public int ShopId { get; set; }
        public System.DateTime DateSold { get; set; }
        public double TotalChange { get; set; }
        public int SaleTypeId { get; set; }
        public int Deleted { get; set; }
        public string txnId { get; set; }
        public double SubTotal { get; set; }
        public int PaymentTypeId { get; set; }
    }
}
