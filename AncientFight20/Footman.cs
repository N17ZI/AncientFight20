using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AncientFight20
{
    internal class Footman : Unit
    {
        public int health20;
        public Footman() : base(1000, 80, 60)
        {
            Name = "footman";
            health = 1000;
            moveSpeed = 80;
            Damage = 73;
            Armor = 2;
            maxHealth = 1000;
            health20 = (health * 20 / 100);
        }
        public static void Rage(string message)
        {
            Console.WriteLine("You used the rage juice " + message);
        }
    }
}
