namespace ConsoleApp2;

public class SmsNotificationSender : NotificationSender
{
    public override void Send()
    {
        PublicMethod("5");
    }

    // Constructor
    public SmsNotificationSender()
    {
        Token = "default";
    }
    
    // Поведение
    public void PublicMethod()
    {
        Console.WriteLine(Token);
    }
    
    public int PublicMethod(int a)
    {
        Console.WriteLine(Token + a);
        return 1;
    }

    protected void ProtectedMethod()
    {
        Console.WriteLine("Protected");
    }

    internal void InternalMethod()
    {
        Console.WriteLine("Internal");
    }

    private void PrivateMethod()
    {
        Console.WriteLine("Private");
    }
}