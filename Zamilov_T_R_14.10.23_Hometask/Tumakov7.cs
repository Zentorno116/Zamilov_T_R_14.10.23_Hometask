using System;

enum AccountType
{
    Checking,
    Savings
}

class BankAccount
{
    private string accountNumber;
    private decimal balance;
    private AccountType accountType;

    public BankAccount(string accountNumber, decimal balance, AccountType accountType)
    {
        SetAccountNumber(accountNumber);
        SetBalance(balance);
        SetAccountType(accountType);
    }

    public void PrintAccountInfo()
    {
        Console.WriteLine("Account Number: " + GetAccountNumber());
        Console.WriteLine("Balance: " + GetBalance().ToString("C"));
        Console.WriteLine("Account Type: " + GetAccountType());
    }

    public string GetAccountNumber()
    {
        return accountNumber;
    }

    public void SetAccountNumber(string accountNumber)
    {
        this.accountNumber = accountNumber;
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public void SetBalance(decimal balance)
    {
        this.balance = balance;
    }

    public AccountType GetAccountType()
    {
        return accountType;
    }

    public void SetAccountType(AccountType accountType)
    {
        this.accountType = accountType;
    }
}

class Tumakov7
{
    static void Main(string[] args)

    {
        Console.WriteLine("Упражнение 7.1. Банк.");
        BankAccount account = new BankAccount("1337228", 1337228.00m, AccountType.Checking);

        account.SetAccountNumber("2281337");
        account.SetBalance(2281337.00m);
        account.SetAccountType(AccountType.Savings);

        account.PrintAccountInfo();

        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Упражнение 7.2. Bank v2.0.");
        BankAccount2 account1 = new BankAccount2(228.00m, AccountType.Checking);
        BankAccount2 account2 = new BankAccount2(1337.00m, AccountType.Savings);

        account1.PrintAccountInfo();
        account2.PrintAccountInfo();

        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Упражнение 7.3. Банк v3.0.");

        //BankAccount3 account3 = new BankAccount3("12345", 1000.00m, AccountType.Checking);

        //account.SetAccountNumber("54321");
        //account.SetBalance(2000.00m);
        //account.SetAccountType(AccountType.Savings);

        //account.Withdraw(500.00m);

        //account.Deposit(1000.00m);

        //account.PrintAccountInfo();






    }
}
class BankAccount2
{
    private static int accountCounter = 0;
    private string accountNumber;
    private decimal balance;
    private AccountType accountType;

    public BankAccount2(decimal balance, AccountType accountType)
    {
        accountCounter++;
        accountNumber = GenerateAccountNumber();
        this.balance = balance;
        this.accountType = accountType;
    }

    public void PrintAccountInfo()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Balance: " + balance.ToString("C"));
        Console.WriteLine("Account Type: " + accountType);
    }

    private string GenerateAccountNumber()
    {
        return "NUM" + accountCounter.ToString("D5");
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public void SetBalance(decimal balance)
    {
        this.balance = balance;
    }

    public AccountType GetAccountType()
    {
        return accountType;
    }

    public void SetAccountType(AccountType accountType)
    {
        this.accountType = accountType;
    }
}


class BankAccount3
{
    private static int accountCounter = 0;
    private string accountNumber;
    private decimal balance;
    private AccountType accountType;

    public BankAccount3(decimal balance, AccountType accountType)
    {
        accountCounter++;
        accountNumber = GenerateAccountNumber();
        this.balance = balance;
        this.accountType = accountType;
    }

    public void PrintAccountInfo()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Balance: " + balance.ToString("C"));
        Console.WriteLine("Account Type: " + accountType);
    }

    public void Withdraw(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine("Снято: " + amount.ToString("C"));
        }
        else
        {
            Console.WriteLine("На счете недостаточно средств.");
        }
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine("Положено: " + amount.ToString("C"));
    }

    private string GenerateAccountNumber()
    {
        return "NUM" + accountCounter.ToString("D5");
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public void SetBalance(decimal balance)
    {
        this.balance = balance;
    }

    public AccountType GetAccountType()
    {
        return accountType;
    }

    public void SetAccountType(AccountType accountType)
    {
        this.accountType = accountType;
    }
}






