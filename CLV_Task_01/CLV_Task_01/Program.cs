using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLV_Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
           //Обозначаем переменные
           var random = new Random();
           int goldcoins;
           int crystalprice = random.Next(20, 60);

            void Print(string Words)
            {
                Console.WriteLine(Words);
            }


            Print("Посмотрим, сколько у нас всего золотых монет... ");
            Print("Сколько монет вы насчитали в карманах?: ");

            string mygold = Console.ReadLine();

            int.TryParse(mygold, out goldcoins);

            //Делаем проверку:

            while (goldcoins <= 0)
            {
                Print("Непытайтесь подделать деньги, заменив их на ракушки и фантики!");
                Print("Давайте теперь честно, сколько у вас золота: ");
                mygold = Console.ReadLine();
                int.TryParse(mygold, out goldcoins);
            }


            Print("Цена одного кристалла: " + crystalprice + " монет. Сколько желаете преобрести?: ");


                     int res;
                     string crystlstr = Console.ReadLine();
                     int crystals;
                     int.TryParse(crystlstr, out crystals);



            while (crystals <= 0)
            {
                Print("Я бы предпочёл иметь дело с внимательным торговцем, давай по-новой.");
                Print("Сколько ты хочешь купить кристаллов?: ");
                crystlstr = Console.ReadLine();
                int.TryParse(crystlstr, out crystals);
            }

                            res = goldcoins - crystalprice * crystals;

            while (res < 0)
            {
                Print("Тебе... немного не хватает.");
                Print("Куплено = 0. Остаток золота = " + goldcoins + ".");
                Print("Сколько вы хотите купить кристалов?: ");

                            crystlstr = Console.ReadLine();
                            int.TryParse(crystlstr, out crystals);

                while (crystals <= 0)
                {
                    Print("Я бы предпочёл иметь дело с внимательным торговцем, давай по-новой.");
                    Print("Сколько ты хочешь купить кристаллов?: ");
                    crystlstr = Console.ReadLine();
                    int.TryParse(crystlstr, out crystals);
                }

                            res = goldcoins - crystalprice * crystals;
            }


            Print("Куплено = " + crystals + ". Остаток золота = " + res + ".");
            Console.ReadLine();
        }
    }
}
