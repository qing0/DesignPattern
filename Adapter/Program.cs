// See https://aka.ms/new-console-template for more information


using Adapter;


# region 类适配器
Print print=new PrintBanner("newstring");
print.PrintWeak();
print.PrintStrong();
#endregion
#region 委托适配器
Print2 print2=new PrintBanner2("newstring2");
print2.PrintWeak();
print2.PrinStrong();
#endregion