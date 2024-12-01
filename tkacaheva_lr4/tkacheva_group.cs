using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tkacaheva_lr4
{
    [Serializable]
    [XmlType("tkacheva_group")]
    class tkacheva_group
    {
        List<tkacheva_student> students = new List<tkacheva_student>();
        public void add_student()
        {
            tkacheva_student s = new tkacheva_student();
            s.create();
            students.Add(s);
        }

        public void add_headman()
        {
            tkacheva_headman s = new tkacheva_headman();
            s.create();
            students.Add(s);
        }

        public void view_students()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Данных о студентах нет.");
            }
            else
            {
                foreach (tkacheva_student s in students) {
                    s.show();
                }
            }
        }

        public void delete_students()
        {
            students.Clear();
        }

        public void save_data()
        {
            if (students.Count == 0) {
                Console.WriteLine("Нет данных о студентах для сохранения.");
                return;
            }
            Console.WriteLine("Введите название файла: ");
            string filename = Console.ReadLine() + ".xml";
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            Type[] extraTypes = { typeof(tkacheva_headman) };
            XmlSerializer serializer = new XmlSerializer(typeof(List<tkacheva_student>), extraTypes);
            using (StreamWriter writer = new StreamWriter(filename)) {
                try {
                    serializer.Serialize(writer, students, ns);
                    Console.WriteLine("Данные были успешно сохранены в файл.");
                }
                catch (Exception ex) {
                    Console.WriteLine($"Ошибка сохранения данных: {ex.Message}");
                }
            }
        }

        public void load_data()
        {
            Console.WriteLine("Введите название файла: ");
            string filename = Console.ReadLine() + ".xml";
            delete_students();
            Type[] extraTypes = { typeof(tkacheva_headman) };
            XmlSerializer serializer = new XmlSerializer(typeof(List<tkacheva_student>), extraTypes);
            try {
                using (StreamReader reader = new StreamReader(filename)) {
                    students = (List<tkacheva_student>)serializer.Deserialize(reader);
                }
                view_students();
            }
            catch (FileNotFoundException) {
                Console.WriteLine("Файл не найден.");
            }
            catch (Exception ex) {
                Console.WriteLine($"Ошибка загрузки данных: {ex.Message}");
            }
        }
    }
}
