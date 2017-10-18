using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id   { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }

        public bool IsSubcribedNewsletter { get; set; }


        
        public MembershipType MembershipType { get; set; }
        // navigation property 

            
        public byte MembershipTypeId { get; set; }

        [Min18Years]
        public DateTime? Birthdate { get; set; }

    }
}