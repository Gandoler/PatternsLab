namespace First_Lab.Num3.Units;

public class TaxiDriver:Driver
{
    private static readonly Lazy<TaxiDriver> _instance =
        new Lazy<TaxiDriver>(() => new TaxiDriver());

    private TaxiDriver() : base("taxiDriver")
    {
        LicenseInBase = License.BCat;
    }

    public static TaxiDriver GetInstance => _instance.Value;
}


