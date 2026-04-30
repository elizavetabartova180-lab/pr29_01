using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using pr29_bartova.Classes.Common;
using pr29_bartova.Models;

namespace pr29_bartova.Classes
{
    public class UserContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public UserContext() =>
            Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseMySql(Config.ConnectionConfig, Config.Version);
    }
}
