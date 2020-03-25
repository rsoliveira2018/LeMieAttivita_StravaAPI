using LeMieAttivita.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeMieAttivita.Data
{
    public class LeMieAttivitaContext : DbContext
    {
        public LeMieAttivitaContext(DbContextOptions<LeMieAttivitaContext> options) : base(options) { }

        public DbSet<Athlete> Athlete { get; set; }
        public DbSet<Activity> Activity { get; set; }
        public DbSet<ApiToken> ApiToken { get; set; }
    }
}
