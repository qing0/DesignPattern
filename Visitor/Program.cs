
using Visitor;
using File = Visitor.File;

Entry d1 = new Visitor.Directory("root");
Entry d2=new Visitor.Directory("bin");

Entry f11=new File(1,"f11.txt");
Entry f1=new File(1,"f1.txt");
Entry f2=new File(2,"f2.html");


d1.Add(d2);
d1.Add(f11);
d2.Add(f1);
d2.Add(f2);

d1.Accept(new ListVisitor());

f11.Accept(new ListVisitor());

FileTypeVisitor fileTypeVisitor=new FileTypeVisitor(".txt");

d1.Accept(fileTypeVisitor);
fileTypeVisitor.PrintFileTypes();


d1.Accept(new SizeVisitor());


AddVisitor addVisitor=new AddVisitor(); 
addVisitor.Add(d1);
addVisitor.Add(f1);

addVisitor.Accept(new ListVisitor());