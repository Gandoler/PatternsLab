using TH_lab.Units.Primitive_objects;

namespace TH_lab.Units.Composite_objects;

public class FirstClass
{
    private List<Passenger> _passengers = new();
    private const uint MaxValue = 10;

    public bool AddPassenger(Passenger passenger)
    {
        if (_passengers.Contains(passenger))
        {
            Console.WriteLine($"посажир {passenger.Name} уже сел");
            return false;
        }

        if (_passengers.Count >= MaxValue)
        {
            Console.WriteLine($"Отсек переволнен, вынуждены откзать {passenger.Name}");
            return false;
        }
        if (passenger.Class == FlightClass.First)
        {
            _passengers.Add(passenger);
            Console.WriteLine($"Пасажир {passenger.Name} успешно сел");
            return true;
        }
        else
        {
            Console.WriteLine($"{passenger.Name} пытался проскочить к элите - сесеть нельзя");
            return false;
        }
    }
    
    public int GetTotalBaggageWeight()
    {
        return _passengers.Sum(p => p.BaggageWeight);
    }
}