namespace ConsoleApp2;

public abstract class NotificationSender : INotificationSender
{
    public string Token { get; set; }

    public abstract void Send();
    
    internal void PublicMethod(string a)
    {
        Console.WriteLine(a);
    }

    public long Do(int a)
    {
        throw new NotImplementedException();
    }
}

public interface INotificationSender
{
    long Do(int a);
}