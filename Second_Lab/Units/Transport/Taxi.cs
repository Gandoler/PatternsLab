using First_Lab.Num3.Units.Passanger;

namespace First_Lab.Num3.Units.Transport;

public class Taxi : BaseTransport
{
    public bool ChildSeatxist { get; set; }

    public Taxi(bool childSeatExist) : base(4, License.BCat)
    {
        this.ChildSeatxist = childSeatExist;
    }

    public new bool AddPassanger(ITaxiInteface passenger)
    {
        //проверяем, нужно ли пассажиру детское кресло
        if (passenger is ChildTaxiPassenger childPassenger)
        {
           
            if (childPassenger.Age > 14)
            {
                Console.WriteLine("Ребенку больше 14 лет, ему не нужно кресло.");
            }
            else
            {
               
                if (ChildSeatxist)
                {
                    Console.WriteLine("Пассажир с детским креслом добавлен.");
                    return base.AddPassanger((Passenger)passenger); 
                }
                else
                {
                    Console.WriteLine("Пассажир не может быть добавлен: нет детского кресла.");
                    return false;
                }
            }
        }
        
        return base.AddPassanger((Passenger)passenger); 
        
    }
}
