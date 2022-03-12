using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СLV_Task_04
{
    class Kiranah
    {

        public int skill1(string skill, int hpEnemy, int boost)//Дерзость
        {
            var info = new Info();
            var rand = new Random();
            int occ = rand.Next(10, 101);
            switch (skill)
            {
                
                case "0": break;
                case "2": break;
                case "3": break;
                case "4": break;
                
                case "1":
                    occ = rand.Next(10, 101);
                    if (occ > 35)
                    {
                        int damage = rand.Next(5, 15);
                        damage = damage + boost;
                        hpEnemy = hpEnemy - damage;
                        Console.WriteLine("Дерзость: -{0} нр.\n", damage);
                        if(occ > 50)
                        {
                            info.Kiranah();
                        }
                        else
                        {
                            info.Kiranah2();
                        }    
                    }
                    else
                    {
                        Console.WriteLine("Осечка! Промах!\n");
                    }

                    break;

                default:
                    break;
            }
            return hpEnemy;
        }

        public int skill2(string skill, int hpEnemy, int move, int boost)//Стрельба дробью
        {
            var info = new Info();
            var rand = new Random();
            int occ = rand.Next(10, 101);
            switch (skill)
            {

                case "0": break;
                case "2":
                    if (occ > 40)
                    {
                        int damage = rand.Next(0,25);
                        hpEnemy = hpEnemy - damage;
                        Console.WriteLine("Стрельба дробью: -{0} нр.\n", damage);
                        if (occ > 50)
                        {
                            info.Kiranah();
                        }
                        else
                        {
                            info.Kiranah2();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Осечка! Промах!\n");
                    }
                    break;

                case "3": break;
                case "4": break;
                case "1": break;

                default:
                    Console.WriteLine("Осечка! Промах!\n");
                    break;
            }
            return hpEnemy;
        }

        public int skill3(string skill, int boost)//Перезарядка
        {
            var info = new Info();
            var rand = new Random();
            int occ = rand.Next(10, 101);
            switch (skill)
            {

                case "0": break;
                case "2":
                    break;

                case "3":
                    if (occ >= 10 && occ <= 80)
                    {
                        boost = boost + 10;
                        Console.WriteLine("Перезарядка! Вы повысили урон на 10\n");
                        if (occ > 50)
                        {
                            info.Kiranah();
                        }
                        else
                        {
                            info.Kiranah2();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Не удалось повысить урон!\n");
                    }
                    break;

                case "4": break;
                case "1": break;

                default:
                    break;
            }
            return boost;
        }
        public int skill4(string skill, int hpEnemy, int move, int boost)//Тяжелый выстрел
        {
            var info = new Info();
            var rand = new Random();
            int occ = rand.Next(10, 101);
            switch (skill)
            {

                case "0": break;
                case "2":
                    break;

                case "3":
                    break;

                case "4":
                    occ = rand.Next(10, 101);
                    if (occ > 65)
                    {
                        int damage = rand.Next(5, 15);
                        damage = damage + boost;
                        hpEnemy = hpEnemy - (damage * move);
                        Console.WriteLine("Тяжелый выстрел: -{0} нр.\n", damage * move);
                        if (occ > 50)
                        {
                            info.Kiranah();
                        }
                        else
                        {

                            info.Kiranah2();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Осечка! Промах! Слишком рисковый ход!\n");
                    }

                    break;
                case "1": break;

                default:
                    break;
            }
            return hpEnemy;
        }

            public string Interface(int move)
        {
            Console.Write(" "+
                    "\nИгровой такт № - {0}" +
                    "\nАтакует Кирана!" +
                    "\nВаше заклинание: ", move);
            // Ввод заклинаний
            string skill = Console.ReadLine();
           
            return skill;
        }
    }
}
