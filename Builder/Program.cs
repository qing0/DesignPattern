// See https://aka.ms/new-console-template for more information
using Builder;

TxtBuilder txtBuilder= new TxtBuilder();
Director txtDirector = new Director(txtBuilder);
txtDirector.Constrcut();
Console.WriteLine(txtBuilder.GetResult());
HtmlBuilder htmlBuilder= new HtmlBuilder();
Director htmlDirector = new Director(htmlBuilder);
htmlDirector.Constrcut();
Console.WriteLine(htmlBuilder.GetResult()+"文件编写完成");