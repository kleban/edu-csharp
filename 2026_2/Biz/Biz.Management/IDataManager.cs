using Biz.Data.Models;

namespace Biz.Management
{
    public interface IDataManager
    {
        List<Business> Read(string path);
        void Write(string path, List<Business> biz);
    }
}
