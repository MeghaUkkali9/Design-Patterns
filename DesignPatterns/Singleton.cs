namespace DesignPatterns;

public class Singleton
{
    private static Singleton _instance;
    private static readonly object Lock = new();
    
    private Singleton()
    {
    }

    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            lock (Lock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
            }
        }

        return _instance;
    }
}