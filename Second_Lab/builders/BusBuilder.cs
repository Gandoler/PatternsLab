using First_Lab.Num3.Units;
using First_Lab.Num3.Units.Passanger;
using First_Lab.Num3.Units.Transport;

namespace Second_Lab.builders;

public class BusBuilder: ITransportBuilder
{
    private Buss _buss = new Buss();
    
    public ITransportBuilder BuildDriver(Driver driver)
    {
        if (driver is BussDriver bussDriver)
        {
            _buss.SignDriver(bussDriver);
        }
        else
        {
            throw new Exception("Driver is not BussDriver");
        }

        return this;
    }

    public ITransportBuilder BuildPassengers(List<Passenger> passengers)
    {
        foreach (Passenger passenger in passengers)
        {
            if (passenger is IBusPassenger busPassenger)
            {
                _buss.AddPassanger(busPassenger);
                Console.WriteLine("Passengers added");
            }
            else
            {
                Console.WriteLine("Пассажир не добавлен так как он должен ехать на такси");
            }
        }
        return this;
    }

    public BaseTransport BuildVehicle()
    {
        return _buss;
    }
}