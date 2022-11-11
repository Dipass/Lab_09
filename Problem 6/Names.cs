using System;

class Names : IComparer<Person>
{
    public int Compare(Person first, Person second)
    {
        if (first.Name.Length.CompareTo(second.Name.Length) !=0)
        {
            return first.Name.Length.CompareTo(second.Name.Length);
        }
        if (first.Name.Length == second.Name.Length)
        {
            if (first.Name[0] > second.Name[0])
            {
                return first.Name.Length.CompareTo(second.Name.Length);
            }
        }

        return first.Name.Length.CompareTo(second.Name.Length);
    }
}