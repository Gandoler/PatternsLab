using TH_lab.Units.Primitive_objects;

namespace TH_lab.Units.Composite_objects;

public class CrewCabin
{
    private List<Stewardess> _stewardesses = new();
    private const uint MaxStewardesses = 6;

    public bool AddStewardess(Stewardess stewardess)
    {
        if (_stewardesses.Contains(stewardess))
        {
            Console.WriteLine($"Стюардесса {stewardess.Name} уже находится в экипаже.");
            return false;
        }

        if (_stewardesses.Count >= MaxStewardesses)
        {
            Console.WriteLine($"Места для стюардесс заполнены! {stewardess.Name} не может занять место.");
            return false;
        }

        _stewardesses.Add(stewardess);
        Console.WriteLine($"Стюардесса {stewardess.Name} успешно заняла место в экипаже.");
        return true;
    }
}