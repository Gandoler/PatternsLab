using TH_lab.Units.Composite_objects;
using TH_lab.Units.Primitive_objects;

namespace TH_lab.Units;

public class Airplane
{
    private FirstClass _firstClass = new();
    private BusinessClass _businessClass = new();
    private EconomyClass _economyClass = new();
    
    private PilotCabin _pilotCabin = new();
    private CrewCabin _crewCabin = new();
    
    public readonly int MaxBaggageWeight;
    private int currentBaggageWeight;

    public Airplane(int maxWeight)
    {
        MaxBaggageWeight = maxWeight;
    }

    public bool CheckBaggage()
    {
        currentBaggageWeight= 
            _firstClass.GetTotalBaggageWeight()+
            _economyClass.GetTotalBaggageWeight()+ 
            _economyClass.GetTotalBaggageWeight();
        int excessBaggage = currentBaggageWeight - MaxBaggageWeight;

        if (excessBaggage > 0)
        {
            Console.WriteLine($"Превышение: {excessBaggage} kg");

            if (RemoveExcessBaggage(excessBaggage) == 0)
            {
                Console.WriteLine("Превышение удалось решить");
                return true;
            }
            else
            {
                return false;
            }
            
        }
        else
        {
            Console.WriteLine("Превышения нет");
            return true;
        }
    }

    private int RemoveExcessBaggage(int excessBaggage)
    {
        foreach (var passenger in _economyClass.Passengers)
        {
            if (excessBaggage <= 0)
            {
                return 0;
            }

         
            int baggageToRemove = Math.Min(passenger.BaggageWeight, excessBaggage);
            passenger.BaggageWeight -= baggageToRemove;
            excessBaggage -= baggageToRemove; 

            currentBaggageWeight -= baggageToRemove;

            Console.WriteLine($"Removed {baggageToRemove} kg baggage from {passenger.Name}.");
        }

        if (excessBaggage > 0)
        {
            Console.WriteLine($"Не удалось полностью снять превышение багажа. Осталось {excessBaggage} кг.");
            return excessBaggage;
        }

        return 0;
    }
    
    public bool AddPilot(Pilot pilot)
    {
        return _pilotCabin.AddPilot(pilot);
    }
    
    
    public bool AddCrew(Stewardess stewardess)
    {
        return _crewCabin.AddStewardess(stewardess);
    }
    
    public bool AddPassenger(Passenger passenger)
    {
        switch (passenger.Class)
        {
            case FlightClass.First:
                return _firstClass.AddPassenger(passenger);
                 break;
            case FlightClass.Business:
                return _businessClass.AddPassenger(passenger);
                break;
            case FlightClass.Economy:
                return _economyClass.AddPassenger(passenger);
                break;
            default:
                Console.WriteLine("Нет такого класса");
                
                break;
        }
        
        return false;
    }


}