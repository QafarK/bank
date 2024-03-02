namespace bank.Models;
using bank.Abstract;
using Interface;
class Manager : PersonData, IOrganization
{
    string _position;
    public static List<Manager> managers = new();
    public Manager(string name, string surname, int age,
        string position, int salary) : base(name, surname, age, salary)
    {
        _position = position;
        managers.Add(this);
    }
    public void Organize()
    {
        Console.WriteLine("Organizing");
    }
    
    public void CalculateSalaries()
    {
        Console.WriteLine("CalculateSalaries");
    }
}
