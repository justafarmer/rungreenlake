/*
 *+++PaceMatchViewModel+++
 * This is used to show the best race times for a user,
 * from here they can click on the time entry and view ALL
 * of the records for that user and some of the details from their profile.
 * 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace rungreenlake.Models.ViewModels
{
    public class PaceMatchViewModel
    {
        public int RunnerID { get; set; }
        public int MileTime { get; set; }

        public int Lower { get; set; }
        public int Upper { get; set; }

    }
}
