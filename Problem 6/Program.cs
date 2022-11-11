using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        SortedSet<Person> name = new SortedSet<Person>(new Names());
        SortedSet<Person> age = new SortedSet<Person>(new Ages());

        string comand;
        while ((comand = Console.ReadLine()) != "End")
        {
            string[] people = comand.Split(' ');

            Person person = new Person(people[0],int.Parse(people[1]));
            name.Add(person);
            age.Add(person);
        }
        Console.WriteLine("Sorted by Name:");
        foreach (var peoples in name)
        {
            Console.WriteLine(peoples);
        }
        Console.WriteLine("\n Sorted by Age");
        foreach (var peoples in age)
        {
            Console.WriteLine(peoples);
        }

    }
}