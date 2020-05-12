/*
 *+++RaceRecord+++
 * RaceRecord will consist of all the User entered race times,
 * each race type will be recorded along with a total time, in seconds,
 * and a mile time, in seconds.
 * 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using rungreenlake.web.Areas.Identity.Data;

namespace rungreenlake.Models
{
    public class RaceRecord
    {
        public int RaceRecordID { get; set; }

        public int ProfileID { get; set; }

        // 1 = 1 mile, 2 = 5k, 3 = 10k, 4 = Half Marathon, 5 = Marathon
        public int RaceType { get; set; }

        //Total time, in seconds, for the race.
        public int RaceTime { get; set; }

        //calculated based on type and time
        public int MileTime { get; set; }

        public Profile RaceProfile { get; set; }
    }
}