namespace First_Lab.Num3.Units;

public class BussDriver: Driver
{
    public BussDriver():base("BussDriver") { }
    public static  Driver GetInstance(string name) => GetInstance<BussDriver>(name);

}