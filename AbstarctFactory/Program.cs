using AbstarctFactory;


Factory factory = Factory.GetFactory("AbstarctFactory.ListFactory");
Link rmrb=factory.CreateLink("人民日报","http://rmrb");
Link cb = factory.CreateLink("晨报", "http://cb");

Link yh=factory.CreateLink("yahoo","http://yh");    
Link google=factory.CreateLink("google","http://google");
Link baidu=factory.CreateLink("baidu","http://baidu");

Tray tray=factory.CreateTray("新闻");
tray.Add(rmrb);
tray.Add(cb);

Tray tray2=factory.CreateTray("搜索引擎");
tray2.Add(yh);
tray2.Add(google);
tray2.Add(baidu);


Page page = factory.CreatePage("网页", "author");
page.Add(tray);
page.Add(tray2);

page.Output();


Factory tFactory=Factory.GetFactory("AbstarctFactory.TableFactory");
Link trmrb = tFactory.CreateLink("人民日报", "http://rmrb");
Link tcb = tFactory.CreateLink("晨报", "http://cb");

Link tyh = tFactory.CreateLink("yahoo", "http://yh");
Link tgoogle = tFactory.CreateLink("google", "http://google");
Link tbaidu = tFactory.CreateLink("baidu", "http://baidu");

Tray ttray = tFactory.CreateTray("新闻");
ttray.Add(trmrb);
ttray.Add(tcb);

Tray ttray2 = tFactory.CreateTray("搜索引擎");
ttray2.Add(tyh);
ttray2.Add(tgoogle);
ttray2.Add(tbaidu);


Page tpage = tFactory.CreatePage("网页", "author");
tpage.Add(ttray);
tpage.Add(ttray2);

tpage.Output();