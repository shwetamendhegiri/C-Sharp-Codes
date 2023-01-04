using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            var Numbers = new List<int>();
            Numbers.Add(1);
            Numbers.Add(3);
            Numbers.Add(5);
            Numbers.Add(7);

            Console.WriteLine("No of elelemts: " + Numbers.Count);

            foreach(var i in Numbers)
            {
                Console.WriteLine(i);
            }

            var cities = new List<string>();
            cities.Add("Mumbai");
            cities.Add("Pune");
            cities.Add("Delhi");
            cities.Add("Banglore");
            cities.Add(null); // null is allowed

            Console.WriteLine("No of elelemts: " + cities.Count);

            foreach (var i in cities)
            {
                Console.WriteLine(i);
            }

            var bigCities = new List<string>() { "Delhi", "Pune", "Mumbai", "Chennai","Noida" };

            Console.WriteLine("No of elelemts: " + bigCities.Count);

            foreach (var i in bigCities)
            {
                Console.WriteLine(i);
            }

            var students = new List<Student>() {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            };

            Console.WriteLine("No of elelemts: " + students.Count);

            foreach(var i in students)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}