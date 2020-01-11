using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DreamStream.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public  bool IsSubscribedToNewsletter { get; set; }
        [Display(Name="Membership Type")]
        public MembershipType MembershipType { get; set; }
        public int MembershipTypeId { get; set; }
        [Display(Name="Date of Birth")]
        public Nullable<DateTime> Birthdate { get; set; }
    }
}