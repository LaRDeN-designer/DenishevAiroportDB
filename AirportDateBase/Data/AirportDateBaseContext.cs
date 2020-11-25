using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AirportDateBase.Models;

namespace AirportDateBase.Data
{
    public class AirportDateBaseContext : DbContext
    {
        public AirportDateBaseContext (DbContextOptions<AirportDateBaseContext> options)
            : base(options)
        {
        }

        public DbSet<AirportDateBase.Models.Crew> Crew { get; set; }

        public DbSet<AirportDateBase.Models.Employee> Employee { get; set; }

        public DbSet<AirportDateBase.Models.Flight> Flight { get; set; }

        public DbSet<AirportDateBase.Models.Plane> Plane { get; set; }

        public DbSet<AirportDateBase.Models.Posts> Posts { get; set; }

        public DbSet<AirportDateBase.Models.Tickets> Tickets { get; set; }

        public DbSet<AirportDateBase.Models.Type_plane> Type_plane { get; set; }
    }
}
