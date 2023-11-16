using System;
using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // el catmayan classlara catmaq
            // compile time error codu run elemye imkan vermir 


            //Assembly assembly = Assembly.GetExecutingAssembly();
            //assembly.GetTypes();
            //foreach (var item in assembly.GetTypes())
            //{
            //    Console.WriteLine(item.Name);
            //}
            //Person person = new Person();



            /////////////////////// TASK ////////////////////////////
            ///Person classınız olsun, hər dəfə classdan yeni obyekt yarananda, studentin age-i əvvəlki son yaranan studentin yaşından 1 çox olsun.
            Student student = new Student("Dilara");
            Console.WriteLine($"Name: {student.Name} Age: {student.Age}");
            Student student1 = new Student("Fidan");
            Console.WriteLine($"Name: {student1.Name} Age:{student1.Age}");
            Student student2 = new Student("Ayan");
            Console.WriteLine($"Name: {student2} Age: {student2.Age}");





        }
    }
    public class Student
    {
        private static byte lastAge = 0;
        public string Name { get; set; } // privat olanda ne set ne get eleye bilirik
        public byte Age { get; set; }
        public Student(string name)
        {
            Name = name;
            Age = ++lastAge;
        }

    }
}
//////////////////////////////////////////////////////////////////////////////
// Напишите ханойскую башню используя только циклы. 3 стрежня представляют из себя 3 массива. Один массив
// изначально заполнен числами по убыванию. Задача взять переместить все элементы из первого массива в третий.
// Все эти действия выполняются автоматически вашим ботом. Каждое действие должно показываться на экране.