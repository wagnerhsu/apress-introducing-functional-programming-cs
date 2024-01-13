using static System.Console;
int a = 10;
var square = GetSquareFunction();
WriteLine($"{square(a)}");
static Func<int,int> GetSquareFunction() => x=>x*x;
