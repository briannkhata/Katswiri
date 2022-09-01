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
    
     public partial class CategoryDto
    {
        
        //Default Constructor
        public CategoryDto(){}
        
        public  class AbstractValidatorEF : AbstractValidator<CategoryDto>
        {
            public AbstractValidatorEF()
            {
              SetValidationRules();
            }
            
            public virtual void SetValidationRules()
            {
                RuleFor(x => x.CategoryId).NotNull();
                RuleFor(x => x.Deleted).NotNull();
               
            }
       
        }
    
        
        
        
        /// <summary>
        /// Converts Category Dto to Category EF Model
        /// </summary>
        /// <returns>Category EF model</returns>
        public Category ToEFModel()
        {
            var model = new Category();
            model.CategoryId = this.CategoryId;
            model.CategoryName = this.CategoryName;
            model.Deleted = this.Deleted;
            return model;
        }
    
    
        // <summary>
        /// Creates a Dto from a Category Entity Model
        /// </summary>
        /// <param name="model">Category model</param>
        /// <returns>Category Dto</returns>
        public static CategoryDto FromEFModel(Category model)
        {
            if(model == null) return null;
            var dto = new CategoryDto();
            dto.CategoryId = model.CategoryId;
            dto.CategoryName = model.CategoryName;
            dto.Deleted = model.Deleted;
            return dto;
        }
    
    
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int Deleted { get; set; }
    }
}
