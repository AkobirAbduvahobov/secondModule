using System.Net;

namespace WebFileManagement.StorageBroker.Services;

public interface IStorageBrokerService
{
    void UploadFile(string filePath, Stream stream);
    void CreateDirectory(string directoryPath);
    List<string> GetAllFilesAndDirectories(string directoryPath);
}
