using System;
using System.Collections;

class Person
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

    public override string ToString()
    {
        return $"{Name} {Age} ";
    }

}