using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }

        public bool IsSubcribedNewsletter { get; set; }
      
        // navigation property 
        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        // [Min18Years]
        public DateTime? Birthdate { get; set; }
    }
}