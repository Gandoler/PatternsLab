using TH_lab.Units;
using TH_lab.Units.Primitive_objects;

static class Program
{
    public static void Main()
    {
        Airplane airplane = new(30);
        
        //пилоты
        Pilot pilot1 = new("Pilot 1");
        Pilot pilot2 = new("Pilot 2");
        //стюардесы
        Stewardess stewardess1 = new("Stewardess 1",18);
        Stewardess stewardess2 = new("Stewardess 2",32);
        Stewardess stewardess3 = new("Stewardess 3",64);
        Stewardess stewardess4 = new("Stewardess 4",128);
        // пасажиры 
        var passenger1 = new Passenger("Passenger 1", 10, FlightClass.Economy);
        var passenger2 = new Passenger("Passenger 2", 20, FlightClass.First);
        var passenger3 = new Passenger("Passenger 3", 40, FlightClass.Business);
        
        
        airplane.AddPassenger(passenger1);
        airplane.AddPassenger(passenger2);
        airplane.AddPassenger(passenger3);

        airplane.CheckBaggage();
        


    }
}