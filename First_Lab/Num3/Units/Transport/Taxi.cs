

namespace First_Lab.Num3.Units.Transport;


public class Taxi : BaseTransport
{
    public Taxi() : base(4, License.BCat) { }

    public override bool SignDriver(Driver driver)
    {
        if (driver is TaxiDriver)
        {
            Driver = driver;
            return true;
        }
        return false;
    }
}

