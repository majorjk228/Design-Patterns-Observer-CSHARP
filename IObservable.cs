﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Observer_CSHARP
{
    // Интерфейс агрегатора, для подписки, отписки, уведомления получателей
    public interface IObservable
    {
        void Subscribe(IObserver observer);
        void Unubscribe(IObserver observer);
        void Notify(News data);
    }
}
