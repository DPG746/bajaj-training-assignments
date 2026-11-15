namespace AssignmentSOLIDprincipals;


//Definition: High-level classes should depend on abstractions (interfaces), not directly on low-level classes.
// 
// Case study: Our Purchase Order System needs to send notifications. Instead of directly depending on an email service, it should depend on a notification interface.

interface INotification
{
    void Send();
}

class EmailNotification : INotification
{
    public void Send()
    {
        Console.WriteLine("Email notification sent");
    }
}

class PurchaseOrder
{
    private INotification notification;

    public PurchaseOrder(INotification notification)
    {
        this.notification = notification;
    }

    public void CreateOrder()
    {
        Console.WriteLine("Order created");
        notification.Send();
    }
}
//Explanation: PurchaseOrder depends on INotification, not directly on EmailNotification. Later, we can use SMS or other notification services without changing the PurchaseOrder class.




public class DependencyInversionPrincipal
{
    
}