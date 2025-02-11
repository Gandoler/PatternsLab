using System.Security.Cryptography;

namespace First_Lab.Num3.Units;

public abstract class Driver
{
    private static Driver? _instance;
    public License License { get; }
    public string Name { get; protected set; }
    
    protected Driver(string name)
    {
        
        Name = name;
    }
    
    public static Driver GetInstance<T>(string name) where T : Driver, new()
    {
        if (_instance == null)
        {
            _instance = new T { Name = name };
        }
        return _instance;
    }
}
