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
    
    public partial class AccountActivity
    {
        public int AccountActivityId { get; set; }
        public string AccountNumber { get; set; }
        public double OpeningBalance { get; set; }
        public double ClosingBalance { get; set; }
        public double ProfitLoss { get; set; }
        public System.DateTime ActivityDate { get; set; }
        public int ShopId { get; set; }
    }
}
