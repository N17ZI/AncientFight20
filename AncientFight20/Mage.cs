using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AncientFight20
{
    internal class Mage : Unit
    {
        public Mage() : base(800, 90, 52)
        {
            health = 800;
            moveSpeed = 90;
            Damage = 52;
            Mana = 100;
        }
        public void Bolt(Unit unit)
        {
            unit.health -= 100;
            unit.Damage *= 3 / 4;
        }
    }
}
