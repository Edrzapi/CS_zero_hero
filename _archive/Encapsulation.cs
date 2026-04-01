// Encapsulation Example in C#
// Encapsulation protects an object's internal state by restricting access
// Only allows changes through defined public methods (getters/setters)
// Promotes data integrity and maintainability

public class BankAccount
{
    // Private field - cannot be accessed directly from outside
    private double balance;

    // Public method to safely deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
            balance += amount;
    }

    // Public method to safely withdraw money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
            balance -= amount;
    }

    // Public getter - allows read-only access to balance
    public double GetBalance()
    {
        return balance;
    }
}
