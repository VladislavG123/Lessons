namespace ConsoleApp2;

public class EmailNotificationSender : NotificationSender
{
    public override void Send()
    {
        Console.WriteLine("EmailNotificationSender");
    }
}