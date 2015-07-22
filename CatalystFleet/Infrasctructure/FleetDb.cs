using FleetDomain.DataSource;
using FleetDomain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CatalystFleet.Infrasctructure
{
    public class FleetDb : DbContext, IFleetDataSource
    {
        //Db connection entities

        public DbSet<Component> Components { get; set; }
        public DbSet<ComponentDuty> ComponentDuties { get; set; }
        public DbSet<ComponentModel> ComponentModels { get; set; }
        public DbSet<ComponentStatus> ComponentStatus { get; set; }
        public DbSet<ComponentType> ComponentTypes { get; set; }
        public DbSet<Ship> Ships { get; set; }
        public DbSet<ShipModel> ShipModels { get; set; }
        public DbSet<ShipStatus> ShipStatus { get; set; }
        public DbSet<ShipType> ShipTypes { get; set; }


        //IQueryable items below

        IQueryable<Component> IFleetDataSource.Component
        {
            get
            {
                return this.Components;
            }
        }

        IQueryable<Ship> IFleetDataSource.Ships
        {
            get
            {
                return this.Ships;
            }
        }

        IQueryable<ComponentDuty> IFleetDataSource.ComponentDuties
        {
            get
            {
                return this.ComponentDuties;
            }
        }

        IQueryable<ComponentModel> IFleetDataSource.ComponentModels
        {
            get
            {
                return this.ComponentModels;
            }
        }

        IQueryable<ComponentStatus> IFleetDataSource.ComponentStatus
        {
            get
            {
                return this.ComponentStatus;
            }
        }

        IQueryable<ComponentType> IFleetDataSource.ComponentType
        {
            get
            {
                return this.ComponentTypes;
            }
        }

        IQueryable<ShipModel> IFleetDataSource.ShipModels
        {
            get
            {
                return this.ShipModels;
            }
        }

        IQueryable<ShipStatus> IFleetDataSource.ShipStatus
        {
            get
            {
                return this.ShipStatus;
            }
        }

        IQueryable<ShipType> IFleetDataSource.ShipTypes
        {
            get
            {
                return this.ShipTypes;
            }
        }
    }
}