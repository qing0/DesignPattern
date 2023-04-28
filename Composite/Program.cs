using Composite;
using Directory = Composite.Directory;
using File = Composite.File;

Entry d1 = new Composite.Directory("root");
Entry d2 = new Composite.Directory("subRoot");
Entry d3 = new Composite.Directory("subSubRoot");

d1.Add(d2);
Entry f1 = new File("subRootFile", 1);
Entry f2 = new File("subSubRootFile", 1);
d2.Add(f1);
d2.Add(d3);
d3.Add(f2);

d1.PrintPath();
Console.WriteLine("---------------");
f2.PrintFullPath();

