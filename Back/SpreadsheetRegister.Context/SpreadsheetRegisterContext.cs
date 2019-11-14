using Microsoft.EntityFrameworkCore;
using SpreadsheetRegister.Context.Mapping;
using SpreadsheetRegister.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpreadsheetRegister.Context
{
    public class SpreadsheetRegisterContext : DbContext
    {
        public SpreadsheetRegisterContext(DbContextOptions<SpreadsheetRegisterContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
