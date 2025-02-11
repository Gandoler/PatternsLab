
using First_Lab;
using First_Lab.Num3.Units;
using First_Lab.Num3.Units.Factory;
using First_Lab.Num3.Units.Passanger;
using First_Lab.Num3.Units.Transport;
using Serilog;


class Program
{

    public static void Main()
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Async(a => a.File("/Users/gl.krutoimail.ru/RiderProjects/PatternsLab/First_Lab/Logs/myapp.log", 
                rollingInterval: RollingInterval.Month))
            .CreateLogger();

        Log.Information("App start");
        First_Lab.ThreadLockSingleton.Instance.HelloWorld(); Log.Information("Hello World in ThreadLockSingleton");
        First_Lab.SingletonLazy.Instance.HelloWorld(); Log.Information("Hello World in SingletonLazy");
        First_Lab.SingletonStaticConstr.Instance.HelloWorld(); Log.Information("Hello World in SingletonStaticConstr");
        
        
        
        
        
        // Создание фабрики для такси
        ITransportationFactory taxiFactory = new TaxiFactory();
        Driver taxiDriver = taxiFactory.CreateDriver("Иван");
        BaseTransport taxi = taxiFactory.CreateVehicle();
        taxi.Depart();
        // Назначение водителя такси
        taxi.SignDriver(taxiDriver);

        // Создание пассажиров
        List<Passenger> passengers = new();
        for (int i = 0; i < 100; i++)
        {
            passengers.Add(new Passenger());
        }
    

        // Посадка 4 пассажиров в такси
        for (int i = 0; i < 4; i++)
        {
            taxi.AddPassanger(passengers[i]);
        }
        taxi.AddPassanger(passengers[5]);

        // Проверка готовности к отправлению
        taxi.Depart();


        Console.WriteLine("\n\n\n");
        // Создание фабрики для автобуса
        ITransportationFactory busFactory = new BussFactory();
        Driver busDriver = busFactory.CreateDriver("Сергей");
        BaseTransport bus = busFactory.CreateVehicle();
        
        // Назначение водителя автобуса
        bus.SignDriver(busDriver);
        
       
        
        // Посадка пассажиров в автобус
        for (int i = 0; i < 31; i++)
        {
            bus.AddPassanger(passengers[i]);
        }
        
        // Проверка готовности к отправлению
        bus.Depart();
    }
}