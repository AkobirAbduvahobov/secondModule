namespace FactoryExample.Services
{
    public class FileServiceFactory : IFileServiceFactory
    {
        private Dictionary<FileStore, IFileService> Services = new Dictionary<FileStore, IFileService>();
        public IFileService Resolve(FileStore store)
        {
            if (!Services.ContainsKey(store))
            {
                Services[store] = store switch
                {
                    FileStore.Local => new LocalFileService(),
                    _ => new AwsFileService(),
                };
            }
            return Services[store];
        }
    }
}
