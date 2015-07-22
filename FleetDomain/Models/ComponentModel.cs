using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetDomain.Models
{
    public class ComponentModel
    {
        public virtual int ID { get; set; }
        public virtual String Name { get; set; }
        public virtual ICollection<Component> Components { get; set; }
    }
}
