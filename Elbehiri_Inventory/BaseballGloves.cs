using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elbehiri_Inventory
{
    class BaseballGloves : IShippable
    {
        public string Product
        {
            get => "Baseball Gloves";
        }

        public decimal ShipCost
        {
            get => 3.23m;
        }
    }
}

