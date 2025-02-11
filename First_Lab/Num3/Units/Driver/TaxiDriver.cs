namespace First_Lab.Num3.Units;

internal class TaxiDriver:Driver
{
    public TaxiDriver():base("taxiDriver") { }
    public static  Driver GetInstance(string name) => GetInstance<TaxiDriver>(name);
    
}


