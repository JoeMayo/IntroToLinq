using System.Linq;

string[] names = new[] {"Sam Young", "Pat Smith", "Joe Mayo"};

var nonJoeNames =
    from name in names
    where !name.EndsWith("Mayo")
    select name;

foreach (string name in nonJoeNames)
    Console.WriteLine(name);