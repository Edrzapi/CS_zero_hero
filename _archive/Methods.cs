using System;

class MethodsDemo
{
    // Method with no parameters and no return
    static void SayHello()
    {
        Console.WriteLine("Hello!");
    }

    // Method with parameters and no return
    static void PrintSum(int a, int b)
    {
        Console.WriteLine("Sum: " + (a + b));
    }

    // Method with return value
    static int Multiply(int a, int b)
    {
        return a * b;
    }

    // Method Overloading
    static int Add(int x, int y) => x + y;
    static int Add(int x, int y, int z) => x + y + z;

    static void methodToHold()
    {
        SayHello();
        PrintSum(3, 5);

        int result = Multiply(4, 6);
        Console.WriteLine("Product: " + result);

        Console.WriteLine("Add(2, 3): " + Add(2, 3));
        Console.WriteLine("Add(1, 2, 3): " + Add(1, 2, 3));
    }
}
