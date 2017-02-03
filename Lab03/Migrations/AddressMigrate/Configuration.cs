namespace Lab03.Migrations.AddressMigrate
{
    using Models.CItyProvModel;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Lab03.Data.AddressContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\AddressMigrate";
        }

        protected override void Seed(Lab03.Data.AddressContext context)
        {
            context.Cities.AddOrUpdate(c => new { c.CityId, c.Population }, getCities());
            context.SaveChanges();
            //context.Provinces.AddOrUpdate(p => new { p.ProvinceCode, p.ProvinceName }, getProvince(context));
            //context.SaveChanges();
        }
        private City[] getCities()
        {
            List<City> Cities = new List<City>()
            {
                new City()
                {
                    CityId=1,
                    CityName="AAA",
                    Population=11111
                },
                new City()
                {
                    CityId=2,
                    CityName="BBB",
                    Population=22222
                },
                new City()
                {
                    CityId=3,
                    CityName="CCC",
                    Population=33333
                },
                new City()
                {
                    CityId=4,
                    CityName="DDD",
                    Population=44444
                },
                new City()
                {
                    CityId=5,
                    CityName="EEE",
                    Population=55555
                },
                new City()
                {
                    CityId=6,
                    CityName="FFF",
                    Population=66666
                },
                new City()
                {
                    CityId=7,
                    CityName="GGG",
                    Population=77777
                },
                new City()
                {
                    CityId=8,
                    CityName="HHH",
                    Population=88888
                },
                new City()
                {
                    CityId=9,
                    CityName="III",
                    Population=99999
                },
            };
            return Cities.ToArray();
        }
        private Province[] getProvince(Lab03.Data.AddressContext context)
        {
            List<Province> Provincies = new List<Province>()
            {
                new Province()
                {
                    ProvinceCode="J1",
                    ProvinceName="JJJ",
                    CityId = context.Cities.FirstOrDefault(c => c.CityName=="AAA").CityId
                },
                new Province()
                {
                    ProvinceCode="J2",
                    ProvinceName="JJJ",
                    CityId = context.Cities.FirstOrDefault(c => c.CityName=="BBB").CityId
                },
                new Province()
                {
                    ProvinceCode="J3",
                    ProvinceName="JJJ",
                    CityId = context.Cities.FirstOrDefault(c => c.CityName=="CCC").CityId
                },
                new Province()
                {
                    ProvinceCode="K1",
                    ProvinceName="KKK",
                    CityId = context.Cities.FirstOrDefault(c => c.CityName=="DDD").CityId
                },
                new Province()
                {
                    ProvinceCode="K2",
                    ProvinceName="KKK",
                    CityId = context.Cities.FirstOrDefault(c => c.CityName=="EEE").CityId
                },
                new Province()
                {
                    ProvinceCode="K3",
                    ProvinceName="KKK",
                    CityId = context.Cities.FirstOrDefault(c => c.CityName=="FFF").CityId
                },
                new Province()
                {
                    ProvinceCode="L1",
                    ProvinceName="LLL",
                    CityId = context.Cities.FirstOrDefault(c => c.CityName=="GGG").CityId
                },
                new Province()
                {
                    ProvinceCode="L2",
                    ProvinceName="LLL",
                    CityId = context.Cities.FirstOrDefault(c => c.CityName=="HHH").CityId
                },
                new Province()
                {
                    ProvinceCode="L3",
                    ProvinceName="LLL",
                    CityId = context.Cities.FirstOrDefault(c => c.CityName=="III").CityId
                },

            };
            return Provincies.ToArray();
        }
    }
}
