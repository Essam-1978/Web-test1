using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web_deploy_1.ViewModels;
using System.ComponentModel.DataAnnotations;
using web_deploy_1.Models;

namespace web_deploy_1.BusinessLogic
{
    public class email_validate:ValidationAttribute

    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {


            var CBM = (Customer)validationContext.ObjectInstance;

            if (CBM.Email == "yahoo.com") {
                return new
                ValidationResult("yahoo.com NOT ALLOWED...");
            }
            return ValidationResult.Success;


        }
    }
}