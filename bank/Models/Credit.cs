namespace bank.Models;
using bank.Abstract;
using System;


internal class Credit
{
    string _id;
    double _amount;
    double _percent;
    string _month;
    string _payment;
    public static List<Credit> credits = new List<Credit>();
    public Credit(Client client, double amount, double percent,
string month, string payment)
    {
        _id = client.GetId();
        _amount = amount;
        _percent = percent;
        _month = month;
        _payment = payment;
    }

    public void CalculatePercent()
    {
        Console.WriteLine("CalculatePercent");
    }
    public void ShowCredit()
    {
        Console.WriteLine("Id: " + _id);
        Console.WriteLine("Amount: " + _amount);
        Console.WriteLine("Percent: " + _percent);
        Console.WriteLine("Month: " + _month);
        Console.WriteLine("Payment: " + _payment);
    }
    public void PayCredit(double money)
    {
        _amount -= money;
    }

    public string GetId() => _id;
}
