namespace First_Lab.Num3.Units.Transport;

public abstract class Transport
{
    protected Driver? Driver;
    protected List<Passanger.Passanger> Passangers;
    protected License License;
    protected readonly int  Capacity;

    protected Transport(int capacity, License license)
    {
        Capacity = capacity;
        License = license;
        Passangers = new List<Passanger.Passanger>();
        
    }
    
    public abstract bool SignDriver(Driver driver);
    public abstract bool AddPassanger(Passanger.Passanger passanger);
    public abstract void Depart();

    
}