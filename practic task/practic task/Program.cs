using System;

class PaymentMethod
{
    public decimal Balance { get; protected set; }

    public PaymentMethod(decimal balance)
    {
        Balance = balance;
    }

    public virtual bool Charge(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            return true;
        }

        return false;
    }
}

class DebitCard : PaymentMethod
{
    public DebitCard(decimal balance) : base(balance)
    {
    }
}

class CreditCard : PaymentMethod
{
    public decimal Limit { get; set; }

    public CreditCard(decimal balance, decimal limit) : base(balance)
    {
        Limit = limit;
    }

    public override bool Charge(decimal amount)
    {
        if (Balance - amount >= -Limit)
        {
            Balance -= amount;
            return true;
        }

        return false;
    }
}

class Program
{
    static void ProcessPayment(PaymentMethod payment, decimal amount)
    {
        bool result = payment.Charge(amount);

        if (result)
            Console.WriteLine("Success");
        else
            Console.WriteLine("Failure");

        Console.WriteLine("Balance = " + payment.Balance);
    }

    static void Main()
    {
        CreditCard credit = new CreditCard(500, 300);
        ProcessPayment(credit, 700);

        DebitCard debit = new DebitCard(500);
        ProcessPayment(debit, 700);
    }
}