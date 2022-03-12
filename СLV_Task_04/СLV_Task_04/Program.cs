using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СLV_Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var kiranah = new Kiranah();// Персонаж
            var info = new Info();      // Текст
            var enemy = new Enemy();    // Враг
            var rand = new Random();

            int boost = 0;
            int hpKira = 100; // Здоровье Кираны
            int hpEnemy = 100;// Здоровье Врага

            int move = 1;
            int firstmove = rand.Next(1, 2);

            info.Review();

            while(firstmove == 1)
            {
                //Кирана
                string skill = kiranah.Interface(move);
                hpEnemy = kiranah.skill1(skill, hpEnemy, boost);
                hpEnemy = kiranah.skill2(skill, hpEnemy, move, boost);
                boost = kiranah.skill3(skill, boost);
                hpEnemy = kiranah.skill4(skill, hpEnemy, move, boost);
                //Текущее здоровье
                info.Health(hpKira, hpEnemy);

                if (hpEnemy <= 0) { info.Win(); break; } // Условие проигрыша
                if (hpKira <= 0) { info.Lose(); break; } // Условие выйгрыша
                move++;
                //Враг
                int accuracy = rand.Next(10, 101);
                int powerEnemy = rand.Next(10, 21);
                if (accuracy <= 30)
                {
                    powerEnemy = 0;
                }
                enemy.Interface(move, powerEnemy);
                if (accuracy > 30) // условие с какого шанса попадет
                {
                    hpKira = hpKira - powerEnemy; // Хп игрока уменьшается если босс нанес урон.
                }
                else
                {
                    Console.WriteLine("Осечка! Промах\n");
                }

                info.Health(hpKira, hpEnemy);

                if (hpEnemy <= 0) { info.Win(); break; } // Условие проигрыша
                if (hpKira <= 0) { info.Lose(); break; } // Условие выйгрыша
                move++;
            }
            while(firstmove == 2)
            {
                //Враг
                int accuracy = rand.Next(10, 101);
                int powerEnemy = rand.Next(10, 21);
                if(accuracy <= 30)
                {
                    powerEnemy = 0;
                }
                enemy.Interface(move, powerEnemy);
                if (accuracy > 30) // условие с какого шанса попадет
                {
                    hpKira = hpKira - powerEnemy; // Хп игрока уменьшается если босс нанес урон.
                }
                else
                {
                    Console.WriteLine("Осечка! Промах\n");
                }

                info.Health(hpKira, hpEnemy);

                if (hpEnemy <= 0) { info.Win(); break; } // Условие проигрыша
                if (hpKira <= 0) { info.Lose(); break; } // Условие выйгрыша
                move++;
                //Кирана
                string skill = kiranah.Interface(move);
                hpEnemy = kiranah.skill1(skill, hpEnemy, boost);
                hpEnemy = kiranah.skill2(skill, hpEnemy, move, boost);
                boost = kiranah.skill3(skill, boost);
                hpEnemy = kiranah.skill4(skill, hpEnemy, move, boost);
                //Текущее здоровье
                info.Health(hpKira, hpEnemy);

                if (hpEnemy <= 0) { info.Win(); break; } // Условие проигрыша
                if (hpKira <= 0) { info.Lose(); break; } // Условие выйгрыша
                move++;
            }

            Console.ReadLine();


        }
    }
}
