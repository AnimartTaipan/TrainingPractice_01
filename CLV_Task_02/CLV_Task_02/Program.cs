using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLV_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            void Print(string word)
            {
                Console.WriteLine(word);
            } 
            
            string exit = "";

            int tries = 0;

            while (tries<3)
            {
                if (exit == "Exit") { break; }
                Print("Программа выполняется.");
                Print("Если вы хотите закончить выполнение программы - напишите 'Exit'");
                Print("Если вы хотите продолжить выполнение программы - нажмите 'Enter'");
                tries++;
                exit = Console.ReadLine();
            }
        }
    }
}

