namespace FactoryExample.Services
{
    public interface IFileServiceFactory
    {
        IFileService Resolve(FileStore store);
    }
}
