using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBroker.Models.Database
{
    public class DatabaseContext : IdentityDbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        {        
        }

        public DbSet<Property> Propertys { get; set; }
        public DbSet<Address> Addresses  { get; set; }
        public DbSet<Owner> Owners { get; set; }

    }
}
