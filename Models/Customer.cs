﻿using System;
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
        [StringLength(225)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public int MembershiptypeId { get; set; }
    }
}