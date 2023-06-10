using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Elbehiri_Inventory
{
    class Bicycles : IShippable
    {
        public string Product
        {
            get => "Bicycles";
        }

        public decimal ShipCost
        {
            get => 9.50m;
        }
    }

}