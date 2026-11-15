namespace AssignmentSOLIDprincipals;


//Definition: A child class should be replaceable by its parent class without affecting the correctness of the program.
// 
// Case study: In our Purchase Order System, different payment methods should work wherever a payment method is expected.

class Payment
{
    public virtual void Pay()
    {
        Console.WriteLine("Payment payed");
    }
}

class CardPayment : Payment
{
    public override void Pay()
    {
        Console.WriteLine("Payment by card");
    }
}

class UpiPayment : Payment
{
    public override void Pay()
    {
        Console.WriteLine("Payment by UPI");
    }
}
//Explanation: Both CardPayment and UpiPayment can be used wherever a Payment object is expected.


public class LiskovSubstituionPrincipal
{
    
}