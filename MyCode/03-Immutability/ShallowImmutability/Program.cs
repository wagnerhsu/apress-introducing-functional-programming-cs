using Dumpify;
using ShallowImmutability;

var address = new Address { Street = "123 Main St", City = "Anytown" };
var person = new ShallowImmutablePerson("John", "Doe", 30, address);

// person.FirstName, person.LastName, and person.Age are read-only
// person.Address is read-only, but its properties can be modified
person.Address.Street = "456 Elm St";
person.Dump();