using Serilog;

namespace First_Lab;

public class SingletonStaticConstr
{
    //тут  закрытый инициализатор 
    private static readonly SingletonStaticConstr _instance = new();


    static SingletonStaticConstr()
    {
        Log.Information("Singleton StaticConstr - был вызван ");
    }

    public static SingletonStaticConstr Instance
    {
        get
        {
            Log.Information("Выдан обьект в статическом");
            return _instance;
        }
        
    }
    
    public void HelloWorld()
    {
        Console.WriteLine("Hello World"); 
    }
    
}


public class SingletonLazy
{

    private static Lazy<SingletonLazy> _instance = new(() => new());


    SingletonLazy()
    {
        Log.Information("Ленивый конструтор создан");
    }
    public static SingletonLazy Instance
    {
        get
        {
            Log.Information("Выдан обьект в ленивом");
            return _instance.Value;
        }
        
    }
    public void HelloWorld()
    {
        Console.WriteLine("Hello World"); 
    }
    
}


public class ThreadLockSingleton
{
    private static ThreadLockSingleton _instance;
    private static readonly object _lock = new();// рандомный тип
    
    
    static ThreadLockSingleton()
    {
        Log.Information("Потоко закрытый - был вызван ");
    }

    public static ThreadLockSingleton Instance
    {
        get
        {
            if (_instance is null)
            {
                lock (_lock)
                {
                    Log.Information("Создан обьект в Потоко закрытом");
                    _instance = new ThreadLockSingleton();
                }
            }
            Log.Information("выдан обьект в Потоко закрытом");
            return _instance;
            

            Log.Information("Выдан обьект в Потоко закрытом");
            
        }
        
    }

    public void HelloWorld()
    {
        Console.WriteLine("Hello World"); 
    }
}

