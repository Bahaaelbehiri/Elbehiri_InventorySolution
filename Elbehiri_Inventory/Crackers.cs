using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elbehiri_Inventory
{
    class Crackers : IShippable
    {
        public string Product
        {
            get => "Crackers";
        }

        public decimal ShipCost
        {
            get => .57m;
        }
    }
}
