using System.Linq;
string[] names = { "dong", "hai", "log", "ngan ha", "albedo chalkprince", "diuc regvenger"};
var orderedNames = names.OrderBy(x => x.Length);
foreach (var name in orderedNames)
{
    Console.WriteLine(name);
}

Console.WriteLine("=============");
SortedSet<string> sorted = new SortedSet<string>(names);
foreach (var name in sorted)
{
    Console.WriteLine(name);
}
Console.WriteLine("=============");
foreach (var a in names.Select(x => x.Contains("a")))
{
    Console.WriteLine(a);
}

Console.WriteLine("=============");

var items = from w in names
            where w.Length > 4
            select w;
foreach (var item in items)
{
    Console.WriteLine(item);
}
Console.WriteLine("=============");
foreach (var a in names.Where(n => n.Length > 4))
{
    Console.WriteLine(a);
}