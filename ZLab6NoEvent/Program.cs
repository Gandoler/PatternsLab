using ZLab6.Entities;

namespace ZLab6;

public class Program
{


    public static void Main()
    {
        //создаем
        Prepod prepod = new Prepod("Ivan");
        Deconat deconat = new Deconat();
        Kafedra kafedra = new Kafedra();
        // подписываем
        DB.Instance.Attach(deconat);
        deconat.Attach(kafedra);
        
        // конец недели проверяем работенку а препод ничего не сделла
        DB.Instance.EndOfWeek();
        
        
        
        // теперь обратная ситуация
        Console.WriteLine("\n\nСледующая неделя:");
        prepod.SubmitReport();
        DB.Instance.EndOfWeek();
    }
}