using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HandelNieruchomosciami.Controllers.Models.Database
{
    public class DatabaseContext : IdentityDbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Agent> Agents { get; set; }
        public DbSet<Kontrahent> Kontrahents { get; set; }
        public DbSet<Nieruchomosc> Nieruchomoscs { get; set; }
        public DbSet<StatusTransakcji> StatusTransakcjis { get; set; }
        public DbSet<Transakcja> Transakcjas { get; set; }
        public DbSet<TypZabudowy> TypZabudowies { get; set; }
        public DbSet<Umowa> Umowas { get; set; }
        public DbSet<Wlasciciel> Wlasciciels { get; set; }
    }
}
