﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamblin_Inventory
{
    class LawnMower : IShippable
    {
        public decimal ShipCost { get; } = 24.00M;

        public string Product { get; } = "Lawn Mower";
    }
}
