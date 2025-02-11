using System.Security.Cryptography;

namespace First_Lab.Num3.Units;

public abstract class Driver
{
    public License LicenseInBase { get; protected set; }
    public string Name { get; protected set; }

    protected Driver(string name)
    {
        Name = name;
    }
}
