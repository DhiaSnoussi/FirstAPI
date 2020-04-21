using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstAPI.Modals;

namespace FirstAPI.Data
{
    public class MeetingContext : DbContext
    {
        public MeetingContext (DbContextOptions<MeetingContext> options)
            : base(options)
        {
        }

        public DbSet<FirstAPI.Modals.Meeting> Meeting { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // this script used to migrate the database with SQL Server
        {
            optionsBuilder.UseSqlServer(@"Data Source=Microsoft_MSP;Initial Catalog=FirstApiDB;Integrated Security=True");
        }

    }
}
