using TH_lab.Units.Primitive_objects;

namespace TH_lab.Units.Composite_objects;

public class BusinessClass
{
    
    private List<Passenger> _passengers = new();
    private const uint MaxValue = 20;

    public bool AddPassenger(Passenger passenger)
    {
        if (_passengers.Contains(passenger))
        {
            Console.WriteLine($"Пассажир {passenger.Name} уже находится в бизнес-классе.");
            return false;
        }

        if (_passengers.Count >= MaxValue)
        {
            Console.WriteLine($"Бизнес-класс переполнен! Отказываем в посадке пассажиру {passenger.Name}.");
            return false;
        }

        if (passenger.Class == FlightClass.Business)
        {
            _passengers.Add(passenger);
            Console.WriteLine($"Пассажир {passenger.Name} успешно сел в бизнес-класс.");
            return true;
        }
        else
        {
            Console.WriteLine($"{passenger.Name} попытался пройти в бизнес-класс без билета - доступ запрещен!");
            return false;
        }
    }
    
    public int GetTotalBaggageWeight()
    {
        return _passengers.Sum(p => p.BaggageWeight);
    }
}