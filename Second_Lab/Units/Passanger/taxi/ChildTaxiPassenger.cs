namespace First_Lab.Num3.Units.Passanger;

public class ChildTaxiPassenger:Passenger, ITaxiPassanger
{
    public bool RequiresChildSeat { get; set; }

    public ChildTaxiPassenger(int age)
    {
        base.Age = age;
    }
    
    public ChildTaxiPassenger()
    {
        
    }
    public override decimal GetTicketPrice()
    {
        return  122m;
    }
}