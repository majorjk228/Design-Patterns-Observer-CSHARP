using System.Collections.Generic;

namespace Design_Patterns_Observer_CSHARP;

//Главный - Агрегатор новостей
public class NewsAggregator : IObservable
{
    private readonly List<IObserver> observers; // Все наблюдатели

    public NewsAggregator()
    {
        this.observers = new List<IObserver>(); // Присваиваем наблюдателей агрегатору
    }

    public void Subscribe(IObserver observer)
    {
        observers.Add(observer);
    }


    public void Unubscribe(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify(News data)
    {
        foreach (var item in observers)
        {
            item.Update(data);
        }
    }
}