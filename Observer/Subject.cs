using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /// <summary>
    /// 是具体事物的父类，同时管理观察者
    /// </summary>
    internal abstract class Subject
    {
        List<TheObserver> observers= new List<TheObserver>();
        public Subject()
        {
                
        }
        public void AddObserver(TheObserver observer)
        {
            observers.Add(observer);
        }
        public void DelObserver(TheObserver observer)
        {
            observers.Remove(observer);
        }
        protected void NotifyObservers()
        {
            foreach(var observer in observers)
            {
                observer.Update(this);
            }
        }
        public abstract int GetNumber();
        //调用NotifyObservers
        public abstract void Execute();
    }
}
