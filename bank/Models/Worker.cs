namespace bank.Models;
using Abstract;
internal class Worker : PersonData
{
    string _position;
    string _startTime;
    string _endTime;
    public static List<Worker> workers = new List<Worker>();
    public Worker(string name, string surname,
        string position, int age, int salary, string startTime, string endTime) : base(name, surname, age, salary)
    {
        _position = position;
        _startTime = startTime;
        _endTime = endTime;
        workers.Add(this);
    }


    public Operation this[int i]
    {
        get
        {
            if (i >= 0 && i < Operation.operations.Count)
                return Operation.operations[i];
            else
                throw new IndexOutOfRangeException();
        }
        set
        {
            if (i < Operation.operations.Count && Operation.operations[i] is not null)
            {
                Operation.operations[i] = value;
            }
            else if (i >= 0 && Operation.operations[i] is null)
            {
                Operation.operations.Add(value);
            }
            else
                throw new IndexOutOfRangeException();
        }
    }
    public void AddOperation(string process_name, string datetime)
    {
        Operation operation = new Operation(process_name, datetime);
        Operation.operations.Add(operation);
    }
}
