using First_Lab.Num3.Units;
using First_Lab.Num3.Units.Passanger;

namespace Second_Lab.directors;

public interface IDerector
{
    public void Build(Driver driver, List<Passenger> passengers);
}