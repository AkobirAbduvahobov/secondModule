namespace _3._1dars;

internal class Program
{
    static void Main(string[] args)
    {
        // lambda expression

        // age => age > 18
        // person => person.Age

        Student student1 = new Student("Lobar", "Odilova", 26, 100);
        Student student2 = new Student("Davron", "Rustamov", 17, 2000);
        Student student3 = new Student("Rustam", "Elbekov", 15, 700);
        Student student4 = new Student("Qodir", "Odilov", 35, 10000);
        Student student5 = new Student("Ali", "Odilov", 22, 8000);

        List<Student> students = new List<Student>();
        students.Add(student1);
        students.Add(student2);
        students.Add(student3);
        students.Add(student4);
        students.Add(student5);

        var res = students.Where(st => st.Age > 18).ToList();
        var res1 = students.Where(st => st.Cash < 1000).ToList();
        var res2 = students.Where(st => char.IsUpper(st.FirstName[0])).ToList();
        var res3 = students.Where(st => char.IsLower(st.FirstName[0])).ToList();

        var res4 = students.Select(st => st.FirstName).ToList();

        List<int> ints = new List<int>() { 2, 3, 5, 4, 6, 7, 8, 4, 5, 9, 0 };
        var res5 = ints.Select(i => i % 2 == 0 ? i * 2 : i).ToList();

        var res6 = students.OrderBy(st => st.Age).ToList();    
        var res7 = students.OrderBy(st => st.FirstName).ToList();    
        var res8 = students.OrderByDescending(st => st.Cash).ToList();

        var res9 = students.Count(st => st.Age > 18);

        var res10 = students.Where(st => st.Age > 18).Sum(st => st.Cash);

        var res12 = students.Min(st => st.Age);

        var res11 = students.Where(stu => stu.Age == students.Min(st => st.Age)).ToList();

        var res13 = students.Average(st =>  st.Age); 
        
        var res14 = students.All(st =>  st.Cash > 0);

        var res15 = students.All(st =>  st.Cash > 150);

        var res16 = students.Any(st => st.Age > 30);

        var res17 = students.Any(st => st.Age > 40);

        var res18 = students.First(st => st.Age < 25);

        var res19 = students.FirstOrDefault(st => st.Age < 10);

        var res20 = students.Single(st => st.Age < 17);
        
        var res21 = students.SingleOrDefault(st => st.Age < 10);





        //foreach (var student in res)
        //{
        //    Console.WriteLine(student.FirstName);
        //}

        int a = 5;




    }

    public static bool Is18(int age)
    {
        return age > 18;
    }
}
