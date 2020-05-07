using rungreenlake.web.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rungreenlake.web.Pages
{
    public class BuddyState
    {
        //First User ID
        [Key]
        public int FirstID { get; set; }


        //Second User ID.
        public int SecondID { get; set; }


        // 1 = Matched, 2 = Requested, 3 = Blocked
        public int Status { get; set; }

        public RunGreenLakeUser FirstProfile { get; set; }
        public RunGreenLakeUser SecondProfile { get; set; }
    }
}
