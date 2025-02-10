
using First_Lab;
using Serilog;


class Program
{

    public static void Main()
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Async(a => a.File("/Users/gl.krutoimail.ru/RiderProjects/PatternsLab/First_Lab/Logs/myapp.log", 
                rollingInterval: RollingInterval.Month))
            .CreateLogger();

        Log.Information("App start");
        First_Lab.ThreadLockSingleton.Instance.HelloWorld(); Log.Information("Hello World in ThreadLockSingleton");
        First_Lab.SingletonLazy.Instance.HelloWorld(); Log.Information("Hello World in SingletonLazy");
        First_Lab.SingletonStaticConstr.Instance.HelloWorld(); Log.Information("Hello World in SingletonStaticConstr");
    }
}