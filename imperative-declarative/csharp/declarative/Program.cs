using System.Linq;

string[] names = new[] {"Sam Young", "Pat Smith", "Joe Mayo"};

var nonJoeNames =
    names
        .Where(name => !name.EndsWith("Mayo"))
        .Select(name => name);

foreach (string name in nonJoeNames)
    Console.WriteLine(name);