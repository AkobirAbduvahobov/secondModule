namespace _2._8dars.Api;

public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public int CompareTo(Person? other)
    {
        throw new NotImplementedException();
    }
}
