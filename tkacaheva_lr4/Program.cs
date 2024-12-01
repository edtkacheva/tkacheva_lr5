using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using tkacaheva_lr4;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        tkacheva_group studentsGroup = new tkacheva_group();
        while (true)
        {
            Utils.print_menu();
            Console.Write("Выберите действие: ");
            int choice = Utils.get_correct_number();
            switch (choice)
            {
                case 1: studentsGroup.add_student(); break;
                case 2: studentsGroup.add_headman(); break;
                case 3: studentsGroup.view_students(); break;
                case 4: studentsGroup.delete_students(); Console.WriteLine("Данные о студентах были удалены."); break;
                case 5: studentsGroup.save_data(); break;
                case 6: studentsGroup.load_data(); break;
                case 0: return;
                default: Console.WriteLine("Некорректный ввод! Повторите попытку."); break;
            }
        }
    }
}
