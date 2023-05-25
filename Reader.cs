namespace Design_Patterns_Observer_CSHARP;

// Подписчик на новости(читатель)
public class Reader : IObserver // Реализуем интерфейс (наблюдаем за новостным агрегатором)
{
    public string Name { get; set; }

    public Reader(string name)
    {
        Name = name;
    }


    public void Update(News news)
    {
        Console.WriteLine(Name);
        Console.WriteLine(news.Title);
        Console.WriteLine(news.Content);
        Console.WriteLine("-----------------");
        Console.WriteLine();
    }
}