namespace First_Lab.Num3.Units.Passanger;

public class AdultTaxiPassenger : Passenger,ITaxiInteface
{
    
    public override decimal GetTicketPrice()
    {
        return 225m; 
    }
}