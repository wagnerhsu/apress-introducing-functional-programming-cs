using FluentAssertions;
using static Curryfy.CurryExtensions;
using static System.Console;

Func<int, int, int, int> sum = (x, y, z) => x + y + z;

var sumCurried = sum.Curry();
WriteLine(sumCurried(2)(5)(7));

var add2 = sumCurried(2).UnCurry();
add2(5, 7).Should().Be(sumCurried(2)(5)(7));