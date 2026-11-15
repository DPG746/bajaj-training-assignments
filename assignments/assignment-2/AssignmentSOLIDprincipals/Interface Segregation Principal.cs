namespace AssignmentSOLIDprincipals;


//Definition: A class should not be forced to implement methods that it does not need.
// 
// Case study: Suppose our Purchase Order System has different types of users. An admin can approve orders, but a normal customer can only place orders.

interface IOrder
{
    void PlaceOrder();
}

interface IApproval
{
    void ApproveOrder();    
}

class Customer : IOrder
{
    public void PlaceOrder()
    {
            Console.WriteLine("Order Placed");
    }
}

class Admin : IOrder, IApproval
{
    public void PlaceOrder()
    {
        Console.WriteLine("Order Placed");
    }

    public void ApproveOrder()
    {
        Console.WriteLine("Order Approved");
    }
}




//Explanation: Customer only implements IOrder, while Admin implements both interfaces. Neither class is forced to implement unnecessary methods.




public class Interface_Segregation_Principal
{
    
}