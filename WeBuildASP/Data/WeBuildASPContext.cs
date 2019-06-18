using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WeBuildASP.Models;

namespace WeBuildASP.Models
{
    public class WeBuildASPContext : DbContext
    {
        public WeBuildASPContext()
        {
        }

        public WeBuildASPContext (DbContextOptions<WeBuildASPContext> options)
            : base(options)
        {
        }

        //Add class in Db context
        public DbSet<User> USERS { get; set; }
        public DbSet<Acess> ACESS { get; set; }
        public DbSet<Incharge> INCHARGE { get; set; }
        public DbSet<Team> TEAM { get; set; }
        public DbSet<Presence> PRESENCE { get; set; }
        public DbSet<Employee> EMPLOYS { get; set; }
        public DbSet<Schedule> SCHEDULE { get; set; }
    }
}
