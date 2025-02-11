namespace First_Lab.Num3.Units.Passanger;

public class ChildBusPassenger:Passenger,IBusPassenger
{
    public override decimal GetTicketPrice()
    {
        return 15m;
    }
}

