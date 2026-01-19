namespace Packt.Shared;

public class BankAccount
{
    public string? AccountName;
    public decimal Balance;

    public static decimal InterestRate; // shared by all BankAccount objects
}