using test;

class Program
{
    static void Main(string[] args)
    {
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "example.json");

        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, "[]");
        }

        //using(StreamReader sr = new StreamReader(filePath))
        //{

        //}

        using(StreamWriter writer = new StreamWriter(filePath, append:true))
        {
            writer.WriteLine("salom");
        }
    }

    public static void Foo2()
    {
        string filePath = @"D:\OnlineCource\video1.mp4";
        string extension = Path.GetExtension(filePath);
        string savingPath = Path.Combine(Directory.GetCurrentDirectory(), "video5" + extension);


        using (FileStream sourceStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        using (FileStream destinationStream = new FileStream(savingPath, FileMode.Create, FileAccess.Write))
        {
            sourceStream.CopyTo(destinationStream);
        }

        Console.WriteLine("File copied successfully!");

    }


    public static void Foo1()

    {
        string filePath = @"D:\OnlineCource\video1.mp4";
        string extension = Path.GetExtension(filePath);
        string savingPath = Path.Combine(Directory.GetCurrentDirectory(), "video1" + extension);

        const int bufferSize = 81920000; // 80 KB buffer size
        byte[] buffer = new byte[bufferSize];
        int bytesRead;


        using (FileStream sourceStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        using (FileStream destinationStream = new FileStream(savingPath, FileMode.Create, FileAccess.Write))
        {
            while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                Console.WriteLine(destinationStream.Position);
                destinationStream.Write(buffer, 0, bytesRead);
            }
        }

        Console.WriteLine("File copied successfully!");

        StreamReader streamReader = new StreamReader(filePath);
        StreamWriter streamWriter = new StreamWriter(savingPath);
    }



    public static void LinqTask()
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

        int a = 5;
    }
}

