
///caretaker角色，保存memento角色
///从抽屉中取出memento，给originator角色，以便恢复
using Memento;
using System.Runtime.Serialization.Formatters.Binary;

const string mementoName= "memento.bin";

Gamer gamer = new Gamer(100);
TheMemento memento;
//先从本地文本读取，若不存在，直接创建
if(File.Exists(mementoName))
{
    memento=LoadMemento();
    if (memento != null)
    {
        gamer.Restore(memento);
    }
    else
    {
        memento = gamer.CreateMemento();
    }
}
else
{
    memento = gamer.CreateMemento();
}
//存储原始数据
//memento = gamer.CreateMemento();
for (int i = 0; i < 100; i++)
{
    gamer.Bet();
    Console.WriteLine($"{i}次：{gamer.GetMoney()}");
    if (gamer.GetMoney() > memento.GetMoney())
    {
        Console.WriteLine("暂存新的数据");
        memento = gamer.CreateMemento();
        //存储到本地
        SaveMemento(memento);
       
    }
    else if (gamer.GetMoney() < memento.GetMoney() / 2)
    {
        Console.WriteLine("重置。。。。。。");
        gamer.Restore(memento);
    }

}

TheMemento LoadMemento()
{
    TheMemento memento=null;
    using(FileStream fs=new FileStream(mementoName, FileMode.Open))
    {
        BinaryFormatter binaryFormatter= new BinaryFormatter();
        try
        {
            memento = binaryFormatter.Deserialize(fs) as TheMemento;
        }
        catch (Exception)
        {

           
        }
    }
    return memento;
}
void SaveMemento(TheMemento memento)
{
    using(FileStream fs=new FileStream(mementoName, FileMode.Create))
    {
        BinaryFormatter binaryFormatter= new BinaryFormatter();
        binaryFormatter.Serialize(fs, memento);
      
    }
}
