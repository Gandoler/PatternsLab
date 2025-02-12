namespace TH_lab.Units.Primitive_objects;

public class Passenger
{
    public string Name { get; set; }
    public int BaggageWeight { get; set; }
    public FlightClass Class { get; set; }

    public Passenger(string name, int baggageWeight, FlightClass passengerClass)
    {
        Name = name;
        BaggageWeight = baggageWeight;
        Class = passengerClass;
    }
}