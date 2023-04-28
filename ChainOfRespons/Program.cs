
using ChainOfRespons;

Support noS = new NoSupport("no");
Support oddS=new OddSupport("odd");
Support limitS=new LimitSupport("limit",8000);
Support specialS=new SpecialSupport("special",1000);

Support limitS2= new LimitSupport("limit",200);
Support specialS2=new SpecialSupport("special2",2000);

noS.SetNext(oddS).SetNext(limitS).SetNext(limitS2).SetNext(specialS).SetNext(specialS2);

for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"处理问题{i}");
    noS.SupportFun(new Trouble(new Random().Next(9999)));
}