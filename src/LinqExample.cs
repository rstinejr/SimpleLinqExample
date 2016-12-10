﻿using System;
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

            // 'p => p.Name == "Sam"' is a lambda expression - essentially an anonymous function 
            Person firstSam = people.Where(p => p.Name == "Sam").FirstOrDefault();
            Console.WriteLine("Search result for Name == Sam: {0}", (firstSam == null) ? "<none>" : firstSam.ToString());

            // Works on Lists, arrays, other enumerable collecitons.
            System.Collections.Generic.List<Person> peeps = new System.Collections.Generic.List<Person>(people);
            Person firstSally = peeps.Where(p => p.Name == "Sally" && p.Age > 10).FirstOrDefault();  
            Console.WriteLine("Search result for Name == Sally, Age > 10: {0}", (firstSally == null) ? "<none>" : firstSally.ToString());

            Person firstSue = peeps.Where(p => p.Name == "Sue").FirstOrDefault();
            Console.WriteLine("Search result for Name == Sue: {0}", (firstSue == null) ? "<none>" : firstSue.ToString());

            Console.WriteLine("\npiDigs:");
            int[] piDigs = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3};
            piDigs.ToList().ForEach(i => Console.Write($"{i} "));
            System.Console.WriteLine();
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
