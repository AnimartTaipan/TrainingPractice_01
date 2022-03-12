using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СLV_Task_04
{
    class Info
    {

        public void Review()
        {
            //Описание персонажа
            Loud("\t                   Добро пожаловать в обзор персонажа!                           \t");
            Sys("Кирана - охотник за головами. Она специализируется на скоростной стрельбе и большом" +
                "\nуроне, однако требует прямых рук для реализации её полного потенциала. Здоровья у" +
                "\nКираны немного, потому выложитесь по-максимуму! Её дерзкие выходки нередко втягивали" +
                "\nеё в самые немыслимые передряги. Но кое-что у неё не отнять - чувство справедливости" +
                "\nи жажда поквитаться со всеми, кто решил использовать свою силу во вред невинным" +
                "\nНе за бесплатно разумеется!");
            Sys(" ");
            Kiranah();

            Next();
            Clear();

           ///////
            Sys("Давайте по-ближе рассмотрим её убийственные спосoбности... " +
                "Быть может охотник за головами - ваше истинное призвание?  ");
            Sys(" ");
            Kiranah2();

            Sys("Способности: " +
               "\n1) Дерзость - Нанесение среднего урона, со стредней точностью                          " +
               "\n2) Стрельба дробью - зависит от расстояния и угла атаки, случайный урон и шанс промаха " +
               "\n3) Перезарядка - увеличение урона, но есть шанс растерять все пули                     " +
               "\n4) УЛЬТИМЕЙТ - Маленький шанс - но огромный урон!                                      " );


            Next();
            Clear();
           ///////
        }


        public void Health( int hpKira, int hpEnemy)
        {
            if (hpKira < 0)
            {
                hpKira = 0;
            }
            else if (hpEnemy < 0)
            {
                hpEnemy = 0;
            }
            Console.Write("У вас - {0} нр" +
                          "\nЗдоровье врага - {1} нр \n\n", hpKira, hpEnemy);
        }


        public void Win()
        {
            Loud("\nИгра окончена. Вы убили врага!");
        }

        public void Lose()
        {
            Loud("\nИгра окончена. Вас убили!");
        }


        public void Kiranah()
        {
            var kirvoice = new Random((int)DateTime.Now.Ticks);
            int kirphrase;
            kirphrase = kirvoice.Next(0, 11);

            switch (kirphrase)
            {
                case 0:
                    Kir("- Я посоветовала бы тебе целиться лучше...");
                    kirphrase = kirvoice.Next(0, 11);
                    break;
                case 1:
                    Kir("- Дорогуша, следи за языком, пока я его не отстрелила.");
                    kirphrase = kirvoice.Next(0, 11);
                    break;
                case 2:
                    Kir("- Угадай: поцелуй или пуля? Что украсит твою мордашку?");
                    kirphrase = kirvoice.Next(0, 11);
                    break;
                case 3:
                    Kir("- Кто не рискует - тот не живёт.");
                    kirphrase = kirvoice.Next(0, 11);
                    break;
                case 4:
                    Kir("- Будь дерзее, мне это нравится.");
                    kirphrase = kirvoice.Next(0, 11);
                    break;
                case 5:
                    Kir("- Кто не рискует - тот не живёт.");
                    kirphrase = kirvoice.Next(0, 11);
                    break;
                case 6:
                    Kir("- Я плевала на то кто ты. И на труп твой - тоже плюю.");
                    kirphrase = kirvoice.Next(0, 11);
                    break;
                case 7:
                    Kir("- Запахло порохом!");
                    kirphrase = kirvoice.Next(0, 11);
                    break;
                case 8:
                    Kir("- Ох-х-х... Вместо всего этого, я бы сейчас по-охотилась на вепрей...");
                    kirphrase = kirvoice.Next(0, 11);
                    break;
                case 9:
                    Kir("- Это-ж сколько мне золота отвалит!");
                    kirphrase = kirvoice.Next(0, 11);
                    break;
                case 10:
                    Kir("- Твоя туша - как пеньята набитая золотом. Так и хочется выбить по-больше.");
                    kirphrase = kirvoice.Next(0, 11);
                    break;
                case 11:
                    Kir("- Просто праздник какой-то!");
                    kirphrase = kirvoice.Next(0, 11);
                    break;
            }
        }

        public void Kiranah2()
        {
            var kirvoice = new Random((int)DateTime.Now.Ticks);
            int kirphrase;
            kirphrase = kirvoice.Next(11, 17);

            switch (kirphrase)
            {
                case 11:
                    Kir("- ХА-ХА-ХА! Наконец-то! ЭКШН!");
                    kirphrase = kirvoice.Next(11, 17);
                    break;
                case 12:
                    Kir("- ХА! 10 очков за отстреленные уши!");
                    kirphrase = kirvoice.Next(11, 17);
                    break;
                case 13:
                    Kir("- НУ-же! Сопротивляйся!");
                    kirphrase = kirvoice.Next(11, 17);
                    break;
                case 14:
                    Kir("- Беги! Твоя спина - удобная мишень!");
                    kirphrase = kirvoice.Next(11, 17);
                    break;
                case 15:
                    Kir("- Ха-ха-ха-ха-ха-ха-ха-ха-ха-ха-ха!!!!");
                    kirphrase = kirvoice.Next(11, 17);
                    break;
                case 16:
                    Kir("- Бам! Бам! Бам! Ха-ха-ха!");
                    kirphrase = kirvoice.Next(11, 17);
                    break;
                case 17:
                    Kir("- Я всегда стреляю первой.");
                    kirphrase = kirvoice.Next(11, 17);
                    break;
            }
        }

        public static void Loud(string Words)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Words);
            Console.ResetColor();

        }
        public static void Kir(string Words)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Words);
            Console.ResetColor();

        }
        public static void Sys(string Words)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(Words);
            Console.ResetColor();

        }

        public void Clear()
        {
            Console.Clear();
        }

        public void Next()
        {
            Console.ReadLine();
        }
    }
}