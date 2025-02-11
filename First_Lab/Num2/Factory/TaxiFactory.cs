using First_Lab.Num3.Units.Transport;

namespace First_Lab.Num3.Units.Factory;

public class TaxiFactory:ITransportationFactory
{
    public Driver CreateDriver(string name)
    {

        return TaxiDriver.GetInstance;
    }

    public BaseTransport CreateVehicle()
    {
        return new Taxi();
    }
}