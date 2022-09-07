using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AncientFight20
{
    class Blacksmith
    {
        static int Up1 = 3;
        static int Up2 = 3;
        static int Up3 = 3;
        public void Upgrade(Unit unit)
        {
            if (unit.Name == "footman" && Up1 > 0)
            {
                unit.Damage += 10;
                unit.Armor += 5;
                Up1--;
            }

            else if (unit.Name == "peasant" && Up2 > 0)
            {
                unit.Armor += 15;
                Up2--;
            }

            else if (unit.Name == "mage" && Up3 > 0)
            {
                unit.Damage += 15;
                Up3--;
            }
            else
            {
                Console.WriteLine("You dont have skill points!");
            }
        }

/*        public void UpgradeAll()
        {
            for (int i = 0; i < 3; i++)
            {

            }
        }*/
    }
}