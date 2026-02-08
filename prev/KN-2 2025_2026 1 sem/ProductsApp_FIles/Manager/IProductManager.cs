using Data;
using System.Data;

namespace Manager
{
    public interface IProductManager
    {
        List<Product> Read(string path);
        void Write(string path, List<Product> products);
    }
}
