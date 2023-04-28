

using Observer;

using System.Windows;



using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;


//main函数样式模板

internal class Program
{

    private static void Main(string[] args)
    {
        Subject concerteSubject = new ConcereteSubject();

        TheObserver printObserver = new PrintNumObserver();
        TheObserver signalObserver = new SignalObserver();

        concerteSubject.AddObserver(printObserver);
        concerteSubject.AddObserver(signalObserver);

        concerteSubject.Execute();


        Console.WriteLine("================================");

        Subject incrementSubject = new IncrementSubject(10, 100, 12);

        incrementSubject.AddObserver(printObserver);
        incrementSubject.AddObserver(signalObserver);

        incrementSubject.Execute();



      
    }
}