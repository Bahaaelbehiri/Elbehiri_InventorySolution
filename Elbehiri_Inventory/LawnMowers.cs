using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elbehiri_Inventory
{
    class LawnMowers : IShippable
    {
        public string Product
        {
            get => "Lawn Mowers";
        }

        public decimal ShipCost
        {
            get => 24.00m;
        }
    }
}
