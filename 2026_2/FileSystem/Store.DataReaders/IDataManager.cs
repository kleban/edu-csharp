using Store.Domain;

namespace Store.DataReaders
{
    public interface IDataManager
    {
        List<Product> Read(string path);
        void Write(List<Product> list, string path);
    }
}
