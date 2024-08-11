using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecordType
{
    public record ImmutablePerson(string FirstName, string LastName, int Age);
}