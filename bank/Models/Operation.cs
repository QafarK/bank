namespace bank.Models;
using bank.Abstract;


class Operation
{
    string _process_name;
    string _datetime;
    string _id;
    public static List<Operation> operations = new List<Operation>();
    public Operation(string process_name, string datetime)
    {
        _id = Guid.NewGuid().ToString();
        _process_name = process_name;
        _datetime = datetime;
        operations.Add(this);
    }

    public override string ToString() => "Id: " + _id + "\nProcess name: " + _process_name +
        "\nDatetime: " + _datetime;
}
