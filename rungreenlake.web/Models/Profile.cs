/*
 *+++Profile+++
 * Profile serves as a link betwee the AspNetUser (RunGreenLakeUser in
 * this case) entity and the rest of the related entities.  This will consist
 * of the needed navigation properties and the creation date of the profile.
 * Here, more properties can be easily added if needed.
 * 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using rungreenlake.web.Areas.Identity.Data;

namespace rungreenlake.Models
{
    public class Profile
    {
        [Key]
        public int ProfileID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Profile Creation Date")]
        public DateTime CreationDate { get; set; }

        public ICollection<RaceRecord> TimeEntries { get; set; }
        public ICollection<BuddyState> Buddies { get; set; }
        public ICollection<Thread> MessageThread { get; set; }

        public RunGreenLakeUser LoginUser { get; set; }
        public int LinkID { get; set; }
    }
}
