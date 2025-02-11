using First_Lab.Num3.Units.Transport;

namespace First_Lab.Num3.Units.Factory;

public class BussFactory:ITransportationFactory
{
    public Driver CreateDriver(string name)
    {
        return BussDriver.GetInstance;
    }

    public BaseTransport CreateVehicle()
    {
        return new Buss();
    }
}