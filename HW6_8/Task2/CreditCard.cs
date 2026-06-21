namespace HW6_8;

public class CreditCard
{
    public string accountNumber;
    public decimal balance;

    public CreditCard(string accountNumber, decimal balance)
    {
        this.accountNumber = accountNumber;
        this.balance = balance;
    }
    public decimal Deposit(decimal amount)
    {
        if (amount >= 0)
        {
            balance += amount;

        }
        return (balance);
    }
    public decimal Withdrawal(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            return (balance); 
        }
        else
        {
            return (balance);
        }
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Account number {accountNumber} current balance is {balance}");
    }
}