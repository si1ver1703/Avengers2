namespace ADONETExample.Controllers
{
        using global::ADONETExample.Models;
        using System;
        using System.Data.Entity;
        using System.Data.Entity.Infrastructure;

        public partial class MyDBEntities : DbContext
        {
            public MyDBEntities()
                : base("name=MyDBEntities")
            {
            }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                throw new UnintentionalCodeFirstException();
            }

            public virtual DbSet<Avengers> Albums { get; set; }
        }
    }