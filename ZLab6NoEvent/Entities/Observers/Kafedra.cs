namespace ZLab6.Entities;

public class Kafedra : IObserver
{
    private readonly List<IObserver> _observers = new();

   
    public void Update(string message)
    {
        Console.WriteLine($"Кафедра получила уведомление: {message}");
    }
    
}