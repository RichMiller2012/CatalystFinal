using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetDomain.Models
{
    public class Ship
    {
        public virtual int ID { get; set; }
        public virtual String Name { get; set; }
        public virtual ShipType ShipTypeID { get; set; }
        public virtual ShipStatus ShipStatusID { get; set; }
        public virtual ShipModel ShipModelID { get; set; }
    }
}
