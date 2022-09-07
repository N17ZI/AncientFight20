using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AncientFight20;
class Program
{
    static void Main()
    {
        Footman footman = new Footman();
        Mage mage = new Mage();
        Archer archer = new Archer();
        Blacksmith blacksmith = new Blacksmith();
        Peasant peasant = new Peasant();
        int am = 3;
        
        bool Escape = false;

        while (footman.health > 0 && mage.health > 0)
        {
            Console.WriteLine($"Здоровье героя - {footman.health}\nЗдоровье врага - {mage.health}");
            Console.WriteLine($"\nВыберите действие героя:\n1.Атаковать\n2.Восстановить Здоровье\n3.Использовать супер-умение\n4.Попытка убежать\n5.Upgrade");

            string UserChoose = Console.ReadLine();
            int pseudoRand = new Random().Next(1, 3);
            Console.Clear();

            if (UserChoose == "1")
            {
                /*if(pseudoRand > 1)
                {*/
                    footman.Attack(mage);
                    mage.Attack(footman);
                /*}
                else
                {
                    mage.Bolt(footman);
                    footman.Attack(mage);
                    mage.Mana -= mage.ManaCost;
                    Console.WriteLine("Оставшая Мана - " + mage.Mana);
                }*/
                
                footman.health += footman.Armor;
                Console.WriteLine($"Вы нанесли урона - {footman.Damage}\nВраг нанес урон по вам - {mage.Damage}");
            }
            if (UserChoose == "2")
            {
                if (pseudoRand > 1)
                {
                    Console.WriteLine($"Вам удалось выпить целебный напиток!");
                    footman.Heal(footman);
                }
                else
                {
                    Console.WriteLine("Враг воспользовался вашей беспомощностью во время битвы и нанес урон сквозь броню - " + mage.Damage);
                    footman.health -= mage.Damage;
                }
            }
            if (UserChoose == "3")
            {
                Console.WriteLine("Ваш урон увеличен на 2 ед. на 2 атаки");
                footman.Damage += 2;
            }
            /*if (UserChoose == "4")
            {
                if(footman.moveSpeed < mage.moveSpeed) { Escape = false; }
                else { mage.health = 0; Escape = true ; }
            }*/
            if (UserChoose == "5")
            {
                
                blacksmith.Upgrade(footman);
                Console.WriteLine($"Damage is - {footman.Damage}\nyou have - {am--} upgrades");
            }
            if (UserChoose == "test")
            {
                mage.Damage += 1000;
                mage.health += 1000;
                mage.Armor += 1000;
            }
            
        }


        if (Escape == true)
        {
            Console.WriteLine("Ты убежал!");
        }
        else if (footman.health > 0)
        {
            mage.health = 0;
            Console.WriteLine("You are winner\nLast hp enemy is - " + mage.health);
        }
        
        else
        {
            footman.health = 0;
            Console.WriteLine("You lose\nYour last hp is - " + footman.health);
        }
    }
}
/*Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (true)
            {
                TimeSpan timeSpan = TimeSpan.FromSeconds(Convert.ToInt32(stopwatch.Elapsed.TotalSeconds));
                Console.Write(timeSpan.ToString("c"));
                Console.Write('\r');
            }*/