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

  

    public virtual void SignDriver<T>(T driver) where T : Driver
    {
        if (Driver == null)
        {
            if (driver is T)
            {
                if(driver.LicenseInBase == License) Console.WriteLine("С правами все ок");
                Driver = driver;
            }
            else
            {
                Console.WriteLine("вы назначили не того драйвера");
            }
        }
        else
        {
            Console.WriteLine("Водитель уже был назначен");
        }

    }

}