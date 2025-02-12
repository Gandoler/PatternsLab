using TH_lab.Units.Primitive_objects;

namespace TH_lab.Units.Composite_objects;

public class EconomyClass
{
    private List<Passenger> _passengers = new();
    private const uint MaxValue = 150;
    
    public List<Passenger> Passengers => _passengers;

    public bool AddPassenger(Passenger passenger)
    {
        if (_passengers.Contains(passenger))
        {
            Console.WriteLine($"Пассажир {passenger.Name} уже находится в эконом-классе.");
            return false;
        }

        if (_passengers.Count >= MaxValue)
        {
            Console.WriteLine($"Эконом-класс переполнен! Отказываем в посадке пассажиру {passenger.Name}.");
            return false;
        }

        if (passenger.Class == FlightClass.Economy)
        {
            _passengers.Add(passenger);
            Console.WriteLine($"Пассажир {passenger.Name} успешно сел в эконом-класс.");
            return true;
        }
        else
        {
            Console.WriteLine($"{passenger.Name} попытался пройти в эконом-класс, но его билет не подходит.");
            return false;
        }
    }

   
    
    public int GetTotalBaggageWeight()
    {
        return _passengers.Sum(p => p.BaggageWeight);
    }
}