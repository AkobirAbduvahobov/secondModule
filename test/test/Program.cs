using System.Runtime.CompilerServices;
using test;

class Program
{
    static void Main(string[] args)
    {

        Student student1 = new Student()
        {
            Age = 45,
            FirstName = "Bob",
            LastName = "Max"
        };

        Student student2 = new Student()
        {
            Age = 23,
            FirstName = "Croood",
            LastName = "Mom"
        };

        Student student3 = new Student()
        {
            Age = 40,
            FirstName = "Cretic",
            LastName = "Foo"
        };

        Student student4 = new Student()
        {
            Age = 12,
            FirstName = "Alice",
            LastName = "Zoo"
        };

        List<Student> students = new List<Student>();
        students.Add(student1);
        students.Add(student2);
        students.Add(student3);
        students.Add(student4);


        var res11 = students.FirstOrDefault(st => st.Age < 30);
        var res12 = students.Where(student => student.Age > 18).ToList();

        var res = students.Select(student => student.Age).ToList();
        var res1 = students.Select(st => st.Age > 18).ToList();
        var res2 = students.OrderBy(st => st.FirstName).ToList();
        var res3 = students.OrderByDescending(st => st.Age).ToList();
        var res4 = students.Sum(st => st.Age);
        var re5 = students.Last(st => st.Age > 10);
        var res6 = students.All(st => st.Age > 10);
        var res7 = students.All(st => st.Age > 20);
        var res8 = students.Any(st => st.Age > 40);
        var res20 = students.Count(st => st.Age > 10);
        var res21 = students.Single(st => st.FirstName == "Alice");
        //var res23 = students.SingleOrDefault(st => st.Age > 15);
        var res22 = students.SingleOrDefault(st => st.FirstName == "Salom");


        var nums = new List<int>() { 3, 4, 5, 1, 6, 7 };

        var res23 = nums.
                

        int a = 5;







    }
}

