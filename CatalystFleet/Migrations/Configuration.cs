using FleetDomain.Models;
using FleetDomain.DataSource;

namespace CatalystFleet.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CatalystFleet.Infrasctructure.FleetDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CatalystFleet.Infrasctructure.FleetDb context)
        {
            context.ShipTypes.AddOrUpdate(s => s.Name,
                new ShipType() { Name = "Frigate" }
            );
        }
    }
}
