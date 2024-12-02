using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace tkacaheva_lr4
{
    [Serializable]
    [XmlInclude(typeof(tkacheva_headman))]
    [XmlType("tkacheva_student")]
    public class tkacheva_student
    {
        [XmlElement("name")]
        public string name;
        [XmlElement("last_name")]
        public string last_name;
        [XmlElement("age")]
        public int age;
        public tkacheva_student() { }
        public virtual void create()
        {
            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            last_name = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            age = Utils.get_correct_number();
        }
        public virtual void show()
        {
            Console.WriteLine($"Имя студента: {name}");
            Console.WriteLine($"Фамилия студента: {last_name}");
            Console.WriteLine($"Возраст студента: {age}");
        }
    }
}