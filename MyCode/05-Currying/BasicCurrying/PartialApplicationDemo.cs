using static Curryfy.PartialIncrementalFuncExtensions;

namespace BasicCurrying;

public class PartialApplicationDemo
{
    public static void MainMethod()
    {
        Func<int, int, int, int> sum = (x, y, z) => x + y + z;
        var add2 = sum.ApplyPartial(2);
        WriteLine(add2(3, 4));
        var add3 = sum.ApplyPartial(3);
        WriteLine(add3(3, 4));
    }
}