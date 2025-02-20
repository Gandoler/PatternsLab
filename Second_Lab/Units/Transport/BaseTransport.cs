
using First_Lab.Num3.Units.Passanger;

namespace First_Lab.Num3.Units.Transport;

public abstract class BaseTransport
{
    protected readonly License License;
    protected Driver? Driver;
    protected List<Passanger.Passenger> Passangers = new();
    protected int Capacity { get; }

    protected BaseTransport(int capacity,  License license)
    {
        Capacity = capacity;
        License = license;
    }

    public bool AddPassanger(Passenger passenger) {
       
        if (Passangers.Count < Capacity)
        {
            Console.WriteLine($"Пассажир добавлен-{passenger.Name} ");
            Passangers.Add(passenger);
            return true;
        }

        Console.WriteLine($"Пассажир  не добавлен ");
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
                Console.WriteLine("водитель назначен");
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