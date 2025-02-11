namespace First_Lab.Num3.Units.Transport;

public abstract class BaseTransport
{
    protected readonly License License;
    protected Driver? Driver;
    protected List<Passanger.Passanger> Passangers = new();
    protected int Capacity { get; }

    protected BaseTransport(int capacity,  License license)
    {
        Capacity = capacity;
        License = license;
    }

    public bool AddPassanger(Passanger.Passanger passanger)
    {
        if (Passangers.Count < Capacity)
        {
            Passangers.Add(passanger);
            return true;
        }
        return false;
    }

    public virtual void Depart()
    {
        if (Driver != null && Passangers.Count > 0)
        {
            Console.WriteLine("Транспорт отправляется");
        }
        else
        {
            Console.WriteLine("Отправка невозможна: нет водителя или пассажиров");
        }
    }

    public abstract bool SignDriver(Driver driver);
}