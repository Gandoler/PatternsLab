namespace First_Lab.Num3.Units.Transport;

public abstract class Transport
{
    public virtual bool SignDriver(Driver driver);
    public bool AddPassanger(Passanger.Passanger passanger);
    public void Depart();

}