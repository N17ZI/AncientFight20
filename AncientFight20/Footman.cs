﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AncientFight20
{
    internal class Footman : Unit
    {
        public Footman() : base(1000, 80, 73)
        {
            health = 1000;
            moveSpeed = 80;
            Damage = 73;
            Armor = 2;
        }
    }
}
