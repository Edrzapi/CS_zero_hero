// Data Types in C#

using System;

class DataTypesDemo
{
    public static void datatypeDemo()
    {
        // ===============================
        // Integer types
        // ===============================

        byte eightBit = 255;                 // System.Byte
        short sixteenBit = -32000;           // System.Int16
        int thirtyTwoBit = 2147483647;       // System.Int32
        long sixtyFourBit = 9223372036854775807L; // System.Int64

        // ===============================
        // Floating point types
        // ===============================

        float floatVal = 3.14f;              // System.Single (7 digits of precision)
        double doubleVal = 3.14159265358979; // System.Double (16 digits of precision)
        decimal decimalVal = 3.1415926535897932384626433832M; // System.Decimal (128-bit high precision)

        // ===============================
        // Boolean and Character
        // ===============================

        bool isActive = true;    // System.Boolean
        char initial = 'M';      // System.Char

        // ===============================
        // Displaying the values
        // ===============================

        Console.WriteLine($"byte: {eightBit}, short: {sixteenBit}, int: {thirtyTwoBit}, long: {sixtyFourBit}");
        Console.WriteLine($"float: {floatVal}, double: {doubleVal}, decimal: {decimalVal}");
        Console.WriteLine($"bool: {isActive}, char: {initial}");

        // ===============================
        // Bonus: Aliases for .NET types
        // ===============================
        /*
            In C#, these primitive keywords (like int, bool, etc.)
            are simply *aliases* for .NET value types in the System namespace.

            You can use either form:
                int = System.Int32
                bool = System.Boolean
                char = System.Char
                float = System.Single
                double = System.Double
                decimal = System.Decimal
                etc.

            Example:
                int x = 10;
                System.Int32 y = 10;

            Both are equivalent!

            Unlike Java, you don't need separate wrapper classes.
            All C# value types are structs with built-in methods (e.g., ToString()).
        */
    }
}
