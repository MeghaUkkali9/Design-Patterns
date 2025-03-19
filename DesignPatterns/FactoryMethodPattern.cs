namespace DesignPatterns;

public class FactoryMethodPattern
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Logger Type");
        var type = Console.ReadLine();

        IFactoryLogger factoryLogger = type switch
        {
            "Debug" => new DebugFactoryLogger(),
            "Error" => new ErrorFactoryLogger(),
            "Info" => new InfoFactoryLogger()
        };

        ILogger logger = factoryLogger.CreateLogger();
        logger.log(" Factory method pattern demo");
    }
}

public interface ILogger
{
    public void log(string message);
}

public class DebugLogger : ILogger
{
    public void log(string message)
    {
        Console.WriteLine("Debug Logger" + message);
    }
}

public class ErrorLogger : ILogger
{
    public void log(string message)
    {
        Console.WriteLine("Error Logger" + message);
    }
}

public class InfoLogger : ILogger
{
    public void log(string message)
    {
        Console.WriteLine("Info Logger" + message);
    }
}

public interface IFactoryLogger
{
    public ILogger CreateLogger();
}

public class DebugFactoryLogger : IFactoryLogger
{
    public ILogger CreateLogger()
    {
        return new DebugLogger();
    }
}

public class InfoFactoryLogger : IFactoryLogger
{
    public ILogger CreateLogger()
    {
        return new InfoLogger();
    }
}

public class ErrorFactoryLogger : IFactoryLogger
{
    public ILogger CreateLogger()
    {
        return new ErrorLogger();
    }
}