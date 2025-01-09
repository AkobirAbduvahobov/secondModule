namespace _3._1dars;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public double Cash { get; set; }
    public Student()
    {
        
    }
    public Student(string fN, string lN, int age, double cash)
    {
        FirstName = fN;
        LastName = lN;
        Age = age;
        Cash = cash;
    }
}

