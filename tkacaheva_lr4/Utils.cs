using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tkacaheva_lr4
{
    class Utils
    {
        public static int get_correct_number()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    return number;
                }
                Console.WriteLine("Некорректный ввод! Повторите попытку.");
            }
        }

        public static void print_menu()
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Добавить студента");
            Console.WriteLine("2. Добавить старосту");
            Console.WriteLine("3. Просмотреть список студентов");
            Console.WriteLine("4. Удалить данные о студентах");
            Console.WriteLine("5. Сохранить данные");
            Console.WriteLine("6. Загрузить данные");
            Console.WriteLine("0. Выход");
        }
    }
}
