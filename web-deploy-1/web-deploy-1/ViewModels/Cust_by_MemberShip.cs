using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web_deploy_1.Models;

namespace web_deploy_1.ViewModels
{
    public class Cust_by_MemberShip
    {
        public List<MemberShipType> MemberShipTypes { get; set; }

        public Customer Customer { get; set; }
    }
}