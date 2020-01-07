using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DreamStream.Models
{
    public class MembershipType
    {
        
        public int Id { get; set; }
        public int SignupFee { get; set; }
        public int DurationInMonths { get; set; }
        public int DiscountRate { get; set; }
    }
}