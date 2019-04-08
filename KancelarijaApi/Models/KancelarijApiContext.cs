using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KancelarijaApi.Models
{
    public class KancelarijApiContext : DbContext
    {
        public KancelarijApiContext(DbContextOptions options): base (options)
        {

        }

        public DbSet<Osoba> Osobe { get; set; }
        public DbSet<Kancelarija> Kancelarije { get; set; }
        public DbSet<Uredjaj> Uredjaji { get; set; }
        public DbSet<OsobaUredjaj> OsobeUredjaji { get; set; }



    }

}
