using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using rungreenlake.web.Areas.Identity.Data;

namespace rungreenlake.data
{
    public class Context : IdentityDbContext<RunGreenLakeUser>
    {
        public Context()
        {
        }
        
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<RunGreenLakeUser>().HasMany(u => u.BuddyStates).WithOne(u => u.SecondProfile);
        }
    }
}
