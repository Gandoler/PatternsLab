namespace First_Lab.Num3.Units.Passanger;

public class AdultBusPassenger: Passenger, IBusPassenger
{
    public override decimal GetTicketPrice()
    {
       return 40m;
    }
}