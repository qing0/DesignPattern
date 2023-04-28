//单例
using Singleton;

#region 单例
var s1 = TheSingleton.GetInstance();
var s2 = TheSingleton.GetInstance();
Console.WriteLine(s1==s2);
#endregion

#region 三个实例
for(int i = 0; i < 9; i++)
{
    ThreeSingleton.GetInstance(i % 3);
}
#endregion

#region 一个实例序号递增
for(int i = 0; i < 10; i++)
{
   var ss= SerialSingleton.GetInstance();
    ss.GetSerial();

}
#endregion

#region 安全的单例
var sas = SafeSingleton.GetInstance();
var sas1 = SafeSingleton.GetInstance();
Console.WriteLine(sas==sas1);

#endregion