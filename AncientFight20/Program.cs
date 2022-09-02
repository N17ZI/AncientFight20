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
        Footman sniper = new Footman();
        Mage Rubick = new Mage();
        bool Escape = false;

        while (sniper.health > 0 && Rubick.health > 0)
        {
            /*Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (true)
            {
                TimeSpan timeSpan = TimeSpan.FromSeconds(Convert.ToInt32(stopwatch.Elapsed.TotalSeconds));
                Console.Write(timeSpan.ToString("c"));
                Console.Write('\r');
            }*/
            Console.WriteLine("Здоровье героя - " + sniper.health + "\nЗдоровье врага - " + Rubick.health);
            Console.WriteLine("\nВыберите действие героя:\n1.Атаковать\n2.Восстановить Здоровье\n3.Использовать супер-умение\n4.Попытка убежать\n");

            string UserChoose = Console.ReadLine();
            int pseudoRand = new Random().Next(1, 3);

            if (UserChoose == "1")
            {
                sniper.Attack(Rubick);
                Rubick.Attack(sniper);
                sniper.health += sniper.Armor;
                Console.WriteLine("Вы нанесли урона - " + sniper.Damage + "\nВраг нанес урон по вам - " + Rubick.Damage);
            }
            if (UserChoose == "2")
            {
                
                if (pseudoRand > 1)
                {
                    Console.WriteLine("Вам удалось выпить целебный напиток!");
                    sniper.Heal(sniper);
                }
                else
                {
                    Console.WriteLine("Враг воспользовался вашей беспомощностью во время битвы и нанес урон сквозь броню - " + Rubick.Damage);
                    sniper.health -= Rubick.Damage;
                }
            }
            if (UserChoose == "3")
            {
                Console.WriteLine("Ваш урон увеличен на 2 ед. на 2 атаки");
                sniper.Damage += 2;
            }
            if (UserChoose == "4")
            {
                if(sniper.moveSpeed < Rubick.moveSpeed) { Escape = false; }
                else { Rubick.health = 0; Escape = true ; }
            }
            if (UserChoose == "test")
            {
                Rubick.Damage += 1000;
                Rubick.health += 1000;
                Rubick.Armor += 1000;
            }
            
        }


        if (Escape == true)
        {
            Console.WriteLine("Ты убежал!");
        }
        else if (sniper.health > 0)
        {
            Console.WriteLine("You are winner");
        }
        
        else
        {
            Console.WriteLine("You lose");
        }
    }
}