using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetDomain.Models;

namespace FleetDomain.DataSource
{
    public interface IFleetDataSource
    {
        IQueryable<Component> Component { get; }
        IQueryable<Ship> Ships { get;}
        IQueryable<ComponentDuty> ComponentDuties { get; }
        IQueryable<ComponentModel> ComponentModels { get; }
        IQueryable<ComponentStatus> ComponentStatus { get; }
        IQueryable<ComponentType>  ComponentType { get; }
        IQueryable<ShipModel> ShipModels { get; }
        IQueryable<ShipStatus> ShipStatus { get; }
        IQueryable<ShipType> ShipTypes { get; }
    }
}
