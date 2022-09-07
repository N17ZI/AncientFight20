using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AncientFight20
{
    internal class Archer : Unit
    {
        public Archer() : base(850, 95, 55)
        {
            Name = "Archer";
            maxHealth = 850;
            ArrowCount = 20;
        }
        public void Bow(Unit unit)
        {
            unit.health -= 90;
            ArrowCount--;
        }
    }
}
