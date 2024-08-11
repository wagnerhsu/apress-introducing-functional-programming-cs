using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShallowImmutability;

public class ShallowImmutablePerson
{
    public string FirstName { get; }
    public string LastName { get; }
    public int Age { get; }
    public readonly Address Address;

    public ShallowImmutablePerson(string firstName, string lastName, int age, Address address)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Address = address;
    }
}

