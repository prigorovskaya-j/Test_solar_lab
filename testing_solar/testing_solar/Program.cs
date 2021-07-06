using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace testing_solar
{
    class NameList 
    {
        public string name { get; set; } = "NN";
        public int DateTime { get; set; } = 04051991;
        public override string ToString()
        {
            return name + " " + DateTime;
        }
    }
    static class Ex
    {
        static public void Print(this List<NameList> list)
        {
            foreach (var el in list)
            {
                Write(el + " " +"\n");
            }
            WriteLine();
        }
    }
    class Program
    {
        protected static int MenuItem;
        static int MenuSelection()
        {
            Console.WriteLine("Выберите пункт меню!");
            Console.WriteLine("1 - Вывести список дней рождения");
            Console.WriteLine("2 - Вывести ближайшие дни рождения");
            Console.WriteLine("3 - Добавить день рождения");
            Console.WriteLine("4 - Изменить день рождения");
            Console.WriteLine("5 - Удалить день рождения");
            Console.WriteLine("6 - Сохранить в файл");
            Console.WriteLine("7 - Загрузить из файла");
            Console.WriteLine("0 - Выход");
            MenuItem = Convert.ToInt32(Console.ReadLine());
            return MenuItem;
        }
        static void Main(string[] args)
        {
            List<NameList> list = new List<NameList>();
            do
            {
                MenuSelection();
                switch (MenuItem)
                {
                    case 1:
                        Console.WriteLine($"Вы выбрали {MenuItem}");
                        Console.WriteLine("Все дни рождения в списке: ");
                        list.Print();
                        break;
                    case 2:
                        Console.WriteLine($"Вы выбрали {MenuItem}");
                        break;
                    case 3:
                        Console.WriteLine($"Вы выбрали {MenuItem}");
                        Console.WriteLine("Для добавления в список...");
                        Console.WriteLine("Введите имя");
                        string _name = Console.ReadLine();
                        Console.WriteLine("Введите дату (01011999)");
                        int _date = Convert.ToInt32(Console.ReadLine());
                        list.Add(new NameList() { name = _name, DateTime = _date });
                        break;
                    case 4:
                        Console.WriteLine($"Вы выбрали {MenuItem}");
                        break;
                    case 5:
                        Console.WriteLine($"Вы выбрали {MenuItem}");
                        break;
                    case 6:
                        Console.WriteLine($"Вы выбрали {MenuItem}");
                        break;
                    case 7:
                        Console.WriteLine($"Вы выбрали {MenuItem}");
                        break;
                    case 8:
                        Console.WriteLine($"Вы выбрали {MenuItem}");
                        break;
                    default:
                        Console.WriteLine($"Вы выбрали {MenuItem}");
                        break;
                }
            } while (MenuItem != 0);
        }
    }
}
