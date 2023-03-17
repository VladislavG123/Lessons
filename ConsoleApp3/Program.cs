// See https://aka.ms/new-console-template for more information
// Chat analysis

using System.Collections;
using System.Threading.Channels;


// .NET Framework(2001) 4.7 -> .NET Core (2016) 3.1 -> .NET 5 (2020) -> .NET 7 (2022)
// Blazor, MAUI

// .NET



// C# -> Roslyn (compiler) -> [IL] -> CLR (IL -> 0101)
// F#, VB, Python, C++ ...

// CLR <- .NET


// override, overload


// value types
// exact value,
int b = 1;
int a = b;

System.Int32 c = 5;


// reference types
// classes, interfaces, reference
object b0 = new object();
object a0 = b0;

// stack, heap

// boxing
int d = 5;
object obj = d;


// unboxing
int d2 = (int)obj;


var dict = new Dictionary<object, object>();


dict.Add("A", 1);

Console.WriteLine(dict["A"]);
Console.WriteLine(dict["A"].GetType().ToString());

var ht = new Hashtable();
ht.Add("B", 2);
ht.Add(1, "D");

var res = ht["B"];

switch (a)
{
    case 1:
        Console.WriteLine();
        break;
    default:
        Console.WriteLine();
        break;
}

int a2 = 5;
bool hasValue = true;

var res12 = hasValue switch
{
    true when a2 > 10 => "Maybe",
    true => "Ok",
    _ => "Not ok"
};

Console.WriteLine(res12);


