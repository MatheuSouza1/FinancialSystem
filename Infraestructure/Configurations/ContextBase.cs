﻿using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Configurations
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Expenditure> Expenditure { get; set; }
        public DbSet<FinancialSystem> FinancialSystem { get; set; }
        public DbSet<UserFinancialSystem> UserFinancialSystem { get; set; }

        public ContextBase(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNetusers").HasKey(t => t.Id);
            base.OnModelCreating(builder);
        }
    }
}
