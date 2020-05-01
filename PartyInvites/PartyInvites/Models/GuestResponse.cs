using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your Name")]
        public string Name { get; set; }
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid Email"), Required(ErrorMessage = "Please enter an Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your Phone Number")]
        public string Phone { get; set; }
        [Required]
        public bool Attend { get; set; }
        public string FoodRestrict { get; set; }
    }
}
