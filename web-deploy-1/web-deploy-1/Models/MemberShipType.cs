using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_deploy_1.Models
{
    public class MemberShipType
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public short SignUpFees { get; set; }
        public byte DurationInMonth { get; set; }
        public byte DiscountRate { get; set; }
    }
}