using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using web_deploy_1.BusinessLogic;

namespace web_deploy_1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="PLEASE ENTER NAME!!!!!")]
        [StringLength(255)]
        public string Name { get; set; }

        [email_validate]
        public string Email { get; set; }

        [Display(Name="Enter YOU birthDate")]
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribeToNewsLetter { get; set;}
        
        public byte MemberShipTypeId { get; set; }
        public MemberShipType MemberShipType { get; set; }




    }
}