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
    
    public partial class TempSale
    {
        public int TempId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int ShopId { get; set; }
        public Nullable<double> DiscountPercent { get; set; }
        public Nullable<double> DiscountAmount { get; set; }
        public double SellingPrice { get; set; }
        public double TotalPrice { get; set; }
        public double Qty { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Shop Shop { get; set; }
        public virtual User User { get; set; }
    }
}
