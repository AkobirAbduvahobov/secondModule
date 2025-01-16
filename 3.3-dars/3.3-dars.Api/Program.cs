using System.Reflection.PortableExecutable;

namespace _3._3_dars.Api;

internal class Program
{
    static void Main(string[] args)
    {
        string directoryPath = @"D:\Projects\.Net Projects(Console)\secondModule\3.3-dars\3.3-dars.Api\bin\Debug\net8.0\example.txt";
        Console.WriteLine(directoryPath);
        var root = Directory.GetParent(directoryPath);
        Console.WriteLine(root.FullName);


    }


    public static List<int> GetNumberOfDigitsEachLine(string filePath)
    {
        var numberOfDigitsEachLine = new List<int>();

        using(var reader = new StreamReader(filePath))
        {
            var line = string.Empty;
            while(true)
            {
                line = reader.ReadLine();   
                if(line == null) break;
                var count = line.Count(character => char.IsDigit(character));
                numberOfDigitsEachLine.Add(count);
            }
        }

        return numberOfDigitsEachLine;
    }


    public static void StreamReaderInformation(string filePath, string destinationFilePath)
    {
        using(var streamReader = new StreamReader(filePath))
        {
            using(var streamWriter =  new StreamWriter(destinationFilePath, true))
            {
                var line = string.Empty;
                while (true)
                {
                    line = streamReader.ReadLine();
                    if (line == null) break;
                    streamWriter.WriteLine(line);
                }
            }
        }
    }



    public static void DisplayAllFiles(string folderPath)
    {
        var files = new List<string>();
        FillAllFiles(folderPath, files);

        foreach (var file in files)
        {
            Console.WriteLine(file);
        }
    }

    private static void FillAllFiles(string folderPath, List<string> files)
    {
        string[] filesInPath = Directory.GetFiles(folderPath);
        string[] foldersInPath = Directory.GetDirectories(folderPath);
        files.AddRange(filesInPath);

        foreach (var folder in foldersInPath)
        {
            FillAllFiles(folder, files);
        }
    }



    public static void CopyFileWithChunks(string filePath, string newFileName)
    {
        var fileExtension = Path.GetExtension(filePath);
        var destinationFilePath = Path.Combine(Directory.GetCurrentDirectory(), newFileName + fileExtension);
        var fileInfo = new FileInfo(filePath);

        var fileLength = fileInfo.Length;   

        var bytes = 1024 * 1024 * 100;    
        byte[] buffer = new byte[bytes];
        int bytesRead;
        
        var bytesPercent = bytes * 100d / fileLength;
        var percent = bytesPercent;



        using (FileStream fileStreamPath = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            using (FileStream fileDestination = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
            {
                while(true)
                {
                    Console.WriteLine($"{(int)percent} %");
                    percent += bytesPercent;
                    bytesRead = fileStreamPath.Read(buffer, 0, buffer.Length);
                    if (bytesRead <= 0) break; 
                    fileDestination.Write(buffer, 0, bytesRead);
                }
            }
        }
    }

    public static void CopyFileAtOnce(string filePath, string newFileName)
    {
        var fileExtension = Path.GetExtension(filePath);
        var destinationFilePath = Path.Combine(Directory.GetCurrentDirectory(), newFileName + fileExtension);

        using(FileStream fileStreamPath = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            using(FileStream fileDestination = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
            {
                fileStreamPath.CopyTo(fileDestination);
            }
        }
    }



    public static void InformationPath()
    {
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "qovun.txt");
        var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "data");


        Console.WriteLine("File " + Path.GetExtension(filePath));
        Console.WriteLine("Folder " + Path.GetExtension(folderPath));

        var fileInfo = new FileInfo(filePath);

        var fileFullName = fileInfo.FullName;
        var fileExtension = fileInfo.Extension;

        //fileFullName = fileFullName.Remove(fileFullName.Length - fileExtension.Length);
        fileFullName = fileFullName.Replace(fileExtension, ".json");

        if (!File.Exists(fileFullName))
        {
            string[] res = File.ReadAllLines(filePath);
            File.WriteAllLines(fileFullName, res);
        }
    }


    public static void InformationDirectoryInfo()
    {
        string directoryPath = Path.Combine(Directory.GetCurrentDirectory());
        string directoryPath1 = Path.Combine(Directory.GetCurrentDirectory());
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }
        DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

        Console.WriteLine(Directory.GetCreationTime(directoryPath));
        Console.WriteLine(directoryInfo.CreationTime);

        Console.WriteLine(directoryInfo.FullName);

        Console.WriteLine(directoryInfo.Parent);
        Console.WriteLine(directoryInfo.FullName);
        Console.WriteLine(directoryInfo.LinkTarget);
        var res1 = directoryInfo.EnumerateFileSystemInfos();
        var res2 = directoryInfo.EnumerateFiles();
    }


    public static void InfoFileInfo()
    {
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "test.txt");
        var qovunFilePath = Path.Combine(Directory.GetCurrentDirectory(), "qovun.txt");
        FileInfo fileInfo = new FileInfo(filePath);

        if (!fileInfo.Exists)
        {
            fileInfo.Create().Close();
        }

        //StreamWriter streamWriter = fileInfo.AppendText();
        //streamWriter.Write("salom");
        //streamWriter.Write("hello");
        //streamWriter.Write("privet");
        //streamWriter.Close();

        //fileInfo.OpenWrite();

        //fileInfo.Replace(qovunFilePath, null);


        Console.WriteLine(fileInfo.CreationTime);
        Console.WriteLine(fileInfo.CreationTimeUtc);
        Console.WriteLine(fileInfo.FullName);
        Console.WriteLine(fileInfo.Name);
        Console.WriteLine(fileInfo.Directory);
        Console.WriteLine(fileInfo.DirectoryName);
        Console.WriteLine(fileInfo.Length);
        Console.WriteLine(fileInfo.LastWriteTime);
    }

    public static int GetNumber1()
    {
        return 0;
    }

    public static int GetNumber2() => 0;
}
