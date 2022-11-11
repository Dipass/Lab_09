using System;

class Ages : IComparer<Person>
{
    public int Compare(Person first, Person second)
    {
        return first.Age.CompareTo(second.Age);
    }
}