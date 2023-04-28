//工厂模式
//将框架和具体加工解耦
using Factory;

TheFactory factory= new ConcreteFactory();

Product p1=factory.Create("1");
Product p2=factory.Create("2");
Product p3=factory.Create("3");

p1.Use();
p2.Use();
p3.Use();