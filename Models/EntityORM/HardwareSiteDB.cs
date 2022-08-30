using System;
using Microsoft.EntityFrameworkCore;

namespace HardwareSite.Models
{
    public class HardwareSiteDB : DbContext
    {
        public DbSet<HardwareModel> HardwareSet;
        public DbSet<UserModel> UserSet;
        public DbSet<HardwareTypeModel> HardwareTypeSet;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("")
        }
    }
}

