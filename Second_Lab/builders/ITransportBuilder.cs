using First_Lab.Num3.Units;
using First_Lab.Num3.Units.Passanger;
using First_Lab.Num3.Units.Transport;

namespace Second_Lab.builders;

public interface ITransportBuilder
{
    ITransportBuilder BuildDriver(Driver driver);
    ITransportBuilder BuildPassengers(List<Passenger> passengers);
    BaseTransport BuildVehicle();
}