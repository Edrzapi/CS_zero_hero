using System;

class ConditionalsDemo
{
    enum MembershipLevel
    {
        Bronze,
        Silver,
        Gold,
        Platinum
    }

    static void methodToHold()
    {
        // Basic if-else ladder
        int age = 25;

        if (age < 18)
        {
            Console.WriteLine("Under 18");
        }
        else if (age >= 18 && age < 65)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Senior");
        }

        // Ternary Operator
        double salary = 20000;
        double rate = (salary < 21000) ? 0.2 : 0.4;
        Console.WriteLine("Rate is " + rate);

        // Logical Operators
        int a = 5, b = 10;
        if (a < b && b > 0)
        {
            Console.WriteLine("Both conditions are true");
        }

        // Switch Statement
        int day = 3;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            default:
                Console.WriteLine("Weekend or invalid day");
                break;
        }

        // Nested Conditionals
        int score = 85;
        if (score >= 60)
        {
            if (score >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else
            {
                Console.WriteLine("Grade: C");
            }
        }
        else
        {
            Console.WriteLine("Failing grade");
        }

        // Using bool flags
        bool isLoggedIn = true;
        bool isAdmin = false;

        if (isLoggedIn)
        {
            if (isAdmin)
            {
                Console.WriteLine("Welcome, admin.");
            }
            else
            {
                Console.WriteLine("Welcome, user.");
            }
        }
        else
        {
            Console.WriteLine("Please log in.");
        }

        // Switch with enum
        MembershipLevel level = MembershipLevel.Gold;

        switch (level)
        {
            case MembershipLevel.Bronze:
                Console.WriteLine("Bronze Member: Basic access");
                break;
            case MembershipLevel.Silver:
                Console.WriteLine("Silver Member: Standard access");
                break;
            case MembershipLevel.Gold:
                Console.WriteLine("Gold Member: Premium access");
                break;
            case MembershipLevel.Platinum:
                Console.WriteLine("Platinum Member: All-access");
                break;
        }
    }
}
