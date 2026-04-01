// Inheritance Example in C#
// Inheritance enables a class (child) to acquire the properties and behaviors of another class (parent)
// Promotes code reuse and logical hierarchy

// Base class
public class Vehicle
{
    public int Speed;

    // Method shared by all vehicles
    public void Start()
    {
        Console.WriteLine("Vehicle started");
    }
}

// Derived class inherits from Vehicle
public class Car : Vehicle
{
    // Specific behavior added in Car
    public void Honk()
    {
        Console.WriteLine("Car honks");
    }
}

// Usage example
//Car myCar = new Car();
//myCar.Speed = 100;    // Inherited field
//myCar.Start();        // Inherited method
//myCar.Honk();         // Car-specific method

// Note:
// - A derived class can override virtual/abstract methods from its base class
// - C# supports single inheritance (a class can inherit from only one base class)
