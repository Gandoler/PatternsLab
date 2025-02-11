namespace First_Lab.Num3.Units.Transport;

public interface ITransport
{
    bool SignDriver(Driver driver);
    bool AddPassanger(Passanger.Passanger passanger);
    void Depart();
}