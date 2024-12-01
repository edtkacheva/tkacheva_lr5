﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace tkacaheva_lr4
{
    [Serializable]
    [XmlType("tkacheva_headman")]
    public class tkacheva_headman : tkacheva_student
    {
        [XmlElement("group_name")]
        public string group_name { get; set; }
        [XmlElement("email")]
        public string email { get; set; }
        public tkacheva_headman() { }
        public override void create()
        {
            base.create();
            Console.WriteLine("Введите название группы: ");
            group_name = Console.ReadLine();
            Console.WriteLine("Введите почту: ");
            email = Console.ReadLine();
        }
        public override void show()
        {
            base.show();
            Console.WriteLine($"Название группы: {group_name}");
            Console.WriteLine($"Почта: {email}");
        }
    }
}