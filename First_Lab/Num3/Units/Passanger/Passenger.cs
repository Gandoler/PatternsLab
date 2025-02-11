namespace First_Lab.Num3.Units.Passanger;

public class Passenger
{
    private int _weight;
    private string _name;

    private string _secondName;

    public string Name
    {
        get => _name;
    }

    public Passenger()
    {
        Random random = new Random();
        _name = random.Next().ToString();
        _weight = random.Next();
        _secondName = random.Next().ToString();
    }
}


