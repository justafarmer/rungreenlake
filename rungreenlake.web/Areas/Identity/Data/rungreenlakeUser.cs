﻿/*
 *+++RunGreenLakeUser+++
 * Entity for the user, which combines properties with IdentityUser.
 * LinkID is used to couple this entity with the profile entity.
 * 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using rungreenlake.Models;


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

        //secondary key, easy to display, used to link all other related data.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LinkID { get; set; }

        public Profile UserProfile { get; set; }
    }
}
