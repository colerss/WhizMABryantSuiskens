﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhizMA.Areas.Identity.Data;
using WhizMA.Models;

namespace WhizMA.Data
{
    public class WhizMAContext : IdentityDbContext<Account>
    {
        public WhizMAContext (DbContextOptions<WhizMAContext> options) 
            : base(options)
        {

        }

        public DbSet<Les> Lessen { get; set; }
        public DbSet<CursusInhoud> CursusInhoud { get; set; }

        public DbSet<InfoNode> InfoNodes { get; set; }

        public DbSet<Bundel> Bundels { get; set; }
        public DbSet<BundelInhoud> BundelInhoud { get; set; }
        public DbSet<Cursus> Cursussen { get; set; }
        public DbSet<Docent> Docenten { get; set; }
        public DbSet<AccountCatalogus> AccountCatalogus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cursus>().ToTable("Cursussen");
            modelBuilder.Entity<Les>().ToTable("Lessen");
            modelBuilder.Entity<CursusInhoud>().ToTable("CursusInhoud");
            modelBuilder.Entity<InfoNode>().ToTable("InfoNodes");
            modelBuilder.Entity<Bundel>().ToTable("Bundels");
            modelBuilder.Entity<Docent>().ToTable("Docenten");
            modelBuilder.Entity<BundelInhoud>().ToTable("BundelInhoud");
            modelBuilder.Entity<AccountCatalogus>().ToTable("AccountCatalogus");

            modelBuilder.Entity<Bundel>().Property(p => p.HuidigePrijs).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Bundel>().Property(p => p.StandaardPrijs).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Cursus>().Property(p => p.HuidigePrijs).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Cursus>().Property(p => p.StandaardPrijs).HasColumnType("decimal(18,2)");
        }
    }
}
