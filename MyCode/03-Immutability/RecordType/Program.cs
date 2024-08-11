using Dumpify;
using RecordType;

var person = new ImmutablePerson("John", "Doe", 30);
// person.FirstName, person.LastName, and person.Age are read-only
var p = person with { FirstName = "Jane" };
p.Dump();