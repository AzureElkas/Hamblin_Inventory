using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamblin_Inventory
{
    class Bicycle : IShippable
    {
        public decimal ShipCost { get; } = 9.50M;

        public string Product { get; } = "Bicycle";

    }
}
