using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Inventarization.Data.DB
{
    public class MyDbContext : DbContext
    {
        public DbSet<entities.Nomenclature> Nomenclatures {get;set;}
        public DbSet<entities.Responsible> Responsibles { get; set; }
        public DbSet<entities.Room> Rooms { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }
    }
}
