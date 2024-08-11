using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShallowImmutability;

public record Address
{
    public string Street { get; set; }
    public string City { get; set; }
}