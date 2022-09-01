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
    
    using FluentValidation.Internal;
    using FluentValidation.Resources;
    using FluentValidation.Results;
    using FluentValidation;
    using FluentValidation.Validators;
    
     public partial class vwProductDto
    {
        
        //Default Constructor
        public vwProductDto(){}
        
        public  class AbstractValidatorEF : AbstractValidator<vwProductDto>
        {
            public AbstractValidatorEF()
            {
              SetValidationRules();
            }
            
            public virtual void SetValidationRules()
            {
                RuleFor(x => x.ProductId).NotNull();
                RuleFor(x => x.ProductCode).MaximumLength(50).NotEmpty();
                RuleFor(x => x.ProductName).MaximumLength(50).NotEmpty();
                RuleFor(x => x.SellingPrice).NotNull();
                RuleFor(x => x.Deleted).NotNull();
                RuleFor(x => x.TaxTypeName).MaximumLength(50).NotEmpty();
                RuleFor(x => x.TaxTypeValue).NotNull();
                RuleFor(x => x.TaxTypeStatus).MaximumLength(50).NotEmpty();
                RuleFor(x => x.UnitName).MaximumLength(50).NotEmpty();
                RuleFor(x => x.SubUnit).MaximumLength(50).NotEmpty();
                RuleFor(x => x.ShopName).MaximumLength(50);
                RuleFor(x => x.BrandName).MaximumLength(50).NotEmpty();
               
            }
       
        }
    
        
        
        
        /// <summary>
        /// Converts vwProduct Dto to vwProduct EF Model
        /// </summary>
        /// <returns>vwProduct EF model</returns>
        public vwProduct ToEFModel()
        {
            var model = new vwProduct();
            model.ProductId = this.ProductId;
            model.ProductCode = this.ProductCode;
            model.ProductName = this.ProductName;
            model.BarCode = this.BarCode;
            model.SellingPrice = this.SellingPrice;
            model.Deleted = this.Deleted;
            model.TaxTypeName = this.TaxTypeName;
            model.TaxTypeValue = this.TaxTypeValue;
            model.TaxTypeStatus = this.TaxTypeStatus;
            model.UnitName = this.UnitName;
            model.SubUnit = this.SubUnit;
            model.ShopName = this.ShopName;
            model.BrandName = this.BrandName;
            return model;
        }
    
    
        // <summary>
        /// Creates a Dto from a vwProduct Entity Model
        /// </summary>
        /// <param name="model">vwProduct model</param>
        /// <returns>vwProduct Dto</returns>
        public static vwProductDto FromEFModel(vwProduct model)
        {
            if(model == null) return null;
            var dto = new vwProductDto();
            dto.ProductId = model.ProductId;
            dto.ProductCode = model.ProductCode;
            dto.ProductName = model.ProductName;
            dto.BarCode = model.BarCode;
            dto.SellingPrice = model.SellingPrice;
            dto.Deleted = model.Deleted;
            dto.TaxTypeName = model.TaxTypeName;
            dto.TaxTypeValue = model.TaxTypeValue;
            dto.TaxTypeStatus = model.TaxTypeStatus;
            dto.UnitName = model.UnitName;
            dto.SubUnit = model.SubUnit;
            dto.ShopName = model.ShopName;
            dto.BrandName = model.BrandName;
            return dto;
        }
    
    
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string BarCode { get; set; }
        public double SellingPrice { get; set; }
        public int Deleted { get; set; }
        public string TaxTypeName { get; set; }
        public double TaxTypeValue { get; set; }
        public string TaxTypeStatus { get; set; }
        public string UnitName { get; set; }
        public string SubUnit { get; set; }
        public string ShopName { get; set; }
        public string BrandName { get; set; }
    }
}
