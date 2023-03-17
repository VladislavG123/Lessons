// OOP:
// Inheritance
// Polymorphism
// Encapsulation


using ConsoleApp2;

int a = 10;

NotificationSender sender;

if (a > 6)
{
    sender = new SmsNotificationSender();
}
else
{
    sender = new EmailNotificationSender();
}

var button = new Button();
button.Click(sender);

class Button
{
    public void Click(NotificationSender sender)
    {
        sender.Send();
    }
    
    public void Click<TNotificationSender>(TNotificationSender sender) 
        where TNotificationSender : NotificationSender
    {
        sender.Send();
    }
}