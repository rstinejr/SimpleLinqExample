using System;
using System.Linq;

// Some simple examples using Linq to query or get aggregates of arrays.
namespace Stine.Sample.Linq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person[] people = {
                new Person("Sam", 30, 170),
                new Person("Sally", 12, 100),
                new Person("Sly", 50, 180)
            };

            var samHits = people.Where(p => p.Name == "Sam");
            Console.WriteLine("Search result for Name == Sam: {0}", (samHits.Count() == 0) ? "<none>" : samHits.First().ToString());

            // 'p => p.Name == "Sue"' is a lambda expression - essentially an anonymous function that returns boolean.
            var sueHits = people.Where(p => p.Name == "Sue");
            Console.WriteLine("Search result for Name == Sue: {0}", (sueHits.Count() == 0) ? "<none>" : sueHits.First().ToString());

            int[] piDigs = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3};

            Console.WriteLine($"piDigs count {piDigs.Count()}, avg {piDigs.Average()}, max {piDigs.Max()}");
        }
    }

    internal class Person
    {
        public Person(String name, int age, int weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public string Name { get; }
        public int    Age { get; }
        public int    Weight { get; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}";
        }
    }
}
