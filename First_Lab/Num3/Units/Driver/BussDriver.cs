namespace First_Lab.Num3.Units;

public class BussDriver: Driver
{
    private static readonly Lazy<BussDriver> _instance =
        new Lazy<BussDriver>(() => new BussDriver());

    private BussDriver() : base("bussDriver")
    {
        LicenseInBase = License.Dcat;
    }

    public static BussDriver Instance => _instance.Value;
}