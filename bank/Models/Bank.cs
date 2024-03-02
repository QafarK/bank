namespace bank.Models;

class Bank:CEO
{
    string? _name;
    int _budget;
    int _profit;

    public string? Name
    {
        get => _name;
        set => _name = value;
    }
    public int Budget
    {
        get => _budget;
        set => _budget = value;
    }
    public int Profit
    {
        get => _profit;
        set => _profit = value;
    }
    public Bank(string name, int budget, int profit, string surname, int age,
        string position, int salary) :base(name, surname,age,position,salary)
    {
        _name = name;
        _budget = budget;
        _profit = profit;
    }
    public Client ReturnClient(int i)
    {
        if (i >= 0 && i < Client.clients.Count)
            return Client.clients[i];
        else
            throw new IndexOutOfRangeException();
    }
    public Worker ReturnWorker(int i)
    {
        if (i >= 0 && i < Worker.workers.Count)
            return Worker.workers[i];
        else
            throw new IndexOutOfRangeException();
    }
    public Manager this[int i]
    {
        get
        {
            if (i >= 0 && i < Manager.managers.Count)
                return Manager.managers[i];
            else
                throw new IndexOutOfRangeException();
        }
    }
    public void Calculate_Profit() => Console.WriteLine("Calculate_Profit");
    public void ShowClientCredit(string fullname)
    {
        bool finded = false;
        foreach (var client in Client.clients)
        {
            if (client.GetName() == fullname)
            {
                finded = true;
                int i = Client.clients.IndexOf(client);
                Credit.credits[i].ShowCredit();
                return;
            }
        }
        if (finded is false)
            throw new FileNotFoundException();
    }
    public void ShowAllCredit()
    {
        foreach (var credit in Credit.credits)
            credit.ShowCredit();
    }
    public void PayCredit(Client client, double money)
    {
        foreach (var credit in Credit.credits)
            if (client.GetId() == credit.GetId())
                credit.PayCredit(money);
    }

}
