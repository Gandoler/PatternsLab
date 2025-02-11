using First_Lab.Num3.Units;
using First_Lab.Num3.Units.Passanger;
using Second_Lab.builders;

namespace Second_Lab.directors;

public class BaseDirector:IDerector
{
    private ITransportBuilder _builder;
    public BaseDirector(ITransportBuilder builder)
    {
        _builder = builder;
    }

    public void Build(Driver driver, List<Passenger> passengers)
    {
        _builder
            .BuildDriver(driver)
            .BuildPassengers(passengers);
    }
    
}