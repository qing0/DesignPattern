using Decorator;

Display d1= new StringDisplay("test");
d1.Show();

Display d2=new SideBorder(d1, '#');
d2.Show();

Display d3 = new FullBorder(d2);
d3.Show();


Display d4=new FullBorder(
    new SideBorder(
        new FullBorder(
            new SideBorder(
                new StringDisplay("newTest"),
                '&')),
        '\\'));

d4.Show();