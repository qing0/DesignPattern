

using Bridge;

Display d1=new Display(new ConcreteDisplay("Hello,China"));
Display d2 = new CountDisplay(new ConcreteDisplay("Hello,World"));
CountDisplay d3 = new CountDisplay(new ConcreteDisplay("Hell0,Hello"));

d1.DisplayStr();
d2.DisplayStr();

d3.DisplayStr();
d3.MultiDisplay(5);

RandomDisplay d4 = new RandomDisplay(new ConcreteDisplay("Hello,Random"));
d4.RandomDisplayStr();


IncreaseDisplay d5 = new IncreaseDisplay(new CharDisplayImpl("<", "c", ">"),5);
d5.IncreaseDisplayStr(5);
