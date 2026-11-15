namespace DelegateAssignment;

class Program
{
    static void Main(string[] args)
    {
        ATM atm = new ATM();

        Console.WriteLine("Welcome to ATM");

        Console.Write("Subscribe to SMS service? (yes/no): ");
        string sms = Console.ReadLine().ToLower();
        
        Console.Write("Subscribe to Whatsapp service? (yes/no): ");
        string whatsapp = Console.ReadLine().ToLower();

        if (sms== "yes")
        {
            atm.SmsEvent += SendSMS;
        }

        if (whatsapp == "yes")
        {
            atm.WhatsappEvent += SendWhatsApp;
        }
        
        Console.WriteLine("Enter Withdrawal Amount:");
        int amount = Convert.ToInt32(Console.ReadLine());
        atm.Withdraw(amount);
        
        
        
    }

    static void SendSMS(string message)
    {
        Console.WriteLine("SMS Notification: "+ message);
    }

    static void SendWhatsApp(string message)
    {
        Console.WriteLine("Whatsapp Notification: " + message);
    }
}