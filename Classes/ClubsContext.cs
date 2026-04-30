using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using pr29_bartova.Classes.Common;
using pr29_bartova.Models;

namespace pr29_bartova.Classes
{
    public class ClubsContext: DbContext
    {
        public DbSet<Clubs> Clubs { get; set; }
        public ClubsContext() =>
            Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=>
            optionsBuilder.UseMySql(Config.ConnectionConfig, Config.Version);
    }
}
