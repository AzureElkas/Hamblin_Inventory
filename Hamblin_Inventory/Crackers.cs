using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamblin_Inventory
{
    class Crackers : IShippable
    {
        public decimal ShipCost { get; } = 0.57M;

        public string Product { get; } = "Crackers";
    }
}
