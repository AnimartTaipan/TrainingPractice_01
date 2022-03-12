using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLV_Task_07
{
    class Program
    { 
        static void Main(string[] args)
        {
            void Print(string word)
            {
                Console.WriteLine(word);
            }


            Print("Введите длину одномерного массива(не больше 15): ");
            int len;
            string lenstr = Console.ReadLine();
            int.TryParse(lenstr, out len);

            while (len <= 0)
            {
                Print("Входе выполнения программы произошла ошибка. Убедитесь в правильности вводимых данных.");
                Print("Введите длину одномерного массива(не больше 15): ");
                lenstr = Console.ReadLine();
                int.TryParse(lenstr, out len);
            }

            int[] arr = new int[len];
            Random rand = new Random();
            Print("Ваш массив: ");

            for (int i = 0; i < len; i++)
            {
                arr[i] = rand.Next(1, 101);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            ShuffleMass(arr);
            Print("Перемешанный массив: ");
            Console.WriteLine(string.Join(" ", arr));
            Console.ReadKey();
        }
        static void ShuffleMass(int[] arr)
        {

            Random rand = new Random();

            for (int i = arr.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);

                int tmp = arr[j];
                arr[j] = arr[i];
                arr[i] = tmp;
            }
        }


    }
}
