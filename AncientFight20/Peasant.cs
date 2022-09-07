using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AncientFight20;

namespace AncientFight20
{
    internal class Peasant : Unit
    {
        public Peasant() : base(500, 100, 3)
        {
            Name = "peasant";
            health = 500;
            moveSpeed = 100;
            Damage = 3;
        }
    }
}
