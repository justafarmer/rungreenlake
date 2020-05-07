using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using rungreenlake.web.Pages;
using rungreenlake.web.Pages.Races;

namespace rungreenlake.web.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the RunGreenLakeUser class
    public class RunGreenLakeUser : IdentityUser
    {
        [Required]
        [StringLength(30, ErrorMessage = "First name cannot be longer than 30 characters.")]
        [Display(Name = "First Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Last name cannot be longer than 30 characters.")]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string LastName { get; set; }

        public ICollection<RaceRecord> RaceRecords { get; set; }
        public ICollection<BuddyState> BuddyStates { get; set; }
    }
}
