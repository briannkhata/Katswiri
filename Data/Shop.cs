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
    
    public partial class Shop
    {
        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int CompanyId { get; set; }
        public string Currency { get; set; }
        public int Deleted { get; set; }
        public string Location { get; set; }
        public string District { get; set; }
        public string Country { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
