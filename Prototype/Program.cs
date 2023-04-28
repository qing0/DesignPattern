// See https://aka.ms/new-console-template for more information

//准备
using Prototype;

Manager manager = new Manager();

MessageBox messageBox = new MessageBox("*");
UnderlinePen underlinePen = new UnderlinePen("_");
manager.Register("box", messageBox);
manager.Register("pen", underlinePen);

//生成
Product p1 = manager.Create("box");
p1.Use("Hello World");

Product p2 = manager.Create("pen");
p2.Use("你好");



