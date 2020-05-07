using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rungreenlake.web.Pages.Races
{
    public class RaceRecord
    {
        public int RaceRecordID { get; set; }

        public int ProfileID { get; set; }

        // 1 = 1 mile, 2 = 5k, 3 = 10k, 4 = Half Marathon, 5 = Marathon
        public int RaceType { get; set; }

        /*
        public int RaceTimeHours { get; set; }
        public int RaceTimeMinutes { get; set; }
        public int RaceTimeSeconds { get; set; }
        */

        //Total time, in seconds, for the race.
        public int RaceTime { get; set; }

        //calculated based on type and time
        public int MileTime { get; set; }
    }
}
