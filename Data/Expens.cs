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
    
    public partial class Expens
    {
        public int ExpenseId { get; set; }
        public int ExpenseTypeId { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }
        public int Deleted { get; set; }
        public int AddedBy { get; set; }
        public int PaymentTypeId { get; set; }
        public System.DateTime ExpenseDate { get; set; }
    
        public virtual PaymentType PaymentType { get; set; }
        public virtual ExpenseType ExpenseType { get; set; }
    }
}
