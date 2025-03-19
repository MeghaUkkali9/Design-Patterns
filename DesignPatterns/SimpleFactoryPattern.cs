namespace DesignPatterns;

public enum PaymentType
{
    Cash,
    Credit,
    Debit
}

public class SimpleFactoryPattern
{
    public static IPayment CreatePayment(PaymentType paymentType)
    {
        switch (paymentType)
        {
            case PaymentType.Cash: return new Cash();
            case PaymentType.Credit : return new Credit();
            case PaymentType.Debit : return new Debit();
            default: throw new ArgumentException("Unknown payment type");
        }
    }
}

public interface IPayment
{
    void MakePayment();
}

public class Debit : IPayment
{
    public void MakePayment()
    {
        Console.WriteLine("Debit payment");
    }

   
}

public class Credit : IPayment
{
    public void MakePayment()
    {
        Console.WriteLine("Credit payment");
    }
}

public class Cash : IPayment
{
    public void MakePayment()
    {
        Console.WriteLine("Cash payment");
    }
}

public class Program
{
    private static void MainDemo(string[] args)
    {
        IPayment payment = SimpleFactoryPattern.CreatePayment(PaymentType.Credit);
        payment.MakePayment();
    }
}