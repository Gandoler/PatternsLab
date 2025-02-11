using First_Lab.Num3.Units.Transport;

namespace First_Lab.Num3.Units.Factory;

public interface ITransportationFactory
{
    Driver CreateDriver(string name);
    BaseTransport CreateVehicle();
}