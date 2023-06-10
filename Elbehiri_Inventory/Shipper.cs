using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elbehiri_Inventory 
{ 
  class Shipper
{
    public decimal ShipCost;
    public int CountBicycles = 0;
    public int CountLawnMowers = 0;
    public int CountBaseball = 0;
    public int CountCrackers = 0;
    public int TotalCount = 0;
    public string _ProdName = "";

    IShippable Bicycles = new Bicycles();
    IShippable LawnMowers = new LawnMowers();
    IShippable BaseballGloves = new BaseballGloves();
    IShippable Crackers = new Crackers();

    public void Add(string Item)
    {

        if (TotalCount != 10)
        {
            TotalCount += 1;
            if (Item == "Bicycles")
            {
                CountBicycles += 1;
                ShipCost += Bicycles.ShipCost;
                _ProdName = "Bicycles";
            }
            else if (Item == "Lawn Mowers")
            {
                CountLawnMowers += 1;
                ShipCost += LawnMowers.ShipCost;
                _ProdName = "Lawn Mowers";
            }
            else if (Item == "Baseball Gloves")
            {
                CountBaseball += 1;
                ShipCost += BaseballGloves.ShipCost;
                _ProdName = "Baseball Gloves";
            }
            else if (Item == "Crackers")
            {
                CountCrackers += 1;
                ShipCost += Crackers.ShipCost;
                _ProdName = "Crackers";
            }
        }
    }
}
}