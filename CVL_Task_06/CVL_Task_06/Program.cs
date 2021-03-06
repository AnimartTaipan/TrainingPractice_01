using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {

        static public int indexToDelete;

        static void Main(string[] args)
        {
            string[,] dataTable = { { "Василий Пупкин", "президент" }, { "Кирилл Андратьев", "студент" } };
            string[] menu = { "0-Добавить", "1-Удалить", "2-Посмотреть", "3-Выход" };
            int index = 0;

            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.ResetColor();
                Console.WriteLine("\t\tМеню");

                for (int i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine(menu[i]);
                }

                Console.WriteLine("Введите номер пункта меню: ");

                ConsoleKeyInfo userInput = Console.ReadKey(true);

                switch (userInput.Key)
                {
                    case ConsoleKey.D0:
                        dataTable = SelectElementofMenu(0, dataTable);
                        break;
                    case ConsoleKey.D1:
                        dataTable = SelectElementofMenu(1, dataTable);
                        break;
                    case ConsoleKey.D2:
                        dataTable = SelectElementofMenu(2, dataTable);
                        break;
                    case ConsoleKey.D3:
                        SelectElementofMenu(3, dataTable);
                        break;
                    default:
                        break;
                }

            }
        }

        static string[,] SelectElementofMenu(int index, string[,] dataTable)
        {
            switch (index)
            {
                case 0:
                    dataTable = AddElemetToFile(dataTable);
                    break;

                case 1:
                    ShowElementfromFile(dataTable);
                    Console.SetCursorPosition(0, 6);
                    Console.Write("Введите номер сотрудника, которого вы хотите удалить: ");
                    do
                    {
                        try
                        {
                            indexToDelete = Int32.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            break;
                        }
                    } while (isDigit(indexToDelete));
                    dataTable = DeleteElementfromFile(dataTable, indexToDelete);
                    break;
                case 2:
                    ShowElementfromFile(dataTable);
                    break;
                case 3:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
            return dataTable;
        }
        static string[,] AddElemetToFile(string[,] array)        //Добавление сотрудника в досье
        {
            ClearArea();

            Console.Write("Добавление досье.\nВведите имя: ");

            string name;

            do
            {
                name = Console.ReadLine();
            } while (isHaveDigit(name) || String.IsNullOrEmpty(name));

            Console.Write("Введите должность: ");

            string post;

            do
            {
                post = Console.ReadLine();
            } while (isHaveDigit(name) || String.IsNullOrEmpty(name));

            string[,] tempArray = new string[array.GetLength(0) + 1, array.GetLength(1)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    tempArray[i, j] = array[i, j];
                }
            }

            array = tempArray;

            array[array.GetLength(0) - 1, 0] = name;

            array[array.GetLength(0) - 1, 1] = post;

            ShowMessage($"Вы добавили {name} - {post} успешно", ConsoleColor.Yellow);
            return array;
        }

        static string[,] DeleteElementfromFile(string[,] array, int index)
        {
            index -= 1;
            if (index > 0 && index < array.GetLength(0))
            {
                string[,] tempArray = new string[array.GetLength(0) - 1, array.GetLength(1)];

                for (int i = 0; i < index; i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        tempArray[i, j] = array[i, j];
                    }
                }

                for (int i = index; i < tempArray.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        tempArray[i, j] = array[i + 1, j];
                    }
                }

                ShowMessage($"Вы успешно удалили {array[array.GetLength(0) - 1, 0]} - {array[array.GetLength(0) - 1, 1]}", ConsoleColor.Yellow);
                array = tempArray;
            }

            else ShowMessage("Вы выбрали не существующий элемент");

            return array;
        }

        static void ShowElementfromFile(string[,] dataTable)
        {
            ClearArea();
            Console.WriteLine("Список сотрудников");
            for (int i = 0; i < dataTable.GetLength(0); i++)
            {
                Console.WriteLine((i + 1) + "." + dataTable[i, 0] + " - " + dataTable[i, 1]);
            }
        }

        static void ShowMessage(string message, ConsoleColor color = ConsoleColor.Red)
        {
            ClearArea();
            Console.SetCursorPosition(0, 6);
            Console.ForegroundColor = color;
            Console.WriteLine(message + "\t\t\t\t\t");
            Console.ResetColor();
        }
        static void ClearArea(int x = 0, int y = 6)
        {
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < 15; i++)
            {
                Console.ResetColor();
                Console.WriteLine("\t\t\t\t\t\t\t\t");
            }
            Console.SetCursorPosition(x, y);
        }

        static bool isHaveDigit(string data)
        {
            Regex r = new Regex(@"\d");
            Match m = r.Match(data);

            if (m.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool isDigit(int data)
        {
            if (Char.IsDigit(Convert.ToChar(data)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}