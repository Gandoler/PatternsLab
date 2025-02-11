namespace First_Lab.Num3.Units.Transport;

public class Buss:BaseTransport
{
    public Buss() : base(30, License.Dcat) { }

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