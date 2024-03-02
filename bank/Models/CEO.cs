namespace bank.Models;
using bank.Abstract;
using Interface;

class CEO : PersonData, IOrganization
{
    protected string __position;
    public CEO(string name, string surname, int age,
        string position, int salary) : base(name, surname, age, salary)
    {
        __position = position;
    }
    public void Organize()
    {
        Console.WriteLine("Organizing");
    }
    public void Control()
    {
        Console.WriteLine("Controlling");
    }
    public void MakeMeeting()
    {
        Console.WriteLine("Making meeting");
    }
    public void DecreasePercent()
    {
        Console.WriteLine("Decreasing Percent");
    }



}
