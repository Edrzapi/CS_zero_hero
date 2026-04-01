// Abstraction Example in C#
// Abstraction hides complexity by exposing only the essential features of an object
// Useful in managing large codebases by reducing interdependencies

// Abstract classes can include both abstract methods (no implementation)
// and regular methods (with implementation)
// They differ from interfaces which only declare method signatures (before C# 8.0)

public abstract class Animal
{
    // Abstract method - must be implemented by any derived class
    public abstract void MakeSound();

    // Non-abstract method - shared behavior that all animals inherit
    public void Sleep()
    {
        Console.WriteLine("Sleeping...");
    }
}

// Dog inherits from Animal and must implement all abstract members
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

//// Usage example
//Animal myDog = new Dog();
//myDog.MakeSound(); // Output: Bark
//myDog.Sleep();     // Output: Sleeping... (inherited method)
