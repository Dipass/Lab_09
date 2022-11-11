using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        SortedSet<Person> set = new SortedSet<Person>();
        HashSet<Person> hash = new HashSet<Person>();

        string comand;

        while ((comand = Console.ReadLine()) != "End")
        {
            string[] people = comand.Split(' ');

            Person person = new Person(people[0], int.Parse(people[1]));
            hash.Add(person);
            set.Add(person);
        }

        Console.WriteLine(set.Count);
        Console.WriteLine(hash.Count);

    }
}
