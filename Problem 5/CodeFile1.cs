using System;
using System.Collections;

class Person /*: IComparer<Person>*/
{
    private string _name;
    private int _age;
    private string _place;

    public Person(string names, int ages, string places)
    {
        _name = names;
        _age = ages;
        _place = places;
    }

    public int ComparerTo(Person anotherPerson)
    {
        if (this._name.CompareTo(anotherPerson._name) != 0)
        {
            return this._name.CompareTo(anotherPerson._name);
        }
        if (this._age.CompareTo(anotherPerson._age) != 0)
        {
            return this._age.CompareTo(anotherPerson._age);
        }

        return this._place.CompareTo(anotherPerson._place);
    }


}