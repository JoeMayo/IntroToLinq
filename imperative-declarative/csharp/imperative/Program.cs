using System;
using System.Collections.Generic;

string[] names = new[] {"Sam Young", "Pat Smith", "Joe Mayo"};

List<string> nonJoeNames = new();

for (int i=0; i < names.Length; i++)
{
    string name = names[i];

    if (!name.EndsWith("Mayo"))
    {
        nonJoeNames.Add(name);
    }
}

foreach (string name in nonJoeNames)
{
    Console.WriteLine(name);
}