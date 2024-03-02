namespace bank.Models;
using bank.Abstract;

class Client:PersonData
{
    string _live_address;
    string _work_address;
    public static List<Client> clients = new();

    public Client(string name, string surname,
        int age, int salary, string live_address, string work_address) : base(name, surname, age, salary)
    {
        _live_address = live_address;
        _work_address = work_address;
        clients.Add(this);
    }
    public string GetName() => __name;
}

