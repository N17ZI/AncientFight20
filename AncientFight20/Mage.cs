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
            Name = "mage";
            health = 800;
            moveSpeed = 90;
            Damage = 52;
            Mana = 100;
            maxHealth = 800;
        }
        public void Bolt(Unit unit)
        {
            if (Mana > 49)
            {
                unit.health -= 100;
                unit.Damage -= 25;
                ManaCost = 50;
                Mana -= ManaCost;
            }
            else if(Mana < 50)
            {
                Console.WriteLine($"Не хватает маны для использования магии - {Mana}");
            }
        }
    }
}
