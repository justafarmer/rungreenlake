/*
 *+++ProfileViewModel+++
 * This view model allows a user to see their race profile, not
 * to be confused with their account page.  This will allow
 * viewing buddy lists and race entries.
 * 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rungreenlake.web.Areas.Identity.Data;

namespace rungreenlake.Models.ViewModels
{
    public class ProfileViewModel
    {
        public RunGreenLakeUser MyUser { get; set; }
        public Profile MyProfile { get; set; }

        //Only used when viewing other profiles, otherwise a null value.
        public int? BuddyFlag { get; set; }

        //Three separate lists to group buddy states.
        public List<RunGreenLakeUser> MyListFriends { get; set; }
        public List<RunGreenLakeUser> MyListPending { get; set; }
        public List<RunGreenLakeUser> MyListBlocked { get; set; }
        public IEnumerable<RaceRecord> MyRaceRecords { get; set; }

    }
}
