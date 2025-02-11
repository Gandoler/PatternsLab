using First_Lab.Num3.Units;
using First_Lab.Num3.Units.Passanger;
using First_Lab.Num3.Units.Transport;

namespace Second_Lab.builders;

public class TaxiWithChildSeatBuilder: ITransportBuilder
{
    private Taxi _taxi = new Taxi(true);
    public ITransportBuilder BuildDriver(Driver driver)
    {
        if (driver is TaxiDriver taxiDriver)
        {
            _taxi.SignDriver(taxiDriver);
        }
        else
        {
            throw new Exception("Not a TaxiDriver");
        }
        return this;
    }

    public ITransportBuilder BuildPassengers(List<Passenger> passengers)
    {
        foreach (var passenger in passengers)
        {
            if (passenger is ITaxiPassanger taxiPassanger)
            {
                _taxi.AddPassanger(taxiPassanger);
            }
            else
            {
                Console.WriteLine("Not a TaxiPassanger");
            }
        }
        return this;
    }

    public BaseTransport BuildVehicle()
    {
        return _taxi;
    }
}