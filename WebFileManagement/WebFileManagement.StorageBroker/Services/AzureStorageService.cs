using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFileManagement.StorageBroker.Services
{
    public class AzureStorageService : IStorageBrokerService
    {
        public void CreateDirectory(string directoryPath)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllFilesAndDirectories(string directoryPath)
        {
            throw new NotImplementedException();
        }

        public void UploadFile(string filePath, Stream stream)
        {
            throw new NotImplementedException();
        }
    }
}
