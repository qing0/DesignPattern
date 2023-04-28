
using Strategy;

PrintSort ps1 = new PrintSort(new int[] { 9, 3, 5, 7, 2, 1 }, new SelectionSorter());
ps1.Execute();
PrintSort ps2=new PrintSort(new int[] { 9, 3, 5, 7, 2, 1 }, new BubbleSorter());
ps2.Execute();

PrintSort ps3 = new PrintSort(new int[] { 9, 3, 5, 7, 2, 1 }, new QuickSorter());
ps3.Execute();

//Player p1 = new Player("p1", new WinningStrategy(314));
//Player p2 = new Player("p2", new ProbStrategy(15));

//Random random=new Random();

//for(int i = 0; i < 1000; i++)
//{
//    Hand h1 = p1.NextHand();
//    Hand h2 = p2.NextHand();

//    if (h1.ThisWon(h2))
//    {
//        p1.Win();
//        p2.Lose();
//    }
//    else if (h1.ThisLose(h2))
//    {
//        p1.Lose();
//        p2.Win();
//    }
//    else
//    {
//        p1.Even();
//        p2.Even();
//    }
//    p1.PrintResult();
//    p2.PrintResult();
//}