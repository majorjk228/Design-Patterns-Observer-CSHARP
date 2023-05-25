namespace Design_Patterns_Observer_CSHARP
{
    // Паттерн наблюдатель. Главный - Агрегатор новостей, его подписчики, это те кому нужны новости.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            NewsAggregator newsAggregator = new NewsAggregator(); // Агрегатор

            Reader steve = new Reader("Steve"); // 1 читатель
            Reader bill = new Reader("Bill");   // 2 читатель

            newsAggregator.Subscribe(steve); // Подписываем читателя
            newsAggregator.Subscribe(bill);

            News news1 = new News("Title #1", "Content #1"); // Создаем новость
            News news2 = new News("Title #2", "Content #2");
            News news3 = new News("Title #3", "Content #3");

            newsAggregator.Notify(news1); // Уведомляем что поступила новая новость (Теперь наши читатели получают новости)
            Thread.Sleep(1000); // Для реалистичности

            newsAggregator.Notify(news2);
            Thread.Sleep(1000);

            newsAggregator.Unubscribe(bill);
            newsAggregator.Notify(news3);

        }
    }
}