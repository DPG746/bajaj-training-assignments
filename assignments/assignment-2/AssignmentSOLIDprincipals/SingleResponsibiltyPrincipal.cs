namespace AssignmentSOLIDprincipals;

//Definition: A class should have only one responsibility, meaning it should have only one reason to change.
// 
// Case study: In a Purchase Order System, one class should manage purchase orders, while another class should handle email notifications.

class PurchaseOrder
{
    public void CreateOrder()
    {
        Console.WriteLine("Creating Order");
    }
    
}

class EmailService
{
    public void SendEmail()
    {
        Console.WriteLine("Sending Email");
    }
    
}
//Explanation: PurchaseOrder manages orders, and EmailService sends emails. Each class has a separate responsibility.


public class SingleResponsibiltyPrincipal
{
    
}