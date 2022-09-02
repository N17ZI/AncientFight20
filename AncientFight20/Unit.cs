using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AncientFight20
{
    internal class Unit
    {
        public int health;
        public int moveSpeed;
        public int Damage;
        public int Mana;
        public int Armor;
        public int ManaCost;

        public Unit(int health, int moveSpeed, int Damage)
        {
            this.health = health;
            this.moveSpeed = moveSpeed;
            this.Damage = Damage;
            this.Mana = Mana;
            this.Armor = Armor;
        }
        public void Attack(Unit unit)
        {
            unit.health -= Damage;
        }
        public void Heal(Unit unit)
        {
            unit.health += 80;
        }
    }
}
