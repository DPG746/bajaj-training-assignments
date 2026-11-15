namespace UpCastingAndDownCasting;


internal class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is Eating...");
    }
    /*Dog inherits from Animal.
    We convert the Dog reference into an Animal reference. So we move upwards in the inheritance hierarchy.*/
    
    
}

internal class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is Barking...");
    }
    
    
    
    
}

internal class Program
{
    static void Main(string[] args)
    {
        Dog d= new Dog();

        Animal a = d;  //upcasting
        
        a.Eat();


        Animal a1 = new Dog();

        Dog d2 = (Dog)a1; // downcasting

        d.Eat();
        d.Bark();
        
        /*- (Dog)a explicitly converts the reference to Dog.
           - Now you can access both parent and child class methods.
           - Explicit casting is required.*/
    }
}