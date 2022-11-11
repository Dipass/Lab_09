using System;
using System.Collections;
using System.Collections.Generic;

public class Person : IComparable<Person>
{
    private int _age;
    private string _name;

    public Person(string names, int ages)
    {
        _name = names;
        _age = ages;
    }

    public string Name
    {
        get
        {
            return _name;
        }
        private set
        {

        }
    }

    public int Age
    {
        get
        {
            return _age;
        }
        private set
        {

        }
    }

    public int CompareTo(Person people2)
    {
        if (Name.CompareTo(people2.Name) != 0)
        {
            return Name.CompareTo(people2.Name);
        }
        return Age.CompareTo(people2.Age);
    }
    public override int GetHashCode()
    {
        return Name.GetHashCode() + Age.GetHashCode();
    }
    public override bool Equals(object? obj)
    {
        if (obj.GetHashCode() == (Name.GetHashCode() + Age.GetHashCode()))
        {
            return true;
        }

        return false;
    }
}