namespace ZLab6.Entities;

public class DB: ISubject//синглтон бд
{
    private List<IObserver> _observers = new();

    private bool _reportIsReeady = false;

    static DB()
    {
        Console.WriteLine("Database created");
    }
 
    public static DB Instance { get; } = new();


    public void Attach(IObserver observer) => _observers.Add(observer);
    public void Detach(IObserver observer) => _observers.Remove(observer);
    

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer?.Update("Преподаватель не добавил отчет.");
        }
    }


    public void AddReport()
    {
        _reportIsReeady = true;
    }
    
    public void EndOfWeek()
    {
        if (!_reportIsReeady)
        {
            Notify();
        }
        _reportIsReeady = false;
    }
}