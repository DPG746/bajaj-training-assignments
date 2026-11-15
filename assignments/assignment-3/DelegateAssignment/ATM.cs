namespace DelegateAssignment;

public delegate void WithdrawNotification(String Message);
public class ATM
{

    public int balance = 5000;
    
    public event WithdrawNotification SmsEvent;
    public event WithdrawNotification WhatsappEvent;

    public void Withdraw(int amount)
    {
        string message;

        if (amount <= 0)
        {
            message = "Withdrawal failed: Enter a valid amount.";
        }
        else if (amount > balance)
        {
            message = $"Withdrawal of Rs.{amount} failed: Insufficient balance.";
        }
        else
        {
            balance = balance - amount;
            message = $"Withdrawal of Rs.{amount} successful. Remaining balance: Rs.{balance}";
        }

        if (SmsEvent != null)
        {
            SmsEvent(message);
        }

        if (WhatsappEvent != null)
        {
            WhatsappEvent(message);
        }

        if (SmsEvent == null &&  WhatsappEvent == null)
        {
            Console.WriteLine("No Notofication service suscribed");
            Console.WriteLine(message);
        }
    }
    
    
}