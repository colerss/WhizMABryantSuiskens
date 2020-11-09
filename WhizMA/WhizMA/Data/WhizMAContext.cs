using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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

        public DbSet<AccountCatalogus> AccountCatalogus { get; set; }

        public DbSet<Account> Accounts { get; set; }



    }
}
