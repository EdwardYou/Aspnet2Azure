using Lab03.Models.CItyProvModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lab03.Data
{
    public class AddressContext: DbContext
    {
        public AddressContext() : base("DefaultConnection")
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }

    }
}