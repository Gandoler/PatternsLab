namespace First_Lab.Num3.Units.Passanger;

public class DiscountBusPassenger:Passenger, IBusPassenger
{
    public override decimal GetTicketPrice()
    {
        return 10m;
    }
}