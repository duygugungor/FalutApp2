using FaultApp2.Server.Models;
using FaultApp2.Shared.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaultApp2.Server.Data
{
    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Fault> Faults { get; set; }

        public DbSet<Operator> Operators { get; set; }

        public DbSet<MakinaGrubu> MakinaGrubus { get; set; }

        public DbSet<MakinaGrubu> Makinas { get; set; }



    }

}
