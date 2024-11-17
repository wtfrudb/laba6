using System;
using System.Xml.Linq;
using static лаба_6_версия_5_.Program;

namespace лаба_6_версия_5_
{
    internal class Program
    {
        public class Person
        {
            public string Name { get; set; } // Обязательное свойство
            public int Age { get; set; }
            public double GPA { get; set; } 
            public string? MiddleName { get; set; }
            public int? SiblingCount { get; set; }
            public double? Height { get; set; }



            public Person(string name, int age, double gpa, string? middleName, int? siblingCount, double? height)
            {
                Name = name;
                Age = age;
                GPA = gpa;
                MiddleName = middleName;
                SiblingCount = siblingCount;
                Height = height;
            }
        }
        public static void PersonInfo(Person person)
        {
            Console.WriteLine($"Имя: {person.Name}");
            Console.WriteLine($"Возраст: {person.Age}");
            Console.WriteLine($"Средний балл (GPA): {person.GPA}");
            Console.WriteLine($"Отчество: {person.MiddleName ?? "Отсутствует"}");
            Console.WriteLine($"Количество братьев/сестер: {person.SiblingCount ?? 0}");
            Console.WriteLine($"Рост: {GetPersonHeight(person)}");
            int nameLength = person.Name!.Length;
            Console.WriteLine($"Длина имени: {nameLength}");
            Console.WriteLine("");
            Console.ReadKey();
        }

        public static void NegativeNullPerson(Person person)
        {
            Console.WriteLine($"Имя: {person.Name}");
            Console.WriteLine($"Возраст: {person.Age}");
            Console.WriteLine($"Средний балл (GPA): {person.GPA}");
            Console.WriteLine($"Отчество: {person.MiddleName ??= "Unknown"}");
            Console.WriteLine($"Количество братьев/сестер: {person.SiblingCount ??= 10}");
            Console.WriteLine($"Рост: {person.Height ??= 210.0}");
            Console.WriteLine("");
            Console.ReadKey();
        }

        private const string DefaultName = "Неизвестно";
        public static string GetPersonName(Person? person)
        {
            return person?.Name ?? DefaultName;
        }

        private const double DefaultHeight = 170;
        public static double GetPersonHeight(Person person)
        {
            return person?.Height ?? DefaultHeight;
        }

        static void Main(string[] args)
        {
            Person Ilya = new Person("Илья", 19, 85.0, "Романович", null, 181.1);
            PersonInfo(Ilya);

            Person? NoName = null;
            Console.WriteLine($"Имя ноунейма: {GetPersonName(NoName)}\n");


            //Person Tania = new Person("Таня", 19, 95.0, null, null, null);
            //PersonInfo(Tania);
            //NegativeNullPerson(Tania);

            //Person Vika = new Person("Вика", 21, 100.0, null, 1, null);
            //PersonInfo(Vika);

            Person Selim = new Person("Селим", 20, 50.0, "Текемедович", 2, 183.2);
            PersonInfo(Selim);
        }
    }
}