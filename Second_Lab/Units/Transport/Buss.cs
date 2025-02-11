using First_Lab.Num3.Units.Passanger;

namespace First_Lab.Num3.Units.Transport;

public class Buss:BaseTransport
{
    public Buss() : base(30, License.Dcat) { }

    public new bool AddPassanger(IBusPassenger passenger)
    {
        return base.AddPassanger((Passenger)passenger);
    }
}