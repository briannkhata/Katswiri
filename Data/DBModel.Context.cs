﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KEntities : DbContext
    {
        public KEntities()
            : base("name=KEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<ProductQuantity> ProductQuantities { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vat> Vats { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<IncomeType> IncomeTypes { get; set; }
        public virtual DbSet<ExpenseType> ExpenseTypes { get; set; }
        public virtual DbSet<vwIncomeType> vwIncomeTypes { get; set; }
        public virtual DbSet<vwExpenseType> vwExpenseTypes { get; set; }
        public virtual DbSet<vwPaymentType> vwPaymentTypes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<vwCategory> vwCategories { get; set; }
        public virtual DbSet<Income> Incomes { get; set; }
        public virtual DbSet<vwIncome> vwIncomes { get; set; }
        public virtual DbSet<Expens> Expenses { get; set; }
        public virtual DbSet<vwExpens> vwExpenses { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<vwShop> vwShops { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<vwCompany> vwCompanies { get; set; }
    }
}