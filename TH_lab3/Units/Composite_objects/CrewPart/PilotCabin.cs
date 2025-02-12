using TH_lab.Units.Primitive_objects;

namespace TH_lab.Units.Composite_objects;

public class PilotCabin
{
    private List<Pilot> _pilots = new();
    private const uint MaxPilots = 2;

    public bool AddPilot(Pilot pilot)
    {
        if (_pilots.Contains(pilot))
        {
            Console.WriteLine($"Пилот {pilot.Name} уже находится в кабине.");
            return false;
        }

        if (_pilots.Count >= MaxPilots)
        {
            Console.WriteLine($"Кабина пилотов уже укомплектована! {pilot.Name} не может занять место.");
            return false;
        }

        _pilots.Add(pilot);
        Console.WriteLine($"Пилот {pilot.Name} успешно занял место в кабине.");
        return true;
    }
}