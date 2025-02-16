using System.Threading.Channels;

namespace ZLab6.Entities;

public class Deconat: IObserver, ISubject
{
    private List<IObserver> _observers = new();
    
    public void Attach(IObserver observer) => _observers.Add(observer);
    public void Detach(IObserver observer) => _observers.Remove(observer);
    public void Update(string message)
    {
        Console.WriteLine($"Получили уведомление от бд {message}], передаем кафедре");
        Notify();
    }

    

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer?.Update($"Преподаватель с вашей кафедры не добавил отчет.");
        }
    }
}