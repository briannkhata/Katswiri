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
    
    public partial class ProductQuantity
    {
        public int ProductId { get; set; }
        public int ShopId { get; set; }
        public double ShopQty { get; set; }
        public double StoresQty { get; set; }
        public double KitchenQty { get; set; }
        public int Id { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
