using _2._2dars.Api.Models;
using _2._2dars.Api.Services;

namespace _2._2dars.Api;

internal class Program
{
    private static string student1UserName = "student1";
    private static string student1Password = "student1";

    private static string student2UserName = "student2";
    private static string student2Password = "student2";

    private static string teacherUserName = "teacher";
    private static string teacherPassword = "teacher";

    private static string directorUserName = "director";
    private static string directorPassword = "director";


    static void Main(string[] args)
    {
        //var student1 = new Student()
        //{
        //    FirstName = "Ali",
        //    LastName = "Vali",
        //    Age = 20,
        //    Degree = "3",
        //    Gender = "men",
        //};

        //var student2 = new Student()
        //{
        //    FirstName = "WWW",
        //    LastName = "AAA",
        //    Age = 20,
        //    Degree = "3",
        //    Gender = "men",
        //};

        //var studentService = new StudentService();
        ////studentService.AddStudent(student1);
        ////studentService.AddStudent(student2);

        //var students = studentService.GetAllStudents();

        //Console.WriteLine(students[0].Id + " " + students[0].FirstName);
        //Console.WriteLine(students[1].Id + " " + students[1].FirstName);

        //studentService.DeleteStudent(students[1].Id);

        //var newStudents = studentService.GetAllStudents();

        //var a = 5;

        StartFrontEnd();



    }

    public static void StartFrontEnd()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("0. Stop");
            Console.WriteLine("1. Login");
            Console.Write("Enter : ");
            var option = Console.ReadLine();

            if (option == "0")
            {
                Console.WriteLine("thanks");
                return;
            }
            else if (option == "1")
            {
                LoginPage();
            }
        }
    }

    public static void LoginPage()
    {
        while (true)
        {
            Console.Clear();
            Console.Write("Enter user name :");
            var userName = Console.ReadLine();
            Console.Write("Enter password  :");
            var password = Console.ReadLine();
            

            if (userName == directorUserName && password == directorPassword)
            {

            }
            else if (userName == teacherUserName && password == teacherPassword)
            {
                RunTeacher();
            }
            else if (userName == student1UserName && password == student1Password)
            {

            }
            else if (userName == student2UserName && password == student2Password)
            {

            }
        }
    }

    public static void RunTeacher()
    {
        var studentService = new StudentService();
        var testService = new TestService();    
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("0. Quit");
            Console.WriteLine("1. Add test");
            Console.WriteLine("2. Delete test");
            Console.WriteLine("3. Read tests");
            Console.WriteLine("4. Get by id");
            Console.WriteLine("5. Update test");
            Console.WriteLine("6. Get random tests");
            Console.Write("enter : ");
            var option = Console.ReadLine();

            if (option == "0")
            {
                return;
            }
            else if(option == "1")
            {
                var test = new Test();
                Console.Write("Question text :");
                test.QuestionText = Console.ReadLine();

                Console.Write("A variant :");
                test.AVariant = Console.ReadLine();

                Console.Write("B variant :");
                test.BVariant = Console.ReadLine();

                Console.Write("C variant :");
                test.CVariant = Console.ReadLine();

                Console.Write("Answer A/B/C :");
                test.Answer = Console.ReadLine();

                testService.AddTest(test);
            }
            else if(option == "2")
            {
                Console.Write("Enter id :");
                var id = Guid.Parse(Console.ReadLine());
                testService.DeleteTest(id);
            }
            else if(option == "3")
            {
                var tests = testService.GetAllTests();
                foreach (var test in tests)
                {
                    Console.WriteLine($"id : {test.Id}");
                    Console.WriteLine($"Question text : {test.QuestionText}");
                    Console.WriteLine($"A variant : {test.AVariant}");
                    Console.WriteLine($"B variant : {test.BVariant}");
                    Console.WriteLine($"C variant : {test.CVariant}");
                    Console.WriteLine($"Answer : {test.Answer}");
                    Console.WriteLine();
                }
            }
            else if(option == "4")
            {
                Console.Write("Enter id :");
                var id = Guid.Parse(Console.ReadLine());
                var test = testService.GetById(id);
                Console.WriteLine($"id : {test.Id}");
                Console.WriteLine($"Question text : {test.QuestionText}");
                Console.WriteLine($"A variant : {test.AVariant}");
                Console.WriteLine($"B variant : {test.BVariant}");
                Console.WriteLine($"C variant : {test.CVariant}");
                Console.WriteLine($"Answer : {test.Answer}");
                Console.WriteLine();
            }
            else if(option == "5")
            {
                var test = new Test();

                Console.Write("Question id :");
                test.Id = Guid.Parse(Console.ReadLine());

                Console.Write("Question text :");
                test.QuestionText = Console.ReadLine();

                Console.Write("A variant :");
                test.AVariant = Console.ReadLine();

                Console.Write("B variant :");
                test.BVariant = Console.ReadLine();

                Console.Write("C variant :");
                test.CVariant = Console.ReadLine();

                Console.Write("Answer A/B/C :");
                test.Answer = Console.ReadLine();

                testService.UpdateTest(test);
            }
            else if(option == "6")
            {
                Console.Write("Enter :");
                var choice = int.Parse(Console.ReadLine());
                var tests = testService.GetRandomTests(choice);

                foreach (var test in tests)
                {
                    Console.WriteLine($"id : {test.Id}");
                    Console.WriteLine($"Question text : {test.QuestionText}");
                    Console.WriteLine($"A variant : {test.AVariant}");
                    Console.WriteLine($"B variant : {test.BVariant}");
                    Console.WriteLine($"C variant : {test.CVariant}");
                    Console.WriteLine($"Answer : {test.Answer}");
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
