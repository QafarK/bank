namespace bank.Abstract;

abstract class PersonData
{
    protected string __id;
    protected string __name;
    protected string __surname;
    protected int __age;
    protected int __salary;

    protected PersonData(string name, string surname,
        int age, int salary)
    {
        __id = Guid.NewGuid().ToString();
        __name = name;
        __surname = surname;
        __age = age;
        __salary = salary;
    }
    public virtual string GetId() => __id;

}
