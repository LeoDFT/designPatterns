using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Data
{
    public interface ISubscribable
    {
        void SubscribeObserver(IObserver o);
        void UnSubscribeObserver(IObserver o);
        void NotifyObservers();
    }
}
