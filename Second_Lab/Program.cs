using System.Collections.Immutable;
using First_Lab.Num3.Units;
using First_Lab.Num3.Units.Passanger;
using Second_Lab.builders;
using Second_Lab.directors;

namespace Second_Lab;

static class Program
{ 
    
    
    public static void Main()
    {
        
        
        List<Passenger> busPassengers = new List<Passenger>
        {
            new AdultBusPassenger { Name = "Tom", Age = 30 },
            new ChildBusPassenger { Name = "Sam", Age = 10 },
            new DiscountBusPassenger { Name = "Mike", Age = 65 }
        };


        List<Passenger> taxiPassengers = new List<Passenger>
        {
            new AdultTaxiPassenger() { Name = "Jake", Age = 40},
            new ChildTaxiPassenger() { Name = "Lily", Age = 5, RequiresChildSeat = true }
        };
        
        
        // для автобуса
       BusBuilder busBuilder = new();
       
       BaseDirector baseDirector = new BaseDirector(busBuilder);
       
       baseDirector.Build(BussDriver.GetInstance, busPassengers);
       
       
       // для такси c креслом детским
       Console.WriteLine("\n\n\n##################################");
       TaxiWithChildSeatBuilder taxiWithChildSeatBuilder = new();
       BaseDirector baseDirector2 = new BaseDirector(taxiWithChildSeatBuilder);
       baseDirector2.Build(TaxiDriver.GetInstance, taxiPassengers);
       
       
    }
}