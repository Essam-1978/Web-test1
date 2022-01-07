using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using web_deploy_1.Models;

namespace web_deploy_1.BusinessLogic

{
    public class name_validate:ValidationAttribute

    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Customer cust = (Customer)validationContext.ObjectInstance;

            if (cust.Name == "Essam") { return new ValidationResult("NONO"); }
            else
            if (cust.Name == "LOLO") { return ValidationResult.Success; }

            return ValidationResult.Success;

                        

        }
    }
}