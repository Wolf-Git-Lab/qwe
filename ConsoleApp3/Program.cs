using System;
using System.Text.Json;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person { Name = "Tom", Age = 35 };
            string json = JsonSerializer.Serialize<Person>(tom);
            Console.WriteLine(json);
            Console.ReadKey();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
