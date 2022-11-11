using System;

class Program
{
    static void Main()
    {
        List<Person> list = new List<Person>();
        int weadd=0;
        int dontadd = 0;
        string comand;

        while ((comand = Console.ReadLine()) != "End")
        {
            var people = comand.Split(' ');
            list.Add(new Person(people[0], int.Parse(people[1]), people[2]));
        }
        int index = int.Parse(Console.ReadLine());
        Person forsecond = list[index];

        foreach (var equals in list)
        {
            if (equals.ComparerTo(forsecond) ==0)
            {
                weadd++;
            }
            else
            {
                dontadd++;
            }
        }
        if (weadd > 0)
        {
            Console.WriteLine($"{weadd} {dontadd} {list.Count}");
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }
}