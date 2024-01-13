using LanguageExt;
using static System.Console;

Test2(5);
Test2("Hello");

static void Test2(Either<string, int> val)
{
    val.Match
    (
        Right: x => WriteLine($"Correct value: {x}"),
        Left: x => WriteLine($"Incorrect value: '{x}'")
    );
}