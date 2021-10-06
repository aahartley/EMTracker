using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EMTracker.Models;

namespace EMTracker.Data
{
    public class EMTrackerContext : DbContext
    {
        public EMTrackerContext (DbContextOptions<EMTrackerContext> options)
            : base(options)
        {
            Database.EnsureCreated( );
        }

        public DbSet<Sample> Sample { get; set; }
    }
}
