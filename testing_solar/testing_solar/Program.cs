using System;

namespace testing_solar
{
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
            //Console.WriteLine("8 - Сортировать");
            Console.WriteLine("0 - Выход");
            MenuItem = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine($"MenuItem={MenuItem}");
            return MenuItem;
        }
        static void CallMethod()
        {
            switch (MenuItem) {
                case 1:
                    Console.WriteLine($"Вы выбрали {MenuItem}");
                    break;
                case 2:
                    Console.WriteLine($"Вы выбрали {MenuItem}");
                    break;
                case 3:
                    Console.WriteLine($"Вы выбрали {MenuItem}");
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
        }
        static void Main(string[] args)
        {
            MenuSelection();
            CallMethod();
        }
    }
}
