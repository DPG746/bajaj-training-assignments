namespace AssignmentSOLIDprincipals;
//Definition: A class should be open for extension but closed for modification.
// 
// Case study: Suppose our Purchase Order System gives different discounts to regular and premium customers. We should be able to add new discount types without modifying existing discount logic.

interface IDiscount
{
    double GetDiscount(double amount);
}

class RegularDiscount : IDiscount
{
    public double GetDiscount(double amount)
    {
        return amount * 0.05;
    }
}

class PremiumDiscount : IDiscount
{
    public double GetDiscount(double amount)
    {
        return amount * 0.10;
    }
}

//Explanation: We can add another discount class by implementing IDiscount, without changing the existing classes.




public class OpenClosePrincipal
{
    
}