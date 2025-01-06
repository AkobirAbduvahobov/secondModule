class Program
{
    static void Main(string[] args)
    {
        var hashSet = new HashSet<int> { 1, 2, 8 };
        hashSet.Add(1);
        hashSet.Add(4);

        foreach (var hash in hashSet)
        {
            Console.WriteLine(hash);
        }

    }
}

public class Person
{
    public string FirstName { get; set; }
    public int Age { get; set; }
}