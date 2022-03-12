using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLV_Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "password";
            string secretwords = "Ты прирождённый хакер!";
            int tries = 3;

            void Print(string word)
            {
                Console.WriteLine(word);
            }


            Print("Введите пароль для доступа к секретному сообщению: ");
            for (int i = 0; i < 3; i++)
            {
                string userpass = Console.ReadLine();

                if (userpass == password)
                {
                    Print("Ваше секретное сообщение: " + secretwords);
                    
                    break;
                }

                Console.Write("Неверный пароль. Осталось {0} попыток. Введите пароль ещё раз: ", --tries);
            }
            Console.ReadLine();
        }
    }
}
