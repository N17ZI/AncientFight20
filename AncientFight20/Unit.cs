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
        public int maxHealth;
        public int ArrowCount;
        public int range;
        public string Name;
        //static int HealAmount = 3;


        public Unit(int health, int moveSpeed, int Damage)
        {
            this.health = health;
            this.moveSpeed = moveSpeed;
            this.Damage = Damage;
            this.maxHealth = maxHealth;
            this.Mana = Mana;
            this.Armor = Armor;
        }
        public void Attack(Unit unit)
        {
            unit.health -= Damage;
        }
        public void Heal(Unit unit)
        {
            if (health > maxHealth)
            {
                health = maxHealth;
            }
            else
            {
                health += 80;
            }
        }
    }
}
